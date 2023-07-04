using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Vivienda
    {
        private int id_vivienda;
        private Int32 DisIDDistrito;
        private string direccion;
        private string telefono;
        private Boolean Modulo_GCH;
        private Int16 numero_personas_vivienda;
        private Int16 numero_hogares_vivienda;
        private Int16 tipo_vivienda;
        private string otro_tipo_vivienda;
        private float mesulaidad_vivienda;
        private float pagaria_mesulaidad;
        /**/
        private Int16 esta_vivienda;
        private string otro_esta_vivienda;
        /*        Materiales            */
        private Int16 material_paredes;
        private string otro_material_paredes;

        private Int16 material_techos;
        private string otro_material_techo;

        private Boolean cielo_raso;

        private Int16 material_piso;
        private string otro_material_piso;

        private Boolean sobre_pilotes;

        private Int16  estado_paredes;
        private Int16 estado_techo;
        private Int16 estado_piso;

        private Int16 cuartos_exclusivos_dormir;
        private Int16 cantidad_aposentos;


        private Int16 metros_cuadrados;
        /* agua*/
        private Int16 abastecimiento_agua;


        private Int16 origen_agua_consumo;
        private string otro_origen_agua_consumo;


        private Int16 servicio_sanitario;
        private string otro_servicio_sanitario;

        private Int16 servicio_sanitario_es;

        private Boolean bano;
        private Int16 cantidad_banos;


        private Boolean uso_bano;

        private Int16 fuente_electricidad;
        private string otro_fuente_eletricidad;

        private Int16 energia_cosina;
        private string otro_energia_cosina;


        private Int16 eliminacion_basura;
        private string otro_eliminacion_basura;
        /*separacion basura*/
        /*hasta aqui
        private Boolean separacion_organica;
        private Boolean separacion_plastico;
        private Boolean separacion_vidrio;
        private Boolean separacion_alumino;
        private Boolean separacion_papel;


        
        private int cantidad_telefono_celular;
        private int cantidad_telefono_recidencial;
        private int cantidad_portatil;
        private int cantidad_pc_escritorio;
        private int cantidad_tablet;
        private int cantidad_fax;
        private int cantidad_radio;
        private int cantidad_carro;
        private int cantidad_moto;
        private int cantidad_tv_plasma;
        private int cantidad_tv_convencional;

        private Boolean refrigeradora;
        private Boolean agua_caliente;
        private Boolean agua_tanque;
        private Boolean cable;
        private Boolean satelital;
        private string otro_tv_paga;
        private Boolean  internet;


        private Int16 tipo_coneccion;
        private string otro_tipo_coneccion;

        private Boolean router;
        */
    public Vivienda()
        {
        id_vivienda=0;
        DisIDDistrito =0;
        direccion = "nada";
        telefono = "nada";
        Modulo_GCH = false;
        numero_personas_vivienda = 0;
        numero_hogares_vivienda = 0;
        tipo_vivienda = 0;
        otro_tipo_vivienda = "nada";
        mesulaidad_vivienda = 0;
        pagaria_mesulaidad = 0;
        /**/
        esta_vivienda = 0;
        otro_esta_vivienda = "nada";
        /*        Materiales            */
        material_paredes = 0;
        otro_material_paredes = "nada";

        material_techos = 0;
        otro_material_techo = "nada";

        cielo_raso = false;

        material_piso = 0;
        otro_material_piso = "nada";

        sobre_pilotes = false;

        estado_paredes = 0;
        estado_techo = 0;
        estado_piso = 0;

        cuartos_exclusivos_dormir = 0;
        cantidad_aposentos = 0;


        metros_cuadrados = 0;
        /* agua*/
        abastecimiento_agua = 0;


        origen_agua_consumo = 0;
        otro_origen_agua_consumo = "nada";


        servicio_sanitario = 0;
        otro_servicio_sanitario = "nada";

        servicio_sanitario_es = 0;

        bano = false;
        cantidad_banos = 0;


        uso_bano = false;

        fuente_electricidad = 0;
        otro_fuente_eletricidad = "nada";

        energia_cosina = 0;
        otro_energia_cosina = "nada";


        eliminacion_basura = 0;
        otro_eliminacion_basura = "nada";

     }

    public int Id_vivienda { get => id_vivienda; set => id_vivienda = value; }
        public int DisIDDistrito1 { get => DisIDDistrito; set => DisIDDistrito = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public bool Modulo_GCH1 { get => Modulo_GCH; set => Modulo_GCH = value; }
        public short Numero_personas_vivienda { get => numero_personas_vivienda; set => numero_personas_vivienda = value; }
        public short Numero_hogares_vivienda { get => numero_hogares_vivienda; set => numero_hogares_vivienda = value; }
        public short Tipo_vivienda { get => tipo_vivienda; set => tipo_vivienda = value; }
        public string Otro_tipo_vivienda { get => otro_tipo_vivienda; set => otro_tipo_vivienda = value; }
        public float Mesulaidad_vivienda { get => mesulaidad_vivienda; set => mesulaidad_vivienda = value; }
        public float Pagaria_mesulaidad { get => pagaria_mesulaidad; set => pagaria_mesulaidad = value; }
        public short Esta_vivienda { get => esta_vivienda; set => esta_vivienda = value; }
        public string Otro_esta_vivienda { get => otro_esta_vivienda; set => otro_esta_vivienda = value; }
        public short Material_paredes { get => material_paredes; set => material_paredes = value; }
        public string Otro_material_paredes { get => otro_material_paredes; set => otro_material_paredes = value; }
        public short Material_techos { get => material_techos; set => material_techos = value; }
        public string Otro_material_techo { get => otro_material_techo; set => otro_material_techo = value; }
        public bool Cielo_raso { get => cielo_raso; set => cielo_raso = value; }
        public short Material_piso { get => material_piso; set => material_piso = value; }
        public string Otro_material_piso { get => otro_material_piso; set => otro_material_piso = value; }
        public bool Sobre_pilotes { get => sobre_pilotes; set => sobre_pilotes = value; }
        public short Estado_paredes { get => estado_paredes; set => estado_paredes = value; }
        public short Estado_techo { get => estado_techo; set => estado_techo = value; }
        public short Estado_piso { get => estado_piso; set => estado_piso = value; }
        public short Cuartos_exclusivos_dormir { get => cuartos_exclusivos_dormir; set => cuartos_exclusivos_dormir = value; }
        public short Cantidad_aposentos { get => cantidad_aposentos; set => cantidad_aposentos = value; }
        public short Metros_cuadrados { get => metros_cuadrados; set => metros_cuadrados = value; }
        public short Abastecimiento_agua { get => abastecimiento_agua; set => abastecimiento_agua = value; }
        public short Origen_agua_consumo { get => origen_agua_consumo; set => origen_agua_consumo = value; }
        public string Otro_origen_agua_consumo { get => otro_origen_agua_consumo; set => otro_origen_agua_consumo = value; }
        public short Servicio_sanitario { get => servicio_sanitario; set => servicio_sanitario = value; }
        public string Otro_servicio_sanitario { get => otro_servicio_sanitario; set => otro_servicio_sanitario = value; }
        public short Servicio_sanitario_es { get => servicio_sanitario_es; set => servicio_sanitario_es = value; }
        public bool Bano { get => bano; set => bano = value; }
        public short Cantidad_banos { get => cantidad_banos; set => cantidad_banos = value; }
        public bool Uso_bano { get => uso_bano; set => uso_bano = value; }
        public short Fuente_electricidad { get => fuente_electricidad; set => fuente_electricidad = value; }
        public string Otro_fuente_eletricidad { get => otro_fuente_eletricidad; set => otro_fuente_eletricidad = value; }
        public short Energia_cosina { get => energia_cosina; set => energia_cosina = value; }
        public string Otro_energia_cosina { get => otro_energia_cosina; set => otro_energia_cosina = value; }
        public short Eliminacion_basura { get => eliminacion_basura; set => eliminacion_basura = value; }
        public string Otro_eliminacion_basura { get => otro_eliminacion_basura; set => otro_eliminacion_basura = value; }


    }
}
