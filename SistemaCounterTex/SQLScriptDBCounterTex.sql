create database DBcounterTex
use DBcounterTex

-- Creación de la tabla Usuario
CREATE TABLE Usuarios (
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    NombreUsuario NVARCHAR(50) NOT NULL,
    Correo NVARCHAR(50) NULL,
    Clave NVARCHAR(50) NULL
);

-- Creación de la tabla Satelite
CREATE TABLE Satelite (
    SateliteId INT IDENTITY(1,1) PRIMARY KEY,
    Fabricante NVARCHAR(100) NOT NULL,
    PagoPrendas DECIMAL(18, 2) NULL,
    Ganancias DECIMAL(18, 2) NULL,
    Operacion NVARCHAR(100) NULL,
    PagoOperacion DECIMAL(18, 2) NULL,
    Inventariomaquinas INT NULL,
    TipoMaquina NVARCHAR(50) NULL,
    IdUsuario INT NULL,
    FOREIGN KEY (IdUsuario) REFERENCES Usuarios(IdUsuario)
);

-- Creación de la tabla PerfilAdministrador
CREATE TABLE PerfilAdministrador (
    IdAdministrador INT IDENTITY(1,1) PRIMARY KEY,
    NombreAdministrador NVARCHAR(100) NULL,
    ProduccionDiaria INT NULL,
    ProduccionMensual INT NULL,
    ControlPrendas INT NULL,
    Registro NVARCHAR(100) NULL,
    Ganancias DECIMAL(18, 2) NULL,
    Pagos DECIMAL(18, 2) NULL,
    Gastos DECIMAL(18, 2) NULL,
    MetaPorCorte DECIMAL(18, 2) NULL,
    ConsultarInformacion NVARCHAR(200) NULL,
    ControlHorarios nvarchar(200) NULL,
    ChatInterno NVARCHAR(200) NULL,
    Proveedor NVARCHAR(100) NULL,
    BotonAyuda NVARCHAR(100) NULL,
    IdUsuario INT NULL,
    FOREIGN KEY (IdUsuario) REFERENCES Usuarios(IdUsuario)
);

-- Creación de la tabla PerfilEmpleado
CREATE TABLE PerfilEmpleado (
    IdEmpleado INT IDENTITY(1,1) PRIMARY KEY,
    ProduccionDiaria DECIMAL(18, 2) NULL,
    TipoPrenda NVARCHAR(100) NULL,
    TipoOperacion NVARCHAR(100) NULL,
    CantidadOperacion INT NULL,
    ValorOperacion DECIMAL(18, 2) NULL,
    ConsultarInformacion NVARCHAR(100) NULL,
    ControlHorarios DATETIME NULL,
    HoraEntrada DATETIME NULL,
    HoraSalida DATETIME NULL,
    MetaPorCorte DECIMAL(18, 2) NULL,
    BotonAyuda NVARCHAR(100) NULL,
    Estadisticas NVARCHAR(200) NULL,
    Observaciones NVARCHAR(500) NULL,
    IdUsuario INT NULL,
    FOREIGN KEY (IdUsuario) REFERENCES Usuarios(IdUsuario)
);

-- Creación de la tabla Registro
CREATE TABLE Registro (
    IdRegistro INT IDENTITY(1,1) PRIMARY KEY,
    Nombres NVARCHAR(100) NOT NULL,
    Apellidos NVARCHAR(100) NULL,
    Documento NVARCHAR(50) NOT NULL,
    Correo NVARCHAR(100) NULL,
    Contraseña NVARCHAR(100) NULL,
    ConfirmarContraseña NVARCHAR(100) NULL,
    FechaRegistro DATETIME NOT NULL
);

-- Creación de la tabla Proveedor
CREATE TABLE Proveedor (
    IdProveedor INT IDENTITY(1,1) PRIMARY KEY,
    NombreProveedor NVARCHAR(150) NOT NULL,
    PrecioPrenda DECIMAL(18, 2) NULL,
    TipoPrenda NVARCHAR(100) NOT NULL,
    Telefono NVARCHAR(50) NOT NULL,
    Direccion NVARCHAR(200) NULL,
    Ciudad NVARCHAR(100) NULL,
    Localidad NVARCHAR(100) NULL,
    Barrio NVARCHAR(100) NULL,
    CantidadPrendas INT NOT NULL
);


select * from Usuarios


-- Inserción en la tabla Usuario
INSERT INTO Usuarios(NombreUsuario, Correo, Clave)
VALUES
('admin', 'admin@correo.com', 'admin123'),
('empleado1', 'empleado1@correo.com', 'clave123'),
('empleado2', 'empleado2@correo.com', 'clave456');

-- Inserción en la tabla Satelite
INSERT INTO Satelite (Fabricante, PagoPrendas, Ganancias, Operacion, PagoOperacion, Inventariomaquinas, TipoMaquina, IdUsuario)
VALUES
('Fabricante A', 1000.00, 2000.00, 'Operación A', 500.00, 10, 'Máquina A', 1),
('Fabricante B', 1500.00, 2500.00, 'Operación B', 600.00, 15, 'Máquina B', 2),
('Fabricante C', 1200.00, 2200.00, 'Operación C', 550.00, 12, 'Máquina C', 3);

-- Inserción en la tabla PerfilAdministrador
INSERT INTO PerfilAdministrador (NombreAdministrador, ProduccionDiaria, ProduccionMensual, ControlPrendas, Registro, Ganancias, Pagos, Gastos, MetaPorCorte, ConsultarInformacion, ControlHorarios, ChatInterno, Proveedor, BotonAyuda, IdUsuario)
VALUES
('Administrador A', 100, 3000, 1, 'Registro A', 5000.00, 2000.00, 1500.00, 300.00, 'Información A', '2024-01-01 08:00:00', 'Chat A', 'Proveedor A', 'Ayuda A', 1),
('Administrador B', 120, 3600, 0, 'Registro B', 6000.00, 2200.00, 1800.00, 350.00, 'Información B', '2024-01-01 09:00:00', 'Chat B', 'Proveedor B', 'Ayuda B', 2);

-- Inserción en la tabla PerfilEmpleado
INSERT INTO PerfilEmpleado (
    ProduccionDiaria, 
    TipoPrenda, 
    TipoOperacion, 
    CantidadOperacion, 
    ValorOperacion, 
    ConsultarInformacion, 
    ControlHorarios, 
    HoraEntrada, 
    HoraSalida, 
    MetaPorCorte, 
    BotonAyuda, 
    Estadisticas, 
    Observaciones, 
    IdUsuario
) 
VALUES 
-- Registro 1
(100.50, 'Camisa', 'Corte', 50, 25.75, 'Sí', '2024-12-12 08:00:00', '2024-12-12 08:00:00', '2024-12-12 17:00:00', 500.00, 'No', 'Producción diaria alcanzada', 'Todo en orden', 1),
-- Registro 2
(75.25, 'Pantalón', 'Costura', 30, 18.50, 'No', '2024-12-12 09:00:00', '2024-12-12 09:00:00', '2024-12-12 18:00:00', 400.00, 'Sí', 'Producción por debajo de la meta', 'Revisar desempeño', 2),
-- Registro 3
(50.00, 'Falda', 'Planchado', 20, 15.00, 'Sí', '2024-12-12 07:30:00', '2024-12-12 07:30:00', '2024-12-12 16:30:00', 300.00, 'No', 'Cumple parcialmente', 'Se requiere mejorar tiempos', 3);

-- Nota: Ajusta los valores de IdUsuario según los datos existentes en la tabla Usuarios.


-- Inserción en la tabla Registro
INSERT INTO Registro (Nombres, Apellidos, Documento, Correo, Contraseña, ConfirmarContraseña, FechaRegistro)
VALUES
('Juan', 'Pérez', '1234567890', 'juan@correo.com', 'contraseña1', 'contraseña1', '2024-01-01 10:00:00'),
('Maria', 'Gomez', '9876543210', 'maria@correo.com', 'contraseña2', 'contraseña2', '2024-01-02 11:00:00');


-- Inserción en la tabla Proveedor
INSERT INTO Proveedor (NombreProveedor, PrecioPrenda, TipoPrenda, Telefono, Direccion, Ciudad, Localidad, Barrio, CantidadPrendas)
VALUES
('Proveedor A', 20.00, 'Camisa', '555-1234', 'Calle A, 123', 'Ciudad A', 'Localidad A', 'Barrio A', 200),
('Proveedor B', 25.00, 'Pantalón', '555-5678', 'Calle B, 456', 'Ciudad B', 'Localidad B', 'Barrio B', 150);


select* from Registro

select* from Usuarios

select* from PerfilEmpleado

select* from PerfilAdministrador

EXEC sp_rename 'Usuario', 'Usuarios';