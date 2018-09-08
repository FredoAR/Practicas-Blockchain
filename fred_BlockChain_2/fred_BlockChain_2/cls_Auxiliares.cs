using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Security.Cryptography;


namespace fred_BlockChain_2
{
    public static class cls_Auxiliares
    {
        private static UTF8Encoding oUTF8 = new UTF8Encoding(false);
        private static SHA256 oSHA256 = null;

        /// <summary>
        /// Algoritmo implementado para la generación del hash del block
        /// </summary>
        public static SHA256 ALGO_SHA256
        {
            get
            {
                if (oSHA256 == null)
                    oSHA256 = SHA256.Create("SHA256");

                return oSHA256;
            }
        }


        /// <summary>
        /// Recupera el contenido del XML
        /// </summary>
        /// <param name="sPathXML">Ruta del XML origen</param>
        /// <returns>Secuencia byte[] con el contnido del XML</returns>
        private static byte[] getContenidoXML(string sPathXML)
        {
            try
            {
                string sContenidoXML = new StreamReader(sPathXML, oUTF8).ReadToEnd();
                return oUTF8.GetBytes(sContenidoXML);
            }
            catch (Exception ex)
            {
                throw new Exception("Algo salio mal en la lectura del XML.");
            }
        }


        /// <summary>
        /// Deserialización del XML recibido a tipo clase cls_Xml
        /// </summary>
        /// <param name="sPathML">Ruta del XML origen</param>
        /// <returns>Objeto tipo Comprobante con la información del XML</returns>
        public static Comprobante getObjectXML(string sPathML)
        {
            MemoryStream oObjXML = null;

            try
            {
                XmlSerializer oSerializer = new XmlSerializer(typeof(Comprobante));
                byte[] yContenidoXML = getContenidoXML(sPathML);
                oObjXML = new MemoryStream(yContenidoXML);
                return (Comprobante)oSerializer.Deserialize(oObjXML);
            }
            catch (Exception ex)
            {
                throw new Exception("Algo salio mal en la desaerializacion del XML.");                    
            }
            finally
            {
                if (oObjXML != null)
                    oObjXML.Close();
            }
        }


        /// <summary>
        /// Serialización del objeto tipo clase cls_Xml a XML
        /// </summary>
        /// <param name="sPathML">Objeto Comprobante</param>
        /// <returns>Objeto tipo Comprobante con la informacion del XML</returns>
        public static byte[] getXmlObject(Comprobante oCFDi)
        {
            MemoryStream oObjXML = null;

            try
            {
                XmlSerializer oSerializer = new XmlSerializer(typeof(Comprobante));                
                oObjXML = new MemoryStream();
                oSerializer.Serialize(oObjXML, oCFDi);
                return oObjXML.ToArray();
            }
            catch (Exception ex)
            {
                throw new Exception("Algo salio mal en la desaerializacion del XML.");
            }
            finally
            {
                if (oObjXML != null)
                    oObjXML.Close();
            }
        }

    }
}
