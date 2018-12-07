using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Persona
    {

        private string nombre;
        private bool mas_6_meses;
        private bool continuara_viviendo;
        private int parentesco_jefe_hogar;
        private bool sexo;
        private int edad;
        private int idDistrito;
        private int estado_conyugal;
        private int tipo_seguro;

        public Persona(string nombre, bool mas_6_meses, bool continuara_viviendo, int parentesco_jefe_hogar, bool sexo, int edad, int idDistrito, int estado_conyugal, int tipo_seguro)
        {
            this.Nombre = nombre;
            this.Mas_6_meses = mas_6_meses;
            this.Continuara_viviendo = continuara_viviendo;
            this.Parentesco_jefe_hogar = parentesco_jefe_hogar;
            this.Sexo = sexo;
            this.Edad = edad;
            this.IdDistrito = idDistrito;
            this.Estado_conyugal = estado_conyugal;
            this.Tipo_seguro = tipo_seguro;
        }
        public Persona()
        {
            this.Nombre = "";
            this.Mas_6_meses = false;
            this.Continuara_viviendo = false;
            this.Parentesco_jefe_hogar = 1;
            this.Sexo = false;
            this.Edad = 14;
            this.IdDistrito = 1;
            this.Estado_conyugal = 1;
            this.Tipo_seguro = 1;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public bool Mas_6_meses { get => mas_6_meses; set => mas_6_meses = value; }
        public bool Continuara_viviendo { get => continuara_viviendo; set => continuara_viviendo = value; }
        public int Parentesco_jefe_hogar { get => parentesco_jefe_hogar; set => parentesco_jefe_hogar = value; }
        public bool Sexo { get => sexo; set => sexo = value; }
        public int Edad { get => edad; set => edad = value; }
        public int IdDistrito { get => idDistrito; set => idDistrito = value; }
        public int Estado_conyugal { get => estado_conyugal; set => estado_conyugal = value; }
        public int Tipo_seguro { get => tipo_seguro; set => tipo_seguro = value; }
        //limitacion
    }
}
