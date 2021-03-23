Create database EMPLEADO;
GO

use EMPLEADO
go

Create table Tlb_Empleado(
Id_empledo int primary key identity ,
Empl_nombre varchar (50),
Empl_apellido varchar (50),
Empl_dui varchar (50),
Empl_direccion varchar (50),
Empl_tel varchar (50),
Empl_email varchar (50),
Empl_cargo varchar (50),

);
