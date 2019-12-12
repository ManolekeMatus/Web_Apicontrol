using BusinessClass;
using CommonUtilities;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class ConexionLogin
    {
        string StringConexion;

        public ConexionLogin(string stringConexion)
        {
            StringConexion = stringConexion;
        }

        public Usuario CheckUser(string Query)
        {
            Usuario response = null;

            NpgsqlConnection Con = new NpgsqlConnection(StringConexion);
            Con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(Query, Con);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                response = new Usuario()
                {
                    Usr_Id = int.Parse(dr[0].ToString()),
                    Cli_Id = int.Parse(dr[1].ToString()),
                    Rol_Id = int.Parse(dr[2].ToString()),
                    Usr_Id_Padre = dr[3].ToString() == "" ? -1 : int.Parse(dr[3].ToString()),
                    Usr_Nombre = dr[4].ToString(),
                    Usr_Apellido = dr[5].ToString(),
                    Usr_User = dr[6].ToString(),
                    Usr_Pass = dr[7].ToString(),
                    Usr_Rut = dr[8].ToString(),
                    Usr_FechaIngreso = DateTime.ParseExact(dr[9].ToString(), "dd-MM-yyyy H:mm:ss", null),
                    Usr_LatMap = dr[10].ToString() == "" ? -1 : double.Parse(dr[10].ToString()),
                    Usr_LngMap = dr[11].ToString() == "" ? -1 : double.Parse(dr[11].ToString()),
                    Usr_ZoomMap = dr[12].ToString() == "" ? -1 : int.Parse(dr[12].ToString())
                };
            }

            Con.Close();

            return response;
        }
    }

    public class ConexionCliente
    {
        string StringConexion;

        public ConexionCliente(string Server, string Usr, string Psw, string BD)
        {
            StringConexion = string.Format(ConfigurationClass.FormatBDConnection, Server, Usr, Psw, BD);
        }

        public List<Seguimiento> ReturnSeguimiento(string Query)
        {
            List<Seguimiento> Seg = new List<Seguimiento>();

            NpgsqlConnection Con = new NpgsqlConnection(StringConexion);
            Con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(Query, Con);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Seg.Add(new Seguimiento
                {
                    Movil = dr[0].ToString(),
                    MOV_PATENTE = dr[1].ToString(),
                    Fecha = DateTime.ParseExact(dr[2].ToString(), "dd-MM-yyyy HH:mm:ss", null),
                    Velocidad = Convert.ToInt32(dr[3].ToString()),
                    Grupo = dr[4].ToString(),
                    Latitud = Convert.ToDouble(dr[5].ToString()),
                    Longitud = Convert.ToDouble(dr[6].ToString()),
                    Direccion = Convert.ToInt32(dr[7].ToString()),
                    Ignicion = Convert.ToBoolean(dr[8].ToString()),
                    MOPO_SENSORA1 = dr[9].ToString(),
                    MOPO_SENSORA2 = dr[10].ToString(),
                    MOPO_SENSORA3 = dr[11].ToString(),
                    MOPO_SENSORD1 = dr[12].ToString(),
                    MOPO_SENSORD2 = dr[13].ToString(),
                    MOPO_SENSORD3 = dr[14].ToString(),
                    MOPO_SENSORD4 = dr[15].ToString(),
                    MOPO_SENSORD5 = dr[16].ToString(),
                    MOPO_SENSORD6 = dr[17].ToString(),
                    MOV_GRUPO1 = dr[18].ToString(),
                    MOV_GRUPO2 = dr[19].ToString(),
                    MOV_GRUPO3 = dr[20].ToString(),
                    MOV_GRUPO4 = dr[21].ToString(),
                    Imagen = dr[22].ToString(),
                    CONDUCTOR = dr[23].ToString(),
                    MOV_SIMBOLO = dr[24].ToString(),
                    TIPOMOVIL = dr[25].ToString()
                });
            }
            Con.Close();

            return Seg;
        }

    }
}
