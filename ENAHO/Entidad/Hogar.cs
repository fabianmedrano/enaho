using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Hogar
    {
        private int id;
        private Boolean personas_mas_seis_meses;
        private Boolean personas_otro_lugar_donde_vivir;
        private int cantidad_personas_otro_lugar;

        private Boolean personas_otra_partes;
        private Boolean personas_asentes_menos_seis_meses;
        private int numero_personas_asentes_menos_seis_meses;


        private Boolean servicio_domestico_en_casa;
        private Boolean alquila_cuarto;
        private int numero_personas_alquila_cuarto;

        //boono de vivienda

        private Boolean recibio_bono;
        private int ano_recibir;
        private int tipo_bono;

        private Boolean solocitud_bono;
        private int razon_no_recibir;
        private String otro_razon_no_recibir;

        private int razon_no_solicitar;
        private String otro_razon_no_solicitar;




        public Hogar()
        {
            this.id = 0;
            this.personas_mas_seis_meses = false;
            this.personas_otro_lugar_donde_vivir = false;
            this.cantidad_personas_otro_lugar = 0;
            this.personas_otra_partes = false;
            this.personas_asentes_menos_seis_meses = false;
            this.numero_personas_asentes_menos_seis_meses = 0;
            this.servicio_domestico_en_casa = false;
            this.alquila_cuarto = false;
            this.numero_personas_alquila_cuarto = 0;
            this.recibio_bono = false;
            this.ano_recibir = 1111;
            this.tipo_bono = 0;
            this.solocitud_bono = false;
            this.razon_no_recibir = 0;
            this.otro_razon_no_recibir = "nada";
            this.razon_no_solicitar = 0;
            this.otro_razon_no_solicitar = "nada";
        }
        public int Id { get => id; set => id = value; }
        public bool Personas_mas_seis_meses { get => personas_mas_seis_meses; set => personas_mas_seis_meses = value; }
        public bool Personas_otro_lugar_donde_vivir { get => personas_otro_lugar_donde_vivir; set => personas_otro_lugar_donde_vivir = value; }
        public int Cantidad_personas_otro_lugar { get => cantidad_personas_otro_lugar; set => cantidad_personas_otro_lugar = value; }
        public bool Personas_otra_partes { get => personas_otra_partes; set => personas_otra_partes = value; }
        public bool Personas_asentes_menos_seis_meses { get => personas_asentes_menos_seis_meses; set => personas_asentes_menos_seis_meses = value; }
        public int Numero_personas_asentes_menos_seis_meses { get => numero_personas_asentes_menos_seis_meses; set => numero_personas_asentes_menos_seis_meses = value; }
        public bool Servicio_domestico_en_casa { get => servicio_domestico_en_casa; set => servicio_domestico_en_casa = value; }
        public bool Alquila_cuarto { get => alquila_cuarto; set => alquila_cuarto = value; }
        public int Numero_personas_alquila_cuarto { get => numero_personas_alquila_cuarto; set => numero_personas_alquila_cuarto = value; }
        public bool Recibio_bono { get => recibio_bono; set => recibio_bono = value; }
        public int Ano_recibir { get => ano_recibir; set => ano_recibir = value; }
        public int Tipo_bono { get => tipo_bono; set => tipo_bono = value; }
        public bool Solocitud_bono { get => solocitud_bono; set => solocitud_bono = value; }
        public int Razon_no_recibir { get => razon_no_recibir; set => razon_no_recibir = value; }
        public string Otro_razon_no_recibir { get => otro_razon_no_recibir; set => otro_razon_no_recibir = value; }
        public int Razon_no_solicitar { get => razon_no_solicitar; set => razon_no_solicitar = value; }
        public string Otro_razon_no_solicitar { get => otro_razon_no_solicitar; set => otro_razon_no_solicitar = value; }
    }
}