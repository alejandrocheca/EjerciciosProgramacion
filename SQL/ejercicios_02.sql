-- Crear la base de datos
CREATE DATABASE CochesDB;

-- Usar la base de datos
USE CochesDB;

-- Crear la tabla de colores
CREATE TABLE Colores (
    ColorID INT PRIMARY KEY AUTO_INCREMENT,
    NombreColor VARCHAR(50) NOT NULL
);

-- Crear la tabla de marcas de coches
CREATE TABLE Marcas (
    MarcaID INT PRIMARY KEY AUTO_INCREMENT,
    NombreMarca VARCHAR(50) NOT NULL
);

-- Crear la tabla de modelos de coches
CREATE TABLE Modelos (
    ModeloID INT PRIMARY KEY AUTO_INCREMENT,
    NombreModelo VARCHAR(50) NOT NULL,
    MarcaID INT,
    FOREIGN KEY (MarcaID) REFERENCES Marcas(MarcaID)
);

-- Crear la tabla de coches
CREATE TABLE Coches (
    CocheID INT PRIMARY KEY AUTO_INCREMENT,
    Matricula VARCHAR(10) UNIQUE NOT NULL,
    ModeloID INT,
    ColorID INT,
    DiaFabricacion DATE,
    Velocidad INT,
    Peso DECIMAL(10, 2),
    KilometrosRecorridos INT,
    FOREIGN KEY (ModeloID) REFERENCES Modelos(ModeloID),
    FOREIGN KEY (ColorID) REFERENCES Colores(ColorID)
);

-- Rellenar la tabla de colores con datos aleatorios
INSERT INTO Colores (NombreColor)
VALUES
    ('Rojo'),
    ('Azul'),
    ('Blanco'),
    ('Negro'),
    ('Gris'),
    ('Verde'),
    ('Amarillo'),
    ('Plateado'),
    ('Naranja'),
    ('Marrón'),
    ('Dorado');

-- Rellenar la tabla de marcas con datos aleatorios (debes reemplazarlos por marcas de coches reales)
INSERT INTO Marcas (NombreMarca)
VALUES
    ('Toyota'),
    ('Honda'),
    ('Ford'),
    ('Chevrolet'),
    ('Volkswagen'),
    ('Nissan'),
    ('Mercedes-Benz'),
    ('BMW'),
    ('Audi'),
    ('Porsche'),
    ('Ferrari'),
    ('Lamborghini');

-- Rellenar la tabla de modelos con datos aleatorios (debes reemplazarlos por modelos de coches reales y ajustar las MarcaID)
INSERT INTO Modelos (NombreModelo, MarcaID)
VALUES
    ('Camry', 1),
	('Auris',2),
    ('Corolla',3),
    ('Rav4',4),
    ('Prius',5),
    ('Civic',6),
    ('Accord',7),
    ('CR-V',8),
    ('Mustang',9),
    ('F-150',10),
    ('Explorer',11),
    ('Escape',12),
    ('Silverado',13),
    ('Malibu',14),
    ('Polo',15),
    ('Golf',16),
    ('Bora',17),
    ('Altima',18),
    ('Rogue',19),
    ('Sentra',20),
    ('Pathfinder',21),
    ('clk 270',22),
    ('GLC',23),
    ('C-Class',24),
    ('S-Class',25),
    ('X5',26),
    ('Z4',27),
    ('7 Series',28),
    ('A4',29),
    ('Q5',30),
    ('A6',31),
    ('Q7',32),
    ('911',33),
    ('Cayenne',34),
    ('Panamera',35),
    ('488 GTB',36),
    ('F8 Tributo',37),
    ('Portofino',38),
    ('GTC4Lusso',39),
    ('812 Superfast',40),
    ('LaFerrari',41),
    ('Huracán',42),
    ('Aventador',43),
    ('Urus',44),
    ('Countach',45)
    
-- Rellenar la tabla de coches con datos aleatorios
INSERT INTO Coches (Matricula, ModeloID, ColorID, DiaFabricacion, Velocidad, Peso, KilometrosRecorridos)
VALUES
    ('ABC-123', 1, 1, '2023-01-15', 180, 1500.50, 20000),
    ('XYZ-789', 3, 2, '2023-02-20', 200, 1400.75, 18000),
    ('LMN-456', 5, 3, '2023-03-25', 220, 1600.25, 25000),
    ('PQR-789', 7, 4, '2023-04-30', 240, 1700.50, 22000),
    ('JKL-321', 9, 5, '2023-05-05', 260, 1800.75, 28000),
    ('EFG-654', 11, 6, '2023-06-10', 280, 1900.25, 30000),
    ('HIJ-987', 13, 7, '2023-07-15', 300, 2000.50, 26000),
    ('UVW-456', 15, 8, '2023-08-20', 320, 2100.75, 32000),
    ('MNO-123', 17, 9, '2023-09-25', 340, 2200.25, 35000),
    ('XYZ-123', 19, 10, '2023-10-30', 360, 2300.50, 30000);


/*Seleccionar todos los coches con su matrícula y modelo:*/
SELECT Coches.Matricula, Modelos.NombreModelo FROM Coches
JOIN Modelos ON Coches.ModeloID = Modelos.ModeloID;

/*Mostrar los coches de un color específico:*/
SELECT Coches.Matricula FROM Coches
JOIN Colores ON Coches.ColorID = Colores.ColorID
WHERE Colores.NombreColor = 'Rojo';

/*Listar los coches ordenados por velocidad de mayor a menor:*/
SELECT Coches.Matricula, Coches.Velocidad FROM Coches
ORDER BY Coches.Velocidad DESC;

/*Obtener el modelo y la marca de un coche en particular (utilizando la matrícula):*/
SELECT Modelos.NombreModelo, Marcas.NombreMarca FROM Coches
JOIN Modelos ON Coches.ModeloID = Modelos.ModeloID
JOIN Marcas ON Modelos.MarcaID = Marcas.MarcaID
WHERE Coches.Matricula = 'XXX-123';

/*Contar la cantidad de coches de cada color:*/
SELECT Colores.NombreColor, COUNT(*) AS Cantidad FROM Coches
JOIN Colores ON Coches.ColorID = Colores.ColorID
GROUP BY Colores.NombreColor;

/*Calcular el peso promedio de todos los coches:*/
SELECT AVG(Coches.Peso) AS PesoPromedio FROM Coches;

/*Mostrar los coches fabricados en una fecha específica:*/
SELECT Coches.Matricula, Coches.DiaFabricacion FROM Coches
WHERE Coches.DiaFabricacion = '2023-01-15';

/*Encontrar el coche más rápido:*/
SELECT Coches.Matricula, Coches.Velocidad FROM Coches
ORDER BY Coches.Velocidad DESC
LIMIT 1;

/*Listar todos los coches de una marca en particular (por ejemplo, Toyota):*/
SELECT Coches.Matricula FROM Coches
JOIN Modelos ON Coches.ModeloID = Modelos.ModeloID
JOIN Marcas ON Modelos.MarcaID = Marcas.MarcaID
WHERE Marcas.NombreMarca = 'Toyota';

/*Calcular la distancia total recorrida por todos los coches:*/
SELECT SUM(Coches.KilometrosRecorridos) AS DistanciaTotalRecorrida FROM Coches;
