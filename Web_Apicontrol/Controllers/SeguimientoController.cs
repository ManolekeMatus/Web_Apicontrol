using BusinessClass;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Web_Apicontrol.Controllers
{
    public class SeguimientoController : ApiController
    {
        public List<Seguimiento> Get(string Server, string Usr, string Psw, string BD, string Usuario, string FiltroMov = "", string FiltroGrup1 = "", string FiltroGrup2 = "", string FiltroGrup3 = "", string FiltroGrup4 = "")
        {
            MetodosClient Metodos = new MetodosClient(Server, Usr, Psw, BD);
            List<Seguimiento> Seg = Metodos.Seguimiento(Usuario, FiltroMov, FiltroGrup1, FiltroGrup2, FiltroGrup3, FiltroGrup4);
            return Seg;
        }
    }
}
