CREATE DATABASE RedesSociales;
USE RedesSociales;

-- Tabla de Usuarios
CREATE TABLE Usuarios (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    CorreoElectronico VARCHAR(100) NOT NULL,
    Contraseña VARCHAR(255) NOT NULL,
    FechaRegistro TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Tabla de Publicaciones
CREATE TABLE Publicaciones (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Contenido TEXT NOT NULL,
    FechaPublicacion TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    AutorID INT,
    FOREIGN KEY (AutorID) REFERENCES Usuarios(ID)
);

-- Tabla de Comentarios
CREATE TABLE Comentarios (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Contenido TEXT NOT NULL,
    FechaComentario TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    AutorID INT,
    PublicacionID INT,
    FOREIGN KEY (AutorID) REFERENCES Usuarios(ID),
    FOREIGN KEY (PublicacionID) REFERENCES Publicaciones(ID)
);

-- Tabla de Amistades (relación muchos a muchos)
CREATE TABLE Amistades (
    Usuario1ID INT,
    Usuario2ID INT,
    Estado ENUM('Pendiente', 'Aceptada', 'Rechazada') DEFAULT 'Pendiente',
    PRIMARY KEY (Usuario1ID, Usuario2ID),
    FOREIGN KEY (Usuario1ID) REFERENCES Usuarios(ID),
    FOREIGN KEY (Usuario2ID) REFERENCES Usuarios(ID)
);

-- Tabla de Likes
CREATE TABLE Likes (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    UsuarioID INT,
    PublicacionID INT,
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(ID),
    FOREIGN KEY (PublicacionID) REFERENCES Publicaciones(ID)
);

-- Tabla de Mensajes Privados
CREATE TABLE MensajesPrivados (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    EmisorID INT,
    ReceptorID INT,
    Contenido TEXT NOT NULL,
    FechaEnvio TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (EmisorID) REFERENCES Usuarios(ID),
    FOREIGN KEY (ReceptorID) REFERENCES Usuarios(ID)
);

-- Tabla de Grupos
CREATE TABLE Grupos (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Descripcion TEXT,
    FechaCreacion TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    AdministradorID INT,
    FOREIGN KEY (AdministradorID) REFERENCES Usuarios(ID)
);

-- Tabla de MiembrosDeGrupo (relación muchos a muchos)
CREATE TABLE MiembrosDeGrupo (
    GrupoID INT,
    UsuarioID INT,
    PRIMARY KEY (GrupoID, UsuarioID),
    FOREIGN KEY (GrupoID) REFERENCES Grupos(ID),
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(ID)
);

-- Inserciones en la tabla de Usuarios
INSERT INTO Usuarios (Nombre, CorreoElectronico, Contraseña) VALUES
('Usuario1', 'usuario1@example.com', 'contrasena1'),
('Usuario2', 'usuario2@example.com', 'contrasena2'),
('Usuario3', 'usuario3@example.com', 'contrasena3');

-- Inserciones en la tabla de Publicaciones
INSERT INTO Publicaciones (Contenido, AutorID) VALUES
('Esta es la primera publicación', 1),
('Otra publicación interesante', 2),
('Una tercera publicación', 1);

-- Inserciones en la tabla de Comentarios
INSERT INTO Comentarios (Contenido, AutorID, PublicacionID) VALUES
('Comentario en la primera publicación', 2, 1),
('Comentario en la segunda publicación', 3, 2),
('Otro comentario en la primera publicación', 1, 1);

-- Inserciones en la tabla de Amistades
INSERT INTO Amistades (Usuario1ID, Usuario2ID, Estado) VALUES
(1, 2, 'Aceptada'),
(2, 3, 'Pendiente'),
(1, 3, 'Rechazada');

-- Inserciones en la tabla de Likes
INSERT INTO Likes (UsuarioID, PublicacionID) VALUES
(1, 2),
(2, 1),
(3, 1);

-- Inserciones en la tabla de Mensajes Privados
INSERT INTO MensajesPrivados (EmisorID, ReceptorID, Contenido) VALUES
(1, 2, 'Hola, ¿cómo estás?'),
(2, 3, 'Bien, gracias. ¿Y tú?');

-- Inserciones en la tabla de Grupos
INSERT INTO Grupos (Nombre, Descripcion, AdministradorID) VALUES
('Grupo1', 'Grupo de prueba 1', 1),
('Grupo2', 'Grupo de prueba 2', 2);

-- Inserciones en la tabla de MiembrosDeGrupo
INSERT INTO MiembrosDeGrupo (GrupoID, UsuarioID) VALUES
(1, 1),
(1, 2),
(2, 2),
(2, 3);

/*Seleccionar todos los usuarios:*/
SELECT * FROM Usuarios;

/*Seleccionar las publicaciones y sus autores:*/
SELECT p.ID AS PublicacionID, p.Contenido AS PublicacionContenido, u.Nombre AS AutorNombre
FROM Publicaciones p
JOIN Usuarios u ON p.AutorID = u.ID;

/*Seleccionar los comentarios de una publicación específica:*/
SELECT c.ID AS ComentarioID, c.Contenido AS ComentarioContenido, u.Nombre AS AutorNombre
FROM Comentarios c
JOIN Usuarios u ON c.AutorID = u.ID
WHERE c.PublicacionID = 2;

/*Seleccionar todas las amistades aceptadas:*/
SELECT u1.Nombre AS Usuario1, u2.Nombre AS Usuario2
FROM Amistades a
JOIN Usuarios u1 ON a.Usuario1ID = u1.ID
JOIN Usuarios u2 ON a.Usuario2ID = u2.ID
WHERE a.Estado = 'Aceptada';

/*Seleccionar las publicaciones que un usuario ha dado like:*/
SELECT p.ID AS PublicacionID, p.Contenido AS PublicacionContenido
FROM Likes l
JOIN Publicaciones p ON l.PublicacionID = p.ID
WHERE l.UsuarioID = X;

/*Seleccionar los mensajes privados entre dos usuarios:*/
SELECT m.Contenido, u1.Nombre AS Emisor, u2.Nombre AS Receptor
FROM MensajesPrivados m
JOIN Usuarios u1 ON m.EmisorID = u1.ID
JOIN Usuarios u2 ON m.ReceptorID = u2.ID
WHERE (m.EmisorID = 1 AND m.ReceptorID = 1) OR (m.EmisorID = 3 AND m.ReceptorID = 1);

/*Seleccionar los grupos a los que un usuario pertenece*/
SELECT g.Nombre AS NombreDelGrupo, g.Descripcion AS DescripcionDelGrupo
FROM MiembrosDeGrupo mg
JOIN Grupos g ON mg.GrupoID = g.ID
WHERE mg.UsuarioID = 2;



