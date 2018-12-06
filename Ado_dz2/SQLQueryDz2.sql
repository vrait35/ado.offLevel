--CREATE DATABASE Users
--GO
USE Users
Go
CREATE TABLE Dz2User
(Id int NOT NULL PRIMARY KEY IDENTITY(1,1),
UserLogin nvarchar(30) NOT NULL,
UserPassword nvarchar(30) NOT NULL,
UserAdress nvarchar(30) NOT NULL,
UserPhone nvarchar(30) NOT NULL,
UserAdmin bit NOT NULL)
GO
INSERT Dz2User VALUES
('admin1','255255d','ул.Бурятская 25','+380675662536',1),
('editor1','366d633','ул.Верди 5','+380695486235',0),
('superadmin','255super255','ул.Пугачева 1','+380675232635',1),
('admin3','5663ddd','ул.Приволжская 32','+380985224635',1)
GO