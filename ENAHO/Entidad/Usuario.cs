using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Usuario
    {
        private string user;
        private string pass;

        public Usuario()
        {
            this.User = string.Empty;
            this.Pass = string.Empty;
        }

        public Usuario(string user, string pass)
        {
            this.User = user;
            this.Pass = pass;
        }

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
