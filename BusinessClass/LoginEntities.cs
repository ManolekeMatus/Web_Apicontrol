using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessClass
{
    public class Usuario
    {
        public int Usr_Id { get; set; }
        public int Cli_Id { get; set; }
        public int Rol_Id { get; set; }
        public Nullable<int> Usr_Id_Padre { get; set; }
        public string Usr_Nombre { get; set; }
        public string Usr_Apellido { get; set; }
        public string Usr_User { get; set; }
        public string Usr_Pass { get; set; }
        public string Usr_Rut { get; set; }
        public System.DateTime Usr_FechaIngreso { get; set; }
        public Nullable<double> Usr_LatMap { get; set; }
        public Nullable<double> Usr_LngMap { get; set; }
        public Nullable<int> Usr_ZoomMap { get; set; }
    }
}