-- drop database RTEC_IEC;
create database RTEC_IEC;
use RTEC_IEC;

-- TABLA EMPRESA
create table empresa(
ID_Empresa varchar(15) primary key,
Nombre varchar(30),
Estado varchar(1)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA PUESTO
create table puesto(
ID_Puesto varchar(15) primary key,
Nombre varchar(30),
Fk_Empresa varchar(15) not null,
Estado varchar(1), 

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA JORNADA
create table jornada(
ID_Jornada varchar(15) primary key,
Nombre varchar(30) null,
Hora_Inicio time not null,
Hora_Finalizacion time not null,
Fk_Empresa varchar(15) not null,
Estado varchar(1) not null,

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA FOTO
create table foto (
ID_Fotografia varchar(15) primary key,
Fotografia LONGBLOB null
)ENGINE=InnoDB DEFAULT CHARSET=latin1;
-- TABLA EMPLEADO
create table empleado(
ID_Empleado varchar(15) primary key,
Fk_Puesto varchar(15) not null,
Nombre varchar(60) not null,
DPI varchar(13) not null,
Fk_Jornada varchar(15) not null,
Fecha_Contratacion date default null,
Fecha_Despido date default null,
Fk_Fotografia varchar(15) default null,
Fk_Empresa varchar(15) not null,
Estado varchar(1),

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa),
foreign key (Fk_Puesto) references puesto(ID_Puesto),
foreign key (Fk_Jornada) references jornada(ID_Jornada),
foreign key (Fk_Fotografia) references foto(ID_Fotografia)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA TIPO USUARIO
create table tipousuario(
ID_Tipo_Usuario varchar(15) primary key,
Nombre varchar(15) not null,
Fk_Empresa varchar(15) not null,
Estado varchar(1),

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA PREGUNTA
create table pregunta(
ID_Pregunta varchar(15) primary key,
Pregunta varchar(75) not null,
Estado varchar(1)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA USUARIO
create table usuario(
ID_Usuario varchar(15) primary key,
Fk_Tipo_Usuario varchar(15) not null,
Fk_Empleado varchar(15) not null,
Usuario varchar(15) not null,
Contrasena varchar(100) not null,
Fk_Pregunta varchar(15) not null,
Repuesta varchar(100) not null,
Fk_Empresa varchar(15) not null,
Estado varchar(1),

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa),
foreign key (Fk_Tipo_Usuario) references tipousuario(ID_Tipo_Usuario),
foreign key (Fk_Pregunta) references pregunta(ID_Pregunta),
foreign key (Fk_Empleado) references empleado(ID_Empleado)
)engine=InnoDB DEFAULT CHARSET=latin1;

-- TABLAS DE HORARIOS
-- TABLA GESTION
create table gestion(
ID_Gestion varchar(15) primary key,
Nombre varchar(30) not null,
Estado varchar(1) not null
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA TIPO AUSENCIA
create table tipoAusencia(
ID_Tipo_Ausencia varchar(15) primary key,
Nombre varchar(30) not null,
Fk_Empresa varchar(15) not null,
Estado varchar(1) not null,

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA AUSENCIA
create table ausencia(
ID_Ausencia varchar(15) primary key,
Fk_Empleado varchar(15) not null,
Fk_Tipo_Ausencia varchar(15) not null,
Fecha_Ausencia date not null,
Detalles varchar(400) null,
Fk_Empresa varchar(15) not null,
Estado varchar(1) not null,

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa),
foreign key (Fk_Empleado) references empleado(ID_Empleado),
foreign key (Fk_Tipo_Ausencia) references tipoausencia(ID_Tipo_Ausencia)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA TIPO PAGO
create table tipoPago(
ID_Tipo_Pago varchar(15) primary key,
Nombre varchar(30) not null,
Fk_Empresa varchar(15) not null,
Estado varchar(1) not null,

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA PAGOEMPLEADO
create table pagoEmpleado(
ID_Pago_Empleado varchar(15) primary key,
Fk_Empleado varchar(15) not null,
Fk_Tipo_Pago varchar(15) not null,
Fecha_Gasto date not null,
Monto double not null,
Detalles varchar(400) null,
Fk_Empresa varchar(15) not null,
Estado varchar(1) not null,

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa),
foreign key (Fk_Empleado) references empleado(ID_Empleado),
foreign key (Fk_Tipo_Pago) references tipopago(ID_Tipo_Pago)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA DISPOSITIVO
create table dispositivo(
ID_Dispositivo varchar(15) primary key,
Nombre varchar(30) not null,
Fk_Empresa varchar(15) not null,
Estado varchar(1) not null,

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA DATOSE
create table datosE(
ID_Encabezado varchar(15) primary key,
Fk_Empleado varchar(15) not null,
Fk_Dispositivo varchar(1) not null,
Fk_Empresa varchar(15) not null,
Estado varchar(1) not null,

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa),
foreign key (Fk_Empleado) references empleado(ID_Empleado),
foreign key (Fk_Dispositivo) references dispositivo(ID_Dispositivo)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA DATOSD
create table datosD(
ID_Detalle varchar(15) primary key,
Fk_Encabezado varchar(15) not null,
Tiempo_Trabajado varchar(45) not null,
Fk_Gestion varchar(1) not null,
Fk_Tipo_Registro varchar(1) not null,
Estado varchar(1) not null,
foreign key (Fk_Encabezado) references datosE(ID_Encabezado),
foreign key (Fk_Gestion) references gestion(ID_Gestion)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA DIARIOSE
create table diariosE(
ID_Encabezado varchar(15) primary key,
Fecha_Trabajada varchar(45) not null,
Fk_Empresa varchar(15) not null,
Estado varchar(1) not null,

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA DIARIOSD
create table diariosD(
ID_Detalle varchar(15) primary key,
Fk_Encabezado varchar(15) not null,
Fk_Empleado varchar(15) not null,
Hora_Entrada varchar(15) null,
Hora_Salida varchar(15) null,
Horas_Trabajadas varchar(15) null,
Horas_Descontadas varchar(15) null,
Total_Ausencias int null,
Horas_Extras varchar(15) null,
Pago_Comidas double null,
Pago_Combustible double null,
Pago_Viaticos double null,
Otros_Pagos double null,
Observaciones varchar(800) null,
Estado varchar(1) not null,

foreign key (Fk_Encabezado) references diariosE(ID_Encabezado),
foreign key (Fk_Empleado) references empleado(ID_Empleado)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA MENSUALESE
create table mensualesE(
ID_Encabezado varchar(15) primary key,
Fecha_Inicio varchar(45) not null,
Fecha_Finalizacion varchar(45) not null,
Mes_Trabajado varchar(2) not null,
Fk_Empresa varchar(15) not null,
Estado varchar(1) not null,

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA MENSUALESD
create table mensualesD(
ID_Detalle varchar(15) primary key,
Fk_Encabezado varchar(15) not null,
Fk_Empleado varchar(15) not null,
Horas_Trabajadas varchar(15) null,
Horas_Descontadas varchar(15) null,
Total_Ausencias int null,
Horas_Extras time null,
Pago_Comidas double null,
Pago_Combustible double null,
Pago_Viaticos double null,
Otros_Pagos double null,
Observaciones varchar(800) null,
Estado varchar(1) not null,

foreign key (Fk_Encabezado) references mensualesE(ID_Encabezado),
foreign key (Fk_Empleado) references empleado(ID_Empleado)
)engine=InnoDB DEFAULT CHARSET=latin1;

-- TABLAS DE INVENTARIO
-- TABLA CLASIFICACION
create table clasificacion(
ID_Clasificacion varchar(15) primary key,
Nombre varchar(35) not null,
Fk_Empresa varchar(15) not null,
Estado varchar(1),

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA BODEGA
create table bodega(
ID_Bodega varchar(15) primary key,
Nombre varchar(35) not null,
Fk_Empresa varchar(15) not null,
Estado varchar(1),

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA UBICACION
create table ubicacion(
ID_Ubicacion varchar(15) primary key,
Nombre varchar(15) not null,
Fk_Bodega varchar(15) not null,
Estado varchar(1),

foreign key (Fk_Bodega) references bodega(ID_Bodega)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA MARCA
create table marca(
ID_Marca varchar(15) primary key,
Nombre varchar(35) not null,
Fk_Empresa varchar(15) not null,
Estado varchar(1),

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA PROVEEDOR
create table proveedor(
ID_Proveedor varchar(15) primary key,
Nombre varchar(35) not null,
NIT varchar(15) null,
Telefono varchar(20) null,
Detalles varchar(200) null,
Fk_Empresa varchar(15) not null,
Estado varchar(1),

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA CATEGORIA
create table categoria(
ID_Categoria varchar(15) primary key,
Fk_Tipo_Categoria varchar(1) not null,
Fk_Categoria_Superior varchar(15) null,
Nombre varchar(35) not null,
Fk_Empresa varchar(15) not null,
Estado varchar(1),

foreign key (Fk_Categoria_Superior) references categoria(ID_Categoria),
FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA TIPO TRANSACCION
create table tipotransac(
ID_Tipo_Transaccion varchar(15) primary key,
Nombre varchar(35) not null,
Accion varchar(1) not null,
Fk_Empresa varchar(15) not null,
Estado varchar(1),

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA TIPO ALMACENAMIENTO
create table tipoalmacen(
ID_Tipo_Almacenamiento varchar(15) primary key,
Nombre varchar(35) not null,
Fk_Empresa varchar(15) not null,
Estado varchar(1),

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA SUCURSAL
create table sucursal(
ID_Sucursal varchar(15) primary key,
Nombre varchar(35) not null,
Direccion varchar(50) not null,
Fk_Empresa varchar(15) not null,
Estado varchar(1),

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa)
)engine=InnoDB DEFAULT CHARSET=latin1;

-- TABLAS DE PROYECTOS
-- TABLA ENCABEZADO LISTA PROVEEDORES
create table proveedorE(
ID_Encabezado varchar(15) primary key,
Fk_Empresa varchar(15) not null,
Estado varchar(1),

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA DETALLE LISTA PROVEEDORES
create table proveedorD(
ID_Detalle varchar(15) primary key,
Fk_Encabezado varchar(15) not null,
Fk_Proveedor varchar(15) not null,
Estado varchar(1),
foreign key (Fk_Encabezado) references proveedorE(ID_Encabezado),
foreign key (Fk_Proveedor) references proveedor(ID_Proveedor)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA INVENTARIOE
CREATE TABLE inventarioE (
    ID_Encabezado VARCHAR(15) PRIMARY KEY,
    Fk_Clasificacion VARCHAR(15) NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Fk_Empresa varchar(15) not null,
    Estado VARCHAR(1) NOT NULL,
    
    FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa),
    FOREIGN KEY (Fk_Clasificacion)
        REFERENCES clasificacion (ID_Clasificacion)
)  ENGINE=INNODB DEFAULT CHARSET=LATIN1;
-- TABLA INVENTARIOD
create table inventarioD(
ID_Detalle varchar(15) primary key,
Fk_Encabezado varchar(15) not null,
Serie varchar(15) null,
Nombre varchar(50) not null,
Descripcion varchar(200) null,
Cantidad int not null,
Precio_Compra float null,
Precio_Venta float null,
Fk_Marca varchar(15) not null,
Fk_Tipo_Almacenamiento varchar(15) not null,
Fk_Categoria_1 varchar(15) null,
Fk_Categoria_2 varchar(15) null,
Fk_Categoria_3 varchar(15) null,
Fk_Sucursal varchar(15) not null,
Fk_Bodega varchar(15) not null,
Fk_Ubicacion varchar(15) not null,
Fk_Proveedores varchar(15) null,
Inventario_Minimo int not null,
Inventario_Maximo int null,
Estado varchar(1) not null,

foreign key (Fk_Encabezado) references inventarioE(ID_Encabezado),
foreign key (Fk_Marca) references marca(ID_Marca),
foreign key (Fk_Categoria_1) references categoria(ID_Categoria),
foreign key (Fk_Categoria_2) references categoria(ID_Categoria),
foreign key (Fk_Categoria_3) references categoria(ID_Categoria),
foreign key (Fk_Sucursal) references sucursal(ID_Sucursal),
foreign key (Fk_Bodega) references bodega(ID_Bodega),
foreign key (Fk_Ubicacion) references ubicacion(ID_Ubicacion),
foreign key (Fk_Proveedores) references proveedorE(ID_Encabezado),
foreign key (Fk_Tipo_Almacenamiento) references tipoalmacen(ID_Tipo_Almacenamiento)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA TRANSACCIONES
create table transacciones(
ID_Transacciones varchar(15) primary key,
Fk_Encabezado varchar(15) not null,
Fk_Detalle varchar(15) not null,
Fk_Tipo_Transaccion varchar(15) not null,
Fecha_Transaccion date not null,
Cantidad int not null,
Precio float not null,
Fk_Empresa varchar(15) not null,
Estado varchar(1) not null,

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa),
foreign key (Fk_Encabezado) references inventarioE(ID_Encabezado),
foreign key (Fk_Detalle) references inventarioD(ID_Detalle),
foreign key (Fk_Tipo_Transaccion) references tipotransac(ID_Tipo_Transaccion)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA COTIZACIONE
create table cotizacionE(
ID_Encabezado varchar(15) primary key,
Proyecto varchar(80) not null,
Fecha_Emision date not null,
Total float null,
Fk_Empresa varchar(15) not null,
Estado varchar(1) not null,

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA COTIZACIOND
create table cotizacionD(
ID_Detalle varchar(15) primary key,
Fk_Encabezado varchar(15) not null,
Fk_Inventario varchar(15) not null,
Fk_Producto varchar(15) not null,
Cantidad int not null,
Precio float not null,
Descuento float null,
Subtotal float not null,
Estado varchar(1) not null,

foreign key (Fk_Inventario) references inventarioE(ID_Encabezado),
foreign key (Fk_Producto) references inventarioD(ID_Detalle),
foreign key (Fk_Encabezado) references cotizacionE(ID_Encabezado)
)engine=InnoDB DEFAULT CHARSET=latin1;

-- TABLAS PROYECTOS
-- TABLA EMPRESA CLIENTE
create table EmpresaCliente(
ID_Empresa varchar(15) primary key,
Nombre varchar(60) not null,
Telefono varchar(30) not null,
NIT varchar(30) not null,
Jefe varchar(60) default null,
Fk_Empresa varchar(15) not null,
Estado varchar(1) not null,

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA SUCURSAL CLIENTE
create table SucursalCliente(
ID_Sucursal varchar(15) primary key,
Fk_Empresa_Cliente varchar(15) not null,
Nombre varchar(50) not null,
Telefono varchar(60) not null,
Direccion varchar(30) not null,
Contacto_Directo varchar(60) not null,
Fk_Empresa varchar(15) not null,
Estado varchar(1) not null,

foreign key (Fk_Empresa_Cliente) references EmpresaCliente (ID_Empresa),
FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA EQUIPO ENCABEZADO
create table EquipoEncabezado(
ID_Encabezado varchar(15) primary key,
Nombre varchar(50) not null,
Fk_Empresa varchar(15) not null,
Estado varchar (1) not null,

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA EQUIPO DETALLE
create table EquipoDetalle(
ID_Detalle varchar(15) primary key,
Fk_Encabezado varchar(15) not null,
Fk_Empleado varchar(15) not null,

foreign key (Fk_Encabezado) references EquipoEncabezado (ID_Encabezado),
foreign key (Fk_Empleado) references Empleado (ID_Empleado)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA MARCA VEHICULO
create table MarcaVehiculo(
ID_Marca_Vehiculo varchar(15) primary key,
Nombre varchar(30) not null,
Fk_Empresa varchar(15) not null,
Estado varchar(1) not null,

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA LINEA
create table Linea(
ID_Linea varchar(15) primary key,
Nombre varchar(30) not null,
Fk_Empresa varchar(15) not null,
Estado varchar(1) not null,

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA TAMAÑO MOTOR
create table TamanoMotor(
ID_Tamano_Motor varchar(15) primary key,
Nombre varchar(30) not null,
Fk_Empresa varchar(15) not null,
Estado varchar(1) not null,

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA TIPO COMBUSTIBLE
create table TipoCombustible(
ID_Tipo_Combustible varchar(15) primary key,
Nombre varchar(30) not null,
Estado varchar(1) not null
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA VEHICULO
create table Vehiculo(
ID_Vehiculo varchar(15) primary key,
Placa varchar(30) not null,
Fk_Marca varchar(15) not null,
Fk_Linea varchar(15) not null,
Modelo varchar(30) not null,
Fk_Tamano_Motor varchar(15) not null,
Fk_Tipo_Combustible varchar(15) not null,
Fk_Empresa varchar(15) not null,
Estado varchar(1) not null,

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa),
foreign key (Fk_Marca) references MarcaVehiculo (ID_Marca_Vehiculo),
foreign key (Fk_Linea) references Linea (ID_Linea),
foreign key (Fk_Tamano_Motor) references TamanoMotor (ID_Tamano_Motor),
foreign key (Fk_Tipo_Combustible) references TipoCombustible (ID_Tipo_Combustible)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA COTIZACION ENCABEZADO
create table CotizacionProyectoE(
ID_Encabezado varchar(15) primary key,
Proyecto varchar(80) not null,
Fecha_Emision date not null,
Total float not null,
Fk_Empresa varchar(15) not null,
Estado varchar(1) not null,

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA COTIZACION DETALLE
create table CotizacionProyectoD(
ID_Detalle varchar(15) primary key,
Fk_Encabezado varchar(15) not null,
Fk_Inventario varchar(15) not null,
Fk_Producto varchar(15) not null,
Cantidad int not null,
Precio float not null,
Mano_Obra float not null,
Combustible float not null,
Hospedaje float not null,
Peaje float not null,
Otros float not null,
Descuento float null,
Subtotal float not null,
Estado varchar(1) not null,

foreign key (Fk_Encabezado) references CotizacionProyectoE (ID_Encabezado),
foreign key (Fk_Inventario) references InventarioE (ID_Encabezado),
foreign key (Fk_Producto) references InventarioD (ID_Detalle)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA ASIGNA PROYECTO
create table AsignaProyecto(
ID_Asignacion varchar(15) primary key,
Nombre varchar(45) not null,
Fk_Cliente varchar(15) not null,
Fk_Equipo varchar(15) not null,
Fk_Vehiculo varchar(15) not null,
Fk_Cotizacion varchar(15) not null,
Fk_Empresa varchar(15) not null,
Estado varchar(1) not null,

FOREIGN KEY (Fk_Empresa) REFERENCES empresa(ID_Empresa),
foreign key (Fk_Cliente) references SucursalCliente (ID_Sucursal),
foreign key (Fk_Equipo) references EquipoEncabezado (ID_Encabezado),
foreign key (Fk_Vehiculo) references Vehiculo (ID_Vehiculo),
foreign key (Fk_Cotizacion) references CotizacionProyectoE (ID_Encabezado)
)engine=InnoDB DEFAULT CHARSET=latin1;

-- INSERTS NECESARIOS
insert into empresa values ("1","IEC","1");
insert into empresa values ("2","RTEC","1");

insert into puesto values ("1","Gerente","1","1");
insert into puesto values ("2","Gerente","2","1");

insert into jornada values ("1","Administracion", "08:00:00","16:30:00","1","1");
insert into jornada values ("2","Administracion", "08:00:00","16:30:00","2","1");


insert into empleado values ("1","1", "David Enrique Guerra Lucio","2145896250101","1",null,null,null,"1","1");
insert into empleado values ("2","2", "Carlos Daniel  Torres Estrada","1432456789045","2",null,null,null,"2","1");

insert into tipousuario values ("1", "Administrador","1","1");
insert into tipousuario values ("2", "Supervisor","1","1");
insert into tipousuario values ("3", "Visitante","1","1");
insert into tipousuario values ("4", "Administrador","2","1");
insert into tipousuario values ("5", "Supervisor","2","1");
insert into tipousuario values ("6", "Visitante","2","1");

insert into pregunta values ("1", "¿Año de nacimiento?", "1");

insert into usuario values ("1", "1", "1", "adminIEC","LKAekHU9EtweB49HAaTRfg==","1","1","1","1");
insert into usuario values ("2", "4", "2", "adminRTEC","LKAekHU9EtweB49HAaTRfg==","1","1","2","1");

insert into categoria values ("1","1","1","Ninguna","2","1");
insert into categoria values ("2","2","1","Ninguna","2","1");
insert into categoria values ("3","3","2","Ninguna","2","1");