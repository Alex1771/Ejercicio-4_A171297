using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace C_Areas
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public decimal A_Cuadrado(decimal N01, decimal N02)
        {
            Class1 c = new Class1();
            c.Numero01 = N01;
            c.Numero02 = N02;
            return c.A_Cuadrado();
        }
        [WebMethod]
        public decimal A_Circulo(decimal N01)
        {
            Class1 c = new Class1();
            return c.A_Circulo(N01);
        }
        [WebMethod]
        public decimal A_triangulo(decimal N01, decimal N02)
        {
            Class1 c = new Class1();
            return c.A_Triangulo(N01,N02);
        }

    }
}
