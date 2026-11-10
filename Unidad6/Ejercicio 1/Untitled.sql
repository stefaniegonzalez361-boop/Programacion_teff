
CREATE DATABASE IF NOT EXISTS Tienda;

USE Tienda;


CREATE TABLE IF NOT EXISTS Clientes (
    Cliente INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(100),
    Correo VARCHAR(100)
);


CREATE TABLE IF NOT EXISTS Pedidos (
    Pedido INT AUTO_INCREMENT PRIMARY KEY,
    Fecha DATE,
    Cliente INT,
    FOREIGN KEY (Cliente) REFERENCES Clientes(Cliente)
);


INSERT INTO Clientes (Nombre, Correo)
VALUES
('Juan Pérez', 'juan@mail.com'),
('Ana López', 'ana@mail.com');


INSERT INTO Pedidos (Fecha, Cliente)
VALUES
('2026-11-10', 1);

SELECT * FROM Clientes;


SELECT * FROM Pedidos;


SELECT
    Clientes.Cliente,
    Clientes.Nombre,
    Clientes.Correo,
    Pedidos.Pedido,
    Pedidos.Fecha
FROM Clientes
INNER JOIN Pedidos
ON Clientes.Cliente = Pedidos.Cliente;
