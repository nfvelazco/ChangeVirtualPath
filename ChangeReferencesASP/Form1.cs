using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChangeReferencesASP
{
    public partial class Form1 : Form
    {
        DirectoryInfo infoSource = null;
        DirectoryInfo infoDestino = null;

        ProcesadorArchivos Procesador;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetSource_Click(object sender, EventArgs e)
        {
            DialogResult result = FolderSource.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = FolderSource.SelectedPath;
                txtRutaSource.Text = path;
                infoSource = new DirectoryInfo(path);
            }
        }

        private void btnSetDestino_Click(object sender, EventArgs e)
        {
            DialogResult result = FolderDestino.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = FolderDestino.SelectedPath;
                txtRutaDestino.Text = path;
                infoDestino = new DirectoryInfo(path);
                FileInfo[] archivos = infoDestino.GetFiles();

                

            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
            if (infoSource != null)
            {
                if (infoDestino != null)
                {
                    if (txtRutaDestino.Text != txtRutaSource.Text)
                    {
                        if (txtNuevoPath.Text != "")
                        {
                            txtEstado.Text = "";
                            try
                            {
                                Procesador = new ProcesadorArchivos(txtNuevoPath.Text);
                                Procesador.ProcesarArchivos(infoSource, infoDestino);
                            }
                            catch (Exception ex)
                            {
                                txtEstado.Text = ex.Message;
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            txtEstado.Text = "Ingrese el prefijo para las nuevas rutas logicas";
                        }
                    }
                    else {
                        txtEstado.Text = "La carpeta origen debe ser distinta a la carpeta destino";
                    }
                }
                else {
                    txtEstado.Text = "Seleccione la carpeta destino";
                }
            }
            else {
                txtEstado.Text = "Seleccione la carpeta origen";
            }
            //txtEstado.Text = "/\"=";
        }

        
    }
}
