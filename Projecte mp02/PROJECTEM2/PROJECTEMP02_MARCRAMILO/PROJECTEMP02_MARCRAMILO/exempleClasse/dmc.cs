using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PROJECTEMP02_MARCRAMILO.model
{
    public static class dmc //DMCManager
    {
        private static List<Campionats> campionats = new List<Campionats>();
        public static string Message = String.Empty;
        public static bool carregarModel(String filePath)
        {
            bool bres = false;
            try
            {
                /* if(DTDValidator) /fer validació de DTD
                              }
                          }*/
                XmlDocument doc= new XmlDocument();
                doc.LoadXml(filePath);
                XmlNodeList ElementCampionat = doc.SelectNodes("//championship");
                
                foreach (XmlNode campionat in ElementCampionat)
                {
                    Campionats cs = new Campionats();
                    cs.Year = int.Parse(campionat.Attributes["year"].InnerText );
                    cs.City = campionat.Attributes["city"].Value;
                    cs.Country = campionat.Attributes["country"].Value;

                    //Hi ha un Error de XPATH S'HA DE TROBAR, el codi esta bé
                    XmlNodeList ElementDJ = doc.SelectNodes("//dj");
                    foreach(XmlNode dJ in ElementDJ)
                    {
                        DJ dJ1 = new DJ();
                        dJ1.Country = dJ.Attributes["local"].Value;
                        dJ1.Name = dJ.SelectSingleNode("nom").Value;
                        dJ1.pos = int.Parse(dJ.SelectSingleNode("pos").InnerText);
                        cs.addDj(dJ1);

                    }
                    campionats.Add(cs);

                }
                bres = true;
            }
            catch (Exception ex)
            {
                Message = "Error en LA LECTURA DE FITXER: " + ex.Message;
            }
                return bres;
        }
    }
}
