using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebCalculadoraSeccionB
{
    /// <summary>
    /// Descripción breve de WebCalculadora
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    
    public class WebCalculadora : System.Web.Services.WebService
    {
        /// <summary>
        /// Esta funcion suma dos numeros
        /// </summary>
        /// <param name="pIntNumero1"></param>
        /// <param name="pIntNumero2"></param>
        /// <returns></returns>
        [WebMethod]
        public int fncSuma(int pIntNumero1, int pIntNumero2)
        {
            return pIntNumero1 + pIntNumero2;
        }
        /// <summary>
        /// Esta funcion resta dos numeros
        /// </summary>
        /// <param name="pIntNumero1"></param>
        /// <param name="pIntNumero2"></param>
        /// <returns></returns>
        [WebMethod]
        public int fncResta(int pIntNumero1, int pIntNumero2)
        {
            return pIntNumero1 - pIntNumero2;
        }
        /// <summary>
        /// Esta funcion multiplica dos numeros
        /// </summary>
        /// <param name="pIntNumero1"></param>
        /// <param name="pIntNumero2"></param>
        /// <returns></returns>
        [WebMethod]
        public int fncMultiplicacion(int pIntNumero1, int pIntNumero2)
        {
            return pIntNumero1 * pIntNumero2;
        }
        /// <summary>
        /// Esta funcion dividos dos numeros
        /// </summary>
        /// <param name="pIntNumero1"></param>
        /// <param name="pIntNumero2"></param>
        /// <returns></returns>
        [WebMethod]
        public int fncDivision(int pIntNumero1, int pIntNumero2)
        {
            return pIntNumero1 / pIntNumero2;
        }
    }
}
