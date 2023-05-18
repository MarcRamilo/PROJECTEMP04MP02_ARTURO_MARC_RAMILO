using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJECTEMP02_MARCRAMILO.model;
using System.Windows.Forms;
using System.Xml;
using System;
using System.Collections.Generic;
using System.Xml;
using System;
using System.Collections.Generic;
using System.Xml;
using PROJECTEMP02_MARCRAMILO.model;

namespace PROJECTEMP02_MARCRAMILO.model
{


 
    public class ProductesManager
    {

        public static string Message = String.Empty;
        public static List<Producte> ProcessXml(string filePath)
            {
                List<Producte> productes = new List<Producte>();

                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(filePath);
                    XmlNodeList producteNodes = doc.SelectNodes("//producte");

                    foreach (XmlNode producteNode in producteNodes)
                    {
                        Producte producte = new Producte();
                        producte.id = int.Parse(producteNode.Attributes["id"].InnerText);
                        producte.Name = producteNode.SelectSingleNode("nom").InnerText;
                        producte.preu = int.Parse(producteNode.SelectSingleNode("preu").InnerText);
                        producte.descripcio = producteNode.SelectSingleNode("descripcio").InnerText;

                        XmlNodeList colorNodes = producteNode.SelectNodes("colors/color");
                        foreach (XmlNode colorNode in colorNodes)
                        {
                            color color = new color();
                            color.codi = colorNode.Attributes["codi"].Value;
                            producte.colors.colors.Add(color);
                        }

                        XmlNodeList tallaNodes = producteNode.SelectNodes("talles/talla");
                        foreach (XmlNode tallaNode in tallaNodes)
                        {
                            talla talla = new talla();
                            talla.unitat = tallaNode.Attributes["unitat"].Value;
                            producte.talles.talles.Add(talla);
                        }

                        productes.Add(producte);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en LA LECTURA DE FITXER: " + ex.Message);
                }

                return productes;
            }
        }
    }

}
