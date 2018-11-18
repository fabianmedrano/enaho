using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class viviendamuestra
    {

            private int id_vivienda;
            private String DisIDDistrito;
            private string direccion;
            private string telefono;
            private Boolean Modulo_GCH;
            private Int16 numero_personas_vivienda;
            private Int16 numero_hogares_vivienda;
            private string tipo_vivienda;

            public viviendamuestra(int id_vivienda, String disIDDistrito, string direccion, string telefono, bool modulo_GCH, short numero_personas_vivienda, short numero_hogares_vivienda, String tipo_vivienda, string otro_tipo_vivienda)
            {
                this.id_vivienda = id_vivienda;
                DisIDDistrito = disIDDistrito;
                this.direccion = direccion;
                this.telefono = telefono;
                Modulo_GCH = modulo_GCH;
                this.numero_personas_vivienda = numero_personas_vivienda;
                this.numero_hogares_vivienda = numero_hogares_vivienda;
                this.tipo_vivienda = tipo_vivienda;
            }


            public viviendamuestra() { 
                this.id_vivienda = 0;
                DisIDDistrito = "";
                this.direccion = "";
                this.telefono = "";
                Modulo_GCH = false;
                this.numero_personas_vivienda = 0;
                this.numero_hogares_vivienda = 0;
            }

            public int Id_vivienda { get => id_vivienda; set => id_vivienda = value; }
            public String DisIDDistrito1 { get => DisIDDistrito; set => DisIDDistrito = value; }
            public string Direccion { get => direccion; set => direccion = value; }
            public string Telefono { get => telefono; set => telefono = value; }
            public bool Modulo_GCH1 { get => Modulo_GCH; set => Modulo_GCH = value; }
            public short Numero_personas_vivienda { get => numero_personas_vivienda; set => numero_personas_vivienda = value; }
            public short Numero_hogares_vivienda { get => numero_hogares_vivienda; set => numero_hogares_vivienda = value; }
            public String Tipo_vivienda { get => tipo_vivienda; set => tipo_vivienda = value; }
        }
    
}
