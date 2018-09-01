
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
	 material_paredes varchar,
	 material_techo varchar,
	 cielo_raso bit,
	 material_piso varchar,
	 pilotes bit,

	 estado_paredes tinyint,
	 estado_techo tinyint,
	 estado_piso tinyint,

	 cuartos_dormir tinyint,

	 aposentos tinyint,

	 metros_cuadrados tinyint,
	 abastese_agua tinyint,--V11
	 agua_consumo varchar,

	 ----------------------

	 servicio_sanitario varchar,
	 sanitario_es bit, --v13b

	 cantidad_banos tinyint,
	uso_banos bit,
	provedor_luz varchar,--v15

	energia_cosina varchar, 

	eliminacion_basura varchar, --v17
	
	--- separacion de basura
	---??????????????
	 









	precio_mensual
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



create table t_hogar(
	 id_hogar int primary key ,
	 id_vivienda int foreign key references t_vivienda(id_vivienda)
);


 go

 create table t_persona(
	id_hogar int foreign key,
	cedula varchar (10),13
	 asalariado  bit
 );

 create table t_tipo_discapasidad(
	id_discapasidad int primary key,
	tipo  varchar(20)
 );

 create t_discapasidad