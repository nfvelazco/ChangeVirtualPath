using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace ChangeReferencesASP
{
    class ReglasDeReemplazo
    {
        Dictionary<string, string> _reglas = new Dictionary<string, string>();

        public Dictionary<string, string> Reglas
        {
            get { return _reglas; }
            set { _reglas = value; }
        }

        public ReglasDeReemplazo(string nuevoPath)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("./XML/Reglas.xml");
            XmlNodeList tagReglas = xDoc.GetElementsByTagName("reglas");
            XmlNodeList listaReglas = ((XmlElement)tagReglas[0]).GetElementsByTagName("regla");

            foreach (XmlElement unaRegla in listaReglas)
            {
                _reglas.Add(unaRegla.GetAttribute("Key"), unaRegla.GetAttribute("Value").Replace("###", nuevoPath));
            }

        }

    }
}
