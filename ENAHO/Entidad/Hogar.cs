using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Hogar
    {

        private Boolean personas_mas_seis_meses;
        private Boolean personas_otro_lugar_donde_vivir;
        private string cantidad_personas_otro_lugar;

        private Boolean personas_otra_partes;
        private Boolean personas_asentes_menos_seis_meses;
        private string numero_personas_asentes_menos_seis_meses;

        
        private Boolean servicio_domestico_en_casa;
        private Boolean alquila_cuarto;
        private string numero_personas_alquila_cuarto;

        public Hogar()
        {
        }

        public Hogar(bool personas_mas_seis_meses, bool personas_otro_lugar_donde_vivir, string cantidad_personas_otro_lugar, bool personas_otra_partes, bool personas_asentes_menos_seis_meses, string numero_personas_asentes_menos_seis_meses, bool servicio_domestico_en_casa, bool alquila_cuarto, string numero_personas_alquila_cuarto)
        {
            this.personas_mas_seis_meses = personas_mas_seis_meses;
            this.personas_otro_lugar_donde_vivir = personas_otro_lugar_donde_vivir;
            this.cantidad_personas_otro_lugar = cantidad_personas_otro_lugar;
            this.personas_otra_partes = personas_otra_partes;
            this.personas_asentes_menos_seis_meses = personas_asentes_menos_seis_meses;
            this.numero_personas_asentes_menos_seis_meses = numero_personas_asentes_menos_seis_meses;
            this.servicio_domestico_en_casa = servicio_domestico_en_casa;
            this.alquila_cuarto = alquila_cuarto;
            this.numero_personas_alquila_cuarto = numero_personas_alquila_cuarto;
        }

        public bool Personas_mas_seis_meses { get => personas_mas_seis_meses; set => personas_mas_seis_meses = value; }
        public bool Personas_otro_lugar_donde_vivir { get => personas_otro_lugar_donde_vivir; set => personas_otro_lugar_donde_vivir = value; }
        public string Cantidad_personas_otro_lugar { get => cantidad_personas_otro_lugar; set => cantidad_personas_otro_lugar = value; }
        public bool Personas_otra_partes { get => personas_otra_partes; set => personas_otra_partes = value; }
        public bool Personas_asentes_menos_seis_meses { get => personas_asentes_menos_seis_meses; set => personas_asentes_menos_seis_meses = value; }
        public string Numero_personas_asentes_menos_seis_meses { get => numero_personas_asentes_menos_seis_meses; set => numero_personas_asentes_menos_seis_meses = value; }
        public bool Servicio_domestico_en_casa { get => servicio_domestico_en_casa; set => servicio_domestico_en_casa = value; }
        public bool Alquila_cuarto { get => alquila_cuarto; set => alquila_cuarto = value; }
        public string Numero_personas_alquila_cuarto { get => numero_personas_alquila_cuarto; set => numero_personas_alquila_cuarto = value; }
    }
}
