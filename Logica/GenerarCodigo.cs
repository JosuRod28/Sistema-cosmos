using COSMOSCOM.Modelo;
using System;
using System.Configuration;
using System.Data.SQLite;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSMOSCOM.Logica
{
    public class GenerarCodigo
    {
        private static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        public void Generar_y_MandarClave(string emailUsuario)
        {
            var ranodm = new Random();
            string claveReset = ranodm.Next(100000, 999999).ToString("D6");
            string fechaExpiracion = DateTime.Now.AddMinutes(5).AddSeconds(1).ToString();
            int id_usuario = ObteneridUsuario(emailUsuario);

            if (id_usuario != -1)
            {
                using (SQLiteConnection conn = new SQLiteConnection(conexion))
                {
                    conn.Open();
                    string query = "INSERT INTO TokensReestablecerClaves(id_usuario,Token, ExpiracionToken) VALUES (@id_usuario,@token,@expiracion) ";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                        cmd.Parameters.AddWithValue("@token", claveReset);
                        cmd.Parameters.AddWithValue("@expiracion", fechaExpiracion);
                        cmd.ExecuteNonQuery();

                    }
                }
                EnviarCorreo(emailUsuario, claveReset);
                MessageBox.Show("Si el correo está registrado, recibirás un codigo para reestablecer tu contraseña.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Lo sentimos el correo del usuario no está registrado", "Confirmación", MessageBoxButtons.OK);
            }
        }
        public bool VerificarClave(string claveReset)
        {
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                string query = "SELECT count(*) from TokensReestablecerClaves where Token=@ClaveReset";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@ClaveReset", claveReset);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }  
        }

        private int ObteneridUsuario(string emailUsuario)
        {
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                string query = "SELECT id_usuario FROM Usuarios WHERE correo = @correo";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@correo", emailUsuario);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }
            return -1;
        }

        // Método para enviar el correo electrónico con el enlace de restablecimiento de contraseña
        private void EnviarCorreo(string correo, string claveReset)
        {
            string clave_reset = $"{claveReset}";
            string subject = "Solicitud para cambiar contraseña";
            string body = $"Ingresa la siguiente clave en el sistema para restablecer tu contraseña:\n{clave_reset}";

            if (CheckInternetConnection())
            {
                try
                {
                    using (SmtpClient client = new SmtpClient("smtp.gmail.com"))
                    {
                        client.Port = 587;
                        client.Credentials = new NetworkCredential("elenaherrera632@gmail.com", "kchklqboxcjadukc");
                        client.EnableSsl = true;
                        MailMessage mailMessage = new MailMessage();
                        mailMessage.From = new MailAddress("elenaherrera632@gmail.com");
                        mailMessage.To.Add(correo);
                        mailMessage.Subject = subject;
                        mailMessage.Body = body;
                        client.Send(mailMessage);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al enviar el correo:{ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No hay conexión a Internet. Por favor, verifica tu conexión y vuelve a intentarlo.","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }
        private bool CheckInternetConnection()
        {
            try
            {
                using (var ping = new Ping())
                {
                    PingReply reply = ping.Send("www.google.com");
                    return reply.Status==IPStatus.Success;
                }
            }
            catch
            {
                return false;
            }
        }
        // Clase para recibir la respuesta del token de la API
        public class TokenResponse
        {
            public string Token { get; set; }
        }
    }
}
