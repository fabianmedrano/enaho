
 create database ENAHO
 go

 use ENAHO
create table t_entrevistador(
	id_entrevistador int IDENTITY(1,1),
	usuario varchar (10),
	pass varchar (8)
);

go

CREATE PROCEDURE p_loing
    @user nvarchar(10),   
    @pass nvarchar(8)   
AS   
begin
SELECT* FROM  t_entrevistador WHERE usuario = @user and pass =@pass
 end
 
 go

 create table t_tipo_vivieda(
	id_tipo_vivienda int IDENTITY(1,1) PRIMARY KEY,

	tipo varchar (100)
);
 create table t_esta_vivieda(
	id int IDENTITY(1,1) PRIMARY KEY,

	tipo varchar (50)
);
 create table t_material_techo(
	id int IDENTITY(1,1) PRIMARY KEY,
	material varchar (100)
);



 create table t_material_piso(
	id int IDENTITY(1,1) PRIMARY KEY,
	material varchar (100)
);
 create table t_material_paredes(
	id int IDENTITY(1,1) PRIMARY KEY,
	material varchar (100)
);

 create table t_metros(
	id int IDENTITY(1,1) PRIMARY KEY,
	metros varchar (50)
);
drop table agua_abastecimiento

create table t_agua_abastecimiento(
 id  int IDENTITY(1,1)primary key,
 agua_abastecimiento  varchar(100)
 );
create table agua_consumo_provediente(
 id_agua_consumo_provediente  int IDENTITY(1,1) primary key,
 agua_consumo_provediente   varchar(100),
 );
create table t_sanitario(
	id_sanitario int IDENTITY(1,1) PRIMARY KEY,	
	servicio_sanitario_sistema varchar(100)
);

create table t_provedor_luz (
	id_provedor_luz int IDENTITY(1,1) PRIMARY KEY,
	provedor_luz varchar(50)
);

create table t_provedor_internet (
	id_provedor_internet int IDENTITY(1,1) PRIMARY KEY,
	provedor_internet varchar (100)
);

create table t_basura (
	id_basura int IDENTITY(1,1) PRIMARY KEY,
	basura varchar (100)
);
go
create table t_articulo(
	id_articulo int IDENTITY(1,1) PRIMARY KEY,
	articulo varchar(100)
);

create table t_energia_cosina(
	id_energia_cosina int IDENTITY(1,1) PRIMARY KEY,
	energia_cosina varchar(35)
);

 create table t_vivienda (
	id  int IDENTITY(1,1) PRIMARY KEY,
	direccion varchar(150),
	telefono varchar(8),
	modulo bit,

	numeropersonas int,
	numerohogares int,
---tabla 
tipovivienda int foreign key references t_tipo_vivieda(id_tipo_vivienda) ,

mensualidad int,
pagariamensualidad int,
esta int  foreign key references t_esta_vivieda(id),
---tabla
materialperedes int  foreign key references t_material_paredes(id),

---tabla
materialtecho  int  foreign key references t_material_techo(id),

cieloraso bit,

materialpiso  int  foreign key references t_material_piso(id),


sobrepilotes bit,
estadoparedes tinyint,

estadotecho tinyint,
estadopiso tinyint,
cuartosdormir tinyint,
cantidadaposentos tinyint,

metroscuadrados int foreign key references t_metros(id),
abastecimientoagua  int foreign key references t_agua_abastecimiento(id),
-- tabla
origenaguaconsumo  int foreign key references agua_consumo_provediente(id_agua_consumo_provediente),


serviciosanitario int foreign key references t_sanitario(id_sanitario),

serviciosanitaioes bit,
viviendabano  bit,

cantidadbanos tinyint,
usobano bit,
--tabla
@fuenteelectricidad int,
@otrofuenteelectricidad varchar,

@enegiacosina int,
@otroenergiacosina varchar,
              
@eliminacionbasura int,
@otroeliminacionbasura varchar,
@separacionorganica bit,
@separacionplastico bit,
@separacionvidrio bit,
@separacionaluminio bit,
@separacionpapel bit,

@cantidadtelefonocelular int,
@cantidadtelefonorecidencial int,
@cantidadportatil int ,


@cantidadpcescritorio int,
@table int,
@cantidadfax int,
@cantidadradio int,

@cantidadcarro int,
@cantidadmoto int,
@cantidadtvplasma int,
@cantidadtvconvencional int,

@regrigeradora int,
@aguacaliente int,
@aguatanque int,
@cable int,

@viviendasatelital int,
@otrotvpaga varchar,
@internet bit,
@tipoconeccion int,

@otrotipoconeccion varchar,

@router bit
 );
 create table t_separa_basura (
	id_basra int foreign key references t_basura(id_basura),
	id_vivienda int foreign key references t_vivienda(id_vivienda)
);
 create table t_tiene (
	id_articulo int foreign key references t_articulo(id_articulo),
	id_vivienda int foreign key references t_vivienda(id_vivienda)
);
 create table t_relacion_vivienda(
	id_relacion_vivienda int primary key ,
	relacion varchar(20)
 );








 go
 create table t_solicitud_bono(
	id_solicitud_bono int primary key,
	solicitud varchar
 );
  create table t_tipo_bono(
	id_tipo_bono  int primary key,
	tipo varchar,
  );
  create table t_bono(
	id_bono int primary key,
	id_tipo int foreign key references t_tipo_bono(id_tipo_bono) ,
	datetime año
 );

create table t_hogar(
	 id_hogar int primary key ,
	 id_vivienda int foreign key references t_vivienda(id_vivienda)

	 id_solicitud_bono int foreign key references t_vivienda(id_vivienda)
);


 go

 create table t_persona(
	id_hogar int foreign key,
	---cedula varchar (10),
	asalariado  bit,
	informante bit,
	nombre varchar,
	parentesco int, 
	edad int,
	-------------
	mas_6_meses bit,
	continuara_viviendo bit,
	otro_luguar_vivir bit,

	sexo bit ,
	id_canton int  foreign key references t_canton(id_canton),
	id_pais int foreign key references t_pais(id_pais),
	estado_conyugal tinyint
 );

 create table t_persona_discapasidad(
	id_persona int foreign key references t_persona(id_persona),
	id_dicapacidad int  foreign key references  t_discapacidad(id_discapacidad)
 );

 create t_discapasidad(
	id_discapacidad int primary key,
	discapacidad varchar
 );
