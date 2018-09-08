using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fred_BlockChain_2
{
    /// <summary>
    /// Representa la estuctura de un bloque dentro de la cadena
    /// </summary>
    public class cls_Block
    {
        private static UTF8Encoding oUTF8 = new UTF8Encoding(false);


        /// <summary>
        /// Identificador del block
        /// </summary>
        public int Id { set; get; }

        /// <summary>
        /// Hora de creación o recepción del block
        /// </summary>
        public string HoraRecibido { set; get; }

        /// <summary>
        /// Objeto tipo Comprobante con la información del CFDI
        /// </summary>
        public Comprobante CFdi { set; get; }

        /// <summary>
        /// Hash del block anterior
        /// </summary>
        public string HashAnterior { set; get; }

        /// <summary>
        /// Hash del block actual
        /// </summary>
        public string Hash { set; get; }


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="iId">ID del block</param>
        /// <param name="oCfdi">Objeto Comprobante con información del xml reibido</param>
        /// <param name="sHashAnterior">Hash del block anterior</param>
        public cls_Block(int iId, Comprobante oCfdi, string sHashAnterior)
        {
            this.Id = iId;
            this.HoraRecibido = getFecha();
            this.CFdi = oCfdi;
            this.HashAnterior = sHashAnterior;
            this.Hash = getHash();
        }


        /// <summary>
        /// Genera HASH del objeto recibido implementando algoritmo SHA256
        /// </summary>
        /// <param name="oCFDi">Objeto tipo Comprobante</param>
        /// <returns>string. Hash</returns>
        public string getHash()
        {
            try
            {
                string sCadena_Hash = this.HashAnterior + this.HoraRecibido + oUTF8.GetString(cls_Auxiliares.getXmlObject(this.CFdi));
                byte[] yHash = cls_Auxiliares.ALGO_SHA256.ComputeHash(oUTF8.GetBytes(sCadena_Hash));
                return Convert.ToBase64String(yHash);
            }
            catch (Exception x)
            {
                throw;
            }
        }


        /// <summary>
        /// Devuelve la fecha actual en formato yyyy-MM-ddTHH:mm:ss
        /// </summary>
        /// <returns>string. Fecha</returns>
        private string getFecha()
        {
            return DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
        }

    }
}
