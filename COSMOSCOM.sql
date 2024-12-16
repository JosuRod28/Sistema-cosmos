BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "Clientes" (
	"id_Cliente"	INTEGER,
	"Nombre"	TEXT,
	"Apellido_P"	TEXT,
	"Apellido_M"	TEXT,
	"Telefono1"	TEXT,
	"Telefono2"	TEXT,
	PRIMARY KEY("id_Cliente")
);
CREATE TABLE IF NOT EXISTS "Venta_Total" (
	"Folio"	INTEGER,
	"id_Cliente"	INTEGER,
	"Fecha_de_atencion"	TEXT,
	"Fecha_de_entrega"	TEXT,
	"Total"	TEXT,
	PRIMARY KEY("Folio"),
	FOREIGN KEY("id_Cliente") REFERENCES "Clientes"("id_Cliente")
);
CREATE TABLE IF NOT EXISTS "Roles" (
	"id_Rol"	INTEGER,
	"Rol"	TEXT,
	PRIMARY KEY("id_Rol")
);
CREATE TABLE IF NOT EXISTS "Formatos" (
	"id_Formato"	INTEGER,
	"Formato"	TEXT,
	PRIMARY KEY("id_Formato")
);
CREATE TABLE IF NOT EXISTS "TokensReestablecerClaves" (
	"id_token"	INTEGER,
	"id_usuario"	int NOT NULL,
	"Token"	TEXT NOT NULL,
	"ExpiracionToken"	TEXT NOT NULL,
	PRIMARY KEY("id_token" AUTOINCREMENT),
	FOREIGN KEY("id_usuario") REFERENCES "Usuarios"("id_usuario")
);
CREATE TABLE IF NOT EXISTS "Usuarios" (
	"id_usuario"	INTEGER,
	"usuario"	TEXT,
	"clave"	TEXT,
	"id_Rol"	INTEGER,
	"correo"	TEXT,
	PRIMARY KEY("id_usuario"),
	FOREIGN KEY("id_Rol") REFERENCES "Roles"("id_Rol")
);
CREATE TABLE IF NOT EXISTS "Detalle_Venta" (
	"Folio_Venta"	INTEGER NOT NULL,
	"id_Cliente"	INTEGER NOT NULL,
	"Formato"	TEXT NOT NULL,
	"Duracion"	NUMERIC NOT NULL,
	"Monto"	NUMERIC NOT NULL,
	FOREIGN KEY("Formato") REFERENCES "Formatos"("Formato"),
	FOREIGN KEY("Folio_Venta") REFERENCES "Venta_Total"("Folio"),
	FOREIGN KEY("id_Cliente") REFERENCES "Clientes"("id_Cliente")
);
INSERT INTO "Clientes" VALUES (1,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Clientes" VALUES (2,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Roles" VALUES (1,'admin');
INSERT INTO "Roles" VALUES (2,'user');
INSERT INTO "Formatos" VALUES (1,'VHS');
INSERT INTO "Formatos" VALUES (2,'Beta');
INSERT INTO "Formatos" VALUES (3,'MiniDV');
INSERT INTO "Formatos" VALUES (4,'8mm');
INSERT INTO "Formatos" VALUES (5,'Super8');
INSERT INTO "Formatos" VALUES (6,'DVD');
INSERT INTO "Usuarios" VALUES (1,'Maria','12345',1,NULL);
INSERT INTO "Usuarios" VALUES (3,'Josue','cosmos1',2,NULL);
COMMIT;
