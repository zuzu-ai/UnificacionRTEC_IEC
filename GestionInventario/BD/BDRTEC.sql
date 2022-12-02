-- drop database RTEC;
create database RTEC;
use RTEC;

create table puesto(
pkid varchar(4) primary key,
nombre varchar(30),
estado varchar(1)
)engine=InnoDB DEFAULT CHARSET=latin1;

insert into puesto values ("1","Gerente","1");
insert into puesto values ("2","Vendedor","1");
-- TABLA JORNADA
create table jornada(
pkid varchar(4) primary key,
nombre varchar(30) null,
horainicio time not null,
horafin time not null,
estado varchar(1) not null
)engine=InnoDB DEFAULT CHARSET=latin1;
insert into jornada values ("1","Ventas", "07:00:00","17:00:00","1");
insert into jornada values ("2","Administracion", "08:00:00","16:30:00","1");
-- TABLA FOTO
create table foto (
pkId varchar(15) primary key,
fotografia LONGBLOB null
)ENGINE=InnoDB DEFAULT CHARSET=latin1;
-- TABLA EMPLEADO
create table empleado(
pkid varchar(4) primary key,
fkpuesto varchar(4) not null,
nombre varchar(60) not null,
DPI varchar(13) not null,
fkjornada varchar(4) not null,
contratacion date default null,
despido date default null,
foto varchar(15) default null,
estado varchar(1),

foreign key (fkpuesto) references puesto(pkid),
foreign key (fkjornada) references jornada(pkid),
foreign key (foto) references foto(pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;

insert into empleado values ("1","1", "David Enrique Guerra Lucio","2145896250101","1",null,null,null,"1");
insert into empleado values ("2","1", "Linda Martina Hernandez Lopez","5647821450101","1",null,null,null,"1");
-- TABLA TIPO USUARIO
create table tipousuario(
pkid varchar(4) primary key,
nombre varchar(15) not null,
estado varchar(1)
)engine=InnoDB DEFAULT CHARSET=latin1;

insert into tipousuario values ("1", "Administrador", "1");
insert into tipousuario values ("2", "Supervisor", "1");
insert into tipousuario values ("3", "Visitante", "1");
-- TABLA PREGUNTA
create table pregunta(
pkid varchar(4) primary key,
pregunta varchar(75) not null,
estado varchar(1)
)engine=InnoDB DEFAULT CHARSET=latin1;

insert into pregunta values ("1", "¿Año de nacimiento?", "1");
-- TABLA USUARIO
create table usuario(
pkid varchar(4) primary key,
fktipousuario varchar(4) not null,
fkempleado varchar(4) not null,
usuario varchar(15) not null,
contrasena varchar(100) not null,
fkpregunta varchar(4) not null,
repuesta varchar(100) not null,
estado varchar(1),
foreign key (fktipousuario) references tipousuario(pkid),
foreign key (fkpregunta) references pregunta(pkid),
foreign key (fkempleado) references empleado(pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;

insert into usuario values ("1", "1", "1", "admin","LKAekHU9EtweB49HAaTRfg==","1","1","1");
-- TABLA CLASIFICACION
create table clasificacion(
pkid varchar(4) primary key,
nombre varchar(35) not null,
estado varchar(1)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA BODEGA
create table bodega(
pkid varchar(4) primary key,
nombre varchar(35) not null,
estado varchar(1)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA UBICACION
create table ubicacion(
pkid varchar(4) primary key,
nombre varchar(4) not null,
fkbodega varchar(15) not null,
estado varchar(1),

foreign key (fkbodega) references bodega(pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA MARCA
create table marca(
pkid varchar(4) primary key,
nombre varchar(35) not null,
estado varchar(1)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA PROVEEDOR
create table proveedor(
pkid varchar(4) primary key,
nombre varchar(35) not null,
nit varchar(15) null,
telefono varchar(20) null,
detalles varchar(200) null,
estado varchar(1)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA CATEGORIA
create table categoria(
pkid varchar(4) primary key,
tipo varchar(1) not null,
catsup varchar(4) null,
nombre varchar(35) not null,
estado varchar(1),

foreign key (catsup) references categoria(pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;
insert into categoria values ("1","1","1","Ninguna","1");
insert into categoria values ("2","2","1","Ninguna","1");
insert into categoria values ("3","3","2","Ninguna","1");
-- TABLA TIPO TRANSACCION
create table tipotransac(
pkid varchar(4) primary key,
nombre varchar(35) not null,
accion varchar(1) not null,
estado varchar(1)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA TIPO ALMACENAMIENTO
create table tipoalmacen(
pkid varchar(4) primary key,
nombre varchar(35) not null,
estado varchar(1)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA SUCURSAL
create table sucursal(
pkid varchar(4) primary key,
nombre varchar(35) not null,
direccion varchar(50) not null,
estado varchar(1)
)engine=InnoDB DEFAULT CHARSET=latin1;

-- TABLAS DE PROCESOS
-- TABLA ENCABEZADO LISTA PROVEEDORES
create table proveedorE(
pkid varchar(4) primary key,
estado varchar(1)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA DETALLE LISTA PROVEEDORES
create table proveedorD(
pkid varchar(4) primary key,
fkproveedorE varchar(4) not null,
fkproveedor varchar(4) not null,
estado varchar(1),
foreign key (fkproveedorE) references proveedorE(pkid),
foreign key (fkproveedor) references proveedor(pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA INVENTARIOE
create table inventarioE(
pkid varchar(15) primary key,
fkclasificacion varchar(4) not null,
nombre varchar(50) not null,
estado varchar(1) not null,

foreign key (fkclasificacion) references clasificacion(pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA INVENTARIOD
create table inventarioD(
pkid varchar(15) primary key,
fkinventarioE varchar(15) not null,
serie varchar(15) null,
nombre varchar(50) not null,
descipcion varchar(200) null,
cantidad int not null,
precioc float null,
preciov float null,
fkmarca varchar(4) not null,
fktipoalmacen varchar(4) not null,
fkcategoria1 varchar(4) null,
fkcategoria2 varchar(4) null,
fkcategoria3 varchar(4) null,
fksucursal varchar(4) not null,
fkbodega varchar(4) not null,
fkubicacion varchar(4) not null,
fkproveedores varchar(4) null,
minimo int not null,
maximo int null,
estado varchar(1) not null,

foreign key (fkinventarioE) references inventarioE(pkid),
foreign key (fkmarca) references marca(pkid),
foreign key (fkcategoria1) references categoria(pkid),
foreign key (fkcategoria2) references categoria(pkid),
foreign key (fkcategoria3) references categoria(pkid),
foreign key (fksucursal) references sucursal(pkid),
foreign key (fkbodega) references bodega(pkid),
foreign key (fkubicacion) references ubicacion(pkid),
foreign key (fkproveedores) references proveedorE(pkid),
foreign key (fktipoalmacen) references tipoalmacen(pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA TRANSACCIONES
create table transacciones(
pkid varchar(15) primary key,
fkinventarioE varchar(15) not null,
fkinventarioD varchar(15) not null,
fktipotransac varchar(4) not null,
fecha date not null,
cantidad int not null,
precio float not null,
estado varchar(1) not null,

foreign key (fkinventarioE) references inventarioE(pkid),
foreign key (fkinventarioD) references inventarioD(pkid),
foreign key (fktipotransac) references tipotransac(pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA COTIZACIONE
create table cotizacionE(
pkid varchar(15) primary key,
proyecto varchar(80) not null,
fecha date not null,
total float null,
estado varchar(1) not null
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA COTIZACIOND
create table cotizacionD(
pkid varchar(15) primary key,
fkcotizacionE varchar(15) not null,
fkinventarioE varchar(15) not null,
fkinventarioD varchar(15) not null,
cantidad int not null,
precio float not null,
subtotal float not null,
estado varchar(1) not null,

foreign key (fkinventarioE) references inventarioE(pkid),
foreign key (fkinventarioD) references inventarioD(pkid),
foreign key (fkcotizacionE) references cotizacionE(pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;