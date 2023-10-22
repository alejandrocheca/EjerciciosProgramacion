CREATE DATABASE Ejemplos;
USE Ejemplos;

/*Creacion de tablas.*/
CREATE TABLE departamentos (
	id_dep int PRIMARY KEY,
    descripcion varchar(255) NOT NULL
);

CREATE TABLE empleados (
	id_num int PRIMARY KEY,
    name varchar(255) NOT NULL,
    categoria varchar(255) NOT NULL,
    salario int NOT NULL,
	id_dep int
);

CREATE TABLE productos (
	id_pro int PRIMARY KEY,
    descripcion varchar(255) NOT NULL,
    pvp int NOT NULL
);

CREATE TABLE ventas (
	id_ventas int PRIMARY KEY AUTO_INCREMENT,
	id_num int,
    id_pro int,
    cant int NOT NULL
);

/*Enlazar con claves foraneas.*/
ALTER TABLE empleados ADD FOREIGN KEY (id_dep) REFERENCES departamentos(id_dep);
ALTER TABLE ventas ADD FOREIGN KEY (id_num) REFERENCES empleados(id_num);
ALTER TABLE ventas ADD FOREIGN KEY (id_pro) REFERENCES productos(id_pro);

INSERT INTO departamentos (id_dep, descripcion)
VALUES (01, 'Servicios Centrales'), (02, 'Sucursal Madrid'), (03, 'Sucursal Toledo');

INSERT INTO empleados (id_num, name, categoria, salario)
VALUES (001, 'Javier Sanchez', 'Director', 250000), (002, 'Elena Gutiérrez', 'Secretaria', 100000),
(003, 'Angel Hernández', 'Manager', 175000), (004, 'Rosa Anguiano', 'Commercial', 150000),
(005, 'Maria Bernal', 'Secretaria', 90000), (006, 'Miguel Santamaría', 'Commercial', 150000);

INSERT INTO productos (id_pro, descripcion, pvp)
VALUES (01, 'DVD', 25000), (02, 'CPU', 120000), (03, 'Color Monitor 17"', 30000),
(04, 'Mouse', 1000), (05, 'Laser Printer', 110000);

INSERT INTO ventas (id_num, id_pro, cant)
VALUES (003,01,2), (002,05,1), (004,02,3), (006,02,4), (006,03,7),
(004,05,4), (003,02,10), (002,03,2), (005,02,1);

/*Generar facturas en forma de tupla de todos los productos por pantalla.
Cada factura debe contener
- código del vendedor
- código del producto
- precio unitario
- cantidad vendida
- base imponible (precio por unidades vendidas)
- tipo de IVA aplicable (18% en todos)
- importe total de la factura correspondiente a ese vendedor (importe + IVA)*/
SELECT  e.id_num, p.id_pro, p.pvp, s.cant, p.pvp+(p.pvp*0.21) as 'Price with tax base', p.pvp+(p.pvp*0.18)
AS 'IVA 18%'
FROM empleados e
INNER JOIN ventas s ON e.id_num = s.id_num
INNER JOIN productos p ON s.id_pro = p.id_pro;

/*Obtener el código del producto y el número de veces que se ha vendido, del producto que
en más ocasiones se ha vendido.*/
SELECT id_pro, SUM(cant) AS 'Times it has been sold'
FROM ventas
GROUP BY id_pro
ORDER BY SUM(cant) DESC
LIMIT 1;

/*Obtener el nombre y categoría profesional de aquellos empleados que hayan obtenido
más ingresos en ventas que cualquier Comercial.*/
SELECT name, categoria AS 'Job', sum(pvp) AS 'Earnings'
FROM empleados
INNER JOIN ventas ON empleados.id_num = ventas.id_num
INNER JOIN productos ON productos.id_pro = ventas.id_num
WHERE categoria > 'Commercial'
GROUP BY name;

/*Aumentar un 5% el salario de los empleados que hayan vendido más unidades de
productos con un precio superior a 50.000.*/
UPDATE empleados e 
INNER JOIN ventas v ON e.id_num = v.id_num
INNER JOIN productos p ON v.id_pro = p.id_pro
SET e.salario = e.salario + e.salario*0.1
WHERE e.salario > v.cant*p.pvp > 50000;

/*Eliminar del departamento "Sucursal de Toledo".*/
DELETE FROM departamentos WHERE descripcion='Sucursal Toledo';

/*Eliminar el contenido y las estructuras de las tablas.*/
DROP TABLE empleados, departamentos, productos, ventas;