/*
 Desarrollador: Alfredo Albiter
 Fecha: 08/09/2018
 Descripción: Puesta en practica del concepto blockchain incorporando serialización y deserialización de CFDI
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace fred_BlockChain_2
{
    class Program
    {
        private static List<cls_Block> oBlockchain = null;

        /// <summary>
        /// Blockchain
        /// </summary>
        private static List<cls_Block> Blockchain
        {
            get
            {
                if (oBlockchain == null)
                {
                    oBlockchain = new List<cls_Block>();
                    oBlockchain.Add(new cls_Block(0, null, "valor_indiferente"));
                }

                return oBlockchain;
            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Presiona una tecla para comenzar...");
            Console.ReadLine();

            try
            {
                Console.WriteLine("Dame una carpeta con XML: ");
                string sPathContenedor = Console.ReadLine();

                List<FileInfo> oLsXmls = new DirectoryInfo(sPathContenedor).GetFiles("*.xml").ToList<FileInfo>();
                int iContFiles = oLsXmls.Count;
                int iID = 0;

                foreach (FileInfo oXml in oLsXmls)
                {
                    string sXmlPath = oXml.FullName;
                    Comprobante oCfdi = cls_Auxiliares.getObjectXML(sXmlPath);
                    string sHashAnterior = Blockchain[Blockchain.Count - 1].Hash;
                    iID++;

                    Blockchain.Add(new cls_Block(iID, oCfdi, sHashAnterior));                    
                }

                string sPausa = string.Empty;
            }
            catch (Exception ex)
            {
               throw;
            }

            Console.WriteLine("Presiona una tecla para comenzar...");
            Console.ReadLine();
        }
    }
}
