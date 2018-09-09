
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
	id_tipo_vivienda int primary key,

	tipo varchar 
);
create table agua_consumo_provediente(
 id_agua_consumo_provediente  int primary key,
 agua_consumo_provediente   varchar,
 );
create table t_sanitario(
	id_sanitario int,	
	servicio_sanitario_sistema varchar,
	sanitario_uso bit, --v13b
);

create table t_provedor_luz (
	id_provedor_luz int primary key,
	provedor_luz varchar
);

create table t_provedor_internet (
	id_provedor_internet int primary key,
	provedor_internet varchar
);

create table t_basura (
	id_basra int primary key,
	basura varchar
);

create t_articulo(
	id_articulo int primary key,
	articulo varchar
);

create t_energia_cosina(
	id_energia_cosina int primary key,
	energia_cosina varchar
);

 create table t_vivienda (
	id_vivienda int primary key ,

	-----
	idDistrito int,
	amgc bit,--aplia modulo de gasto de consumo de hogares
	personas_envivienda int ,
	direccion varchar,
	telefono varchar(8),
	tipo_vivienda  int foreign key references t_tipo_vivieda(id_tipo_vivienda) ,

	-------------------------
	relacion_vivienda tinyint,
	mensualidad int,


	----------------------
	 material_paredes varchar,
	 material_techo varchar,
	 cielo_raso bit,
	 material_piso varchar,
	 pilotes bit,
	 -------------------
	 estado_paredes tinyint,
	 estado_techo tinyint,
	 estado_piso tinyint,
	 ----------------------------
	 cuartos_dormir tinyint,

	 aposentos tinyint,

	 metros_cuadrados tinyint,
	 abastese_agua tinyint,--V11
	 id_agua_consumo_provediente  int  foreign key references agua_consumo_provediente(id_agua_consumo_provediente),

	 ----------------------
	 id_sanitario int,
	 ------------------------

	cantidad_banos tinyint,
	uso_banos bit,

	id_provedor_luz int    foreign key references t_provedor_luz(id_provedor_luz),--v15

	id_provedor_internet int    foreign key references t_provedor_internet(id_provedor_internet),

	energia_cosina int foreign key references t_energia_cosica(id_energia_cosina), 


	router bit
 );
 create table t_separa_basura (
	id_basra int foreign key references t_basura(id_basra),
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

 create table t_tipo_vivienda(
	id_tipo_vivienda int primary key,
	tipo_vivienda  varchar (20)
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
