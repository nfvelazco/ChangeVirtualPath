using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace ChangeReferencesASP
{
    class ReglasDeExclusion
    {

        Dictionary<string, bool> _reglas = new Dictionary<string, bool>();

        public Dictionary<string, bool> Reglas
        {
            get { return _reglas; }
            set { _reglas = value; }
        }

        public ReglasDeExclusion()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("./XML/ExcluirExtension.xml");
            XmlNodeList tagReglas = xDoc.GetElementsByTagName("exclusiones");
            XmlNodeList listaReglas = ((XmlElement)tagReglas[0]).GetElementsByTagName("exclusion");

            foreach (XmlElement unaRegla in listaReglas)
            {
                _reglas.Add(unaRegla.GetAttribute("extension"), bool.Parse(unaRegla.GetAttribute("copiar")));
            }

        }


    }
}
