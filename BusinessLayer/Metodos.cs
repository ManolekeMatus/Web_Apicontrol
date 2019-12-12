using BusinessClass;
using CommonUtilities;
using Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class MetodosLogin
    {
        ConexionLogin Conexion;

        public MetodosLogin()
        {
            Conexion = new ConexionLogin(ConfigurationClass.LoginBDConnection);
        }

        public Usuario CheckUser(string usuario, string password, string compania)
        {
            string Query = string.Format("SELECT * from public.login_checkuser('{0}','{1}','{2}')", usuario, password, compania);

            Usuario response = Conexion.CheckUser(Query);

            return response;
        }
    }

    public class MetodosClient
    {
        ConexionCliente Conexion;

        public MetodosClient(string Server, string Usr, string Psw, string BD)
        {
            Conexion = new ConexionCliente(Server, Usr, Psw, BD);
        }

        public List<Seguimiento> Seguimiento(string Usuario, string FiltroMov, string FiltroGrup1, string FiltroGrup2, string FiltroGrup3, string FiltroGrup4)
        {
            string Query = string.Format("SELECT Movil"
            + ", MOV_PATENTE"
            + ", Fecha"
            + ", Velocidad"
            + ", Grupo"
            + ", Latitud"
            + ", Longitud"
            + ", Direccion"
            + ", Ignicion"
            + ", MOPO_SENSORA1"
            + ", MOPO_SENSORA2"
            + ", MOPO_SENSORA3"
            + ", MOPO_SENSORD1"
            + ", MOPO_SENSORD2"
            + ", MOPO_SENSORD3"
            + ", MOPO_SENSORD4"
            + ", MOPO_SENSORD5"
            + ", MOPO_SENSORD6"
            + ", MOV_GRUPO1"
            + ", MOV_GRUPO2"
            + ", MOV_GRUPO3"
            + ", MOV_GRUPO4"
            + ", Imagen"
            + ", CONDUCTOR"
            + ", MOV_SIMBOLO"
            + ", TIPOMOVIL  from  public.mz_seguimiento('{0}','{1}','{2}','{3}','{4}','{5}')", Usuario, FiltroMov, FiltroGrup1, FiltroGrup2, FiltroGrup3, FiltroGrup4);

            List<Seguimiento> Seg = Conexion.ReturnSeguimiento(Query);

            return Seg;
        }
    }
}
