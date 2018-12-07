using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class hogarmuestra
    {
        private int id;
        private Boolean personas_mas_seis_meses;
        private int cantidad_personas_otro_lugar;
        private int numero_personas_asentes_menos_seis_meses;

        public hogarmuestra() {
         id =0;
       personas_mas_seis_meses = false;
        cantidad_personas_otro_lugar= 0;
        numero_personas_asentes_menos_seis_meses=0;

    }


        public int Id { get => id; set => id = value; }
        public bool Personas_mas_seis_meses { get => personas_mas_seis_meses; set => personas_mas_seis_meses = value; }
        public int Cantidad_personas_otro_lugar { get => cantidad_personas_otro_lugar; set => cantidad_personas_otro_lugar = value; }
        public int Numero_personas_asentes_menos_seis_meses { get => numero_personas_asentes_menos_seis_meses; set => numero_personas_asentes_menos_seis_meses = value; }
    }
}
