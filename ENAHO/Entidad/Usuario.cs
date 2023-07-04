using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Usuario
    {

        private int id;
        private string user;
        private string pass;

        public Usuario()
        {
            this.User = string.Empty;
            this.Pass = string.Empty;
        }

        public Usuario(string user, string pass, int id)
        {

            this.Id = id;
            this.User = user;
            this.Pass = pass;
        }

        public int Id { get => id; set => id = value; }
        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }

        /*---------
         ----------
         ----------
         ----------
         ----------
         ----------*/
    }
}
