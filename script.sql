-- Crear la tabla solo si no existe
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Integrante')
BEGIN
    CREATE TABLE Integrante (
        nombre          nchar(10) NOT NULL,
        apellido        nchar(10) NOT NULL,
        direccion       nchar(10) NOT NULL,
        id              nchar(10) NOT NULL,
        telefono        nchar(10) NOT NULL,
        edad            int       NOT NULL,
        NombreUsuario   nchar(10) NOT NULL,
        contraseña      nchar(10) NOT NULL,
        CONSTRAINT PK_Integrante PRIMARY KEY (id)
    );
END
GO

-- Insertar 5 integrantes con NombreUsuario y Contraseña
INSERT INTO Integrante (nombre, apellido, direccion, id, telefono, edad, NombreUsuario, Contraseña) VALUES
('Juan',   'Pérez',   'Calle123', '001', '1111111111', 25, 'juan',   'juanpass'),
('Lucía',  'Gómez',   'Av. Luna', '002', '2222222222', 30, 'lucia',  'luciapass'),
('Carlos', 'Ruiz',    'Sol 456',  '003', '3333333333', 28, 'carlos', 'carlospwd'),
('María',  'Lopez',   'Estrella', '004', '4444444444', 22, 'maria',  'mariapass'),
('Sofía',  'Torres',  'Río 789',  '005', '5555555555', 35, 'sofia',  'sofiapass');
GO
