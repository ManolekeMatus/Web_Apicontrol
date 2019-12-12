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
    public class LoginController : ApiController
    {
        public Usuario Get(string Usuario, string Password, string Compania)
        {
            MetodosLogin Metodos = new MetodosLogin();
            Usuario existe = Metodos.CheckUser(Usuario, Password, Compania);
            return existe;
        }
    }
}