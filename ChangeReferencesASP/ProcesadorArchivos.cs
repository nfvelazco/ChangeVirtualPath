using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ChangeReferencesASP
{
    class ProcesadorArchivos
    {
        string _nuevoPath = "";

        public ProcesadorArchivos(string NuevoPath) {
            _nuevoPath = NuevoPath + "/";
        }

        internal void ProcesarArchivos(DirectoryInfo infoSource, DirectoryInfo infoDestino)
        {
            try
            {
                string rutaDestino = infoDestino.FullName;
                this.RecorrerCarpetasDestino(infoSource, rutaDestino);
                DirectoryInfo auxDestino = null;
                foreach (DirectoryInfo Source in infoSource.GetDirectories())
                {

                    var newDestino = rutaDestino + "/" + Source.Name;
                    auxDestino = new DirectoryInfo(newDestino);
                    if (!auxDestino.Exists) {
                        auxDestino.Create();
                    }
                    this.RecorrerCarpetasDestino(Source, newDestino);
                    this.ProcesarArchivos(Source, auxDestino);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la ruta: " + infoDestino.FullName);
            }
        }

        private void RecorrerCarpetasDestino(DirectoryInfo Source, string rutaDestino){

            ReglasDeExclusion excplusionDeArchivos = new ReglasDeExclusion();
            FileInfo[] ArchivosOrigen = Source.GetFiles();

            
            

            foreach (FileInfo item in ArchivosOrigen)
            {
                bool reemplaza = true;
                bool copia = true;
                foreach (var unaExclucion in excplusionDeArchivos.Reglas)
                {
                    if (item.Name.Contains(unaExclucion.Key)) {
                        reemplaza = false;
                        copia = unaExclucion.Value;
                    }

                }
                if (copia)
                {
                    this.ReemplazarRutasArchivoEnDestino(rutaDestino, item,reemplaza);
                }
            }
        }

        private void ReemplazarRutasArchivoEnDestino(string RutaDestino, FileInfo file, bool reemplazar) {
            
            
            
            
            DirectoryInfo destino = new DirectoryInfo(RutaDestino);

            var newfile = new FileInfo(Path.Combine(destino.FullName, file.Name));
            

            

            using (Stream stream = newfile.OpenWrite())

            using (StreamReader sr = new StreamReader(file.FullName))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    ReglasDeReemplazo replaceArrumacos = new ReglasDeReemplazo(_nuevoPath);
                    while (sr.Peek() >= 0)
                    {
                        
                        string line = sr.ReadLine();
                        
                        foreach (var item in replaceArrumacos.Reglas)
                        {
                            if(reemplazar) 
                                line = line.Replace(item.Key, item.Value);
                        }
                        
                        writer.WriteLine(line);

                    }
                }
            }


            
        }


    }
}
