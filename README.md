# WorkerCRUD
ASP.NET CORE 2.2 CRUD App with EntityFramework and MySQL

simple CRUD приложение для ведения списка работников.

For MySQL database:

connectionString="Datasource=localhost;Database=myprojectdb;uid=root;pwd=ruslan139"

SQL:
Создание базы и таблицы:

CREATE DATABASE myprojectdb;

USE myprojectdb;
 
CREATE TABLE Worker
(
    Id int auto_increment primary key,
    Name varchar(255),
    Email varchar(255),
    Phone varchar(15),
    Gender int,
    Specialization varchar(255),
    Created timestamp DEFAULT CURRENT_TIMESTAMP
);

Заполнение тестовых данных:

INSERT INTO Worker (Id, Name, Email, Phone, Gender, Specialization, Created) VALUES 
(1, 'Tom Rain', 'tom.rain@gmail.com', '0327253145', 1, 'manager', '2019-10-05 09:07:24'),
(2, 'Tanya Volk', 'tanya.volk@gmail.com', '0328023546', 2, 'nurse', '2019-10-06 17:17:24');
