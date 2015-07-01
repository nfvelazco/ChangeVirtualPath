namespace ChangeReferencesASP
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.FolderSource = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSetSource = new System.Windows.Forms.Button();
            this.txtRutaSource = new System.Windows.Forms.TextBox();
            this.txtRutaDestino = new System.Windows.Forms.TextBox();
            this.btnSetDestino = new System.Windows.Forms.Button();
            this.FolderDestino = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNuevoPath = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSetSource
            // 
            this.btnSetSource.Location = new System.Drawing.Point(381, 19);
            this.btnSetSource.Name = "btnSetSource";
            this.btnSetSource.Size = new System.Drawing.Size(75, 23);
            this.btnSetSource.TabIndex = 0;
            this.btnSetSource.Text = "Seleccionar";
            this.btnSetSource.UseVisualStyleBackColor = true;
            this.btnSetSource.Click += new System.EventHandler(this.btnSetSource_Click);
            // 
            // txtRutaSource
            // 
            this.txtRutaSource.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtRutaSource.Enabled = false;
            this.txtRutaSource.Location = new System.Drawing.Point(11, 21);
            this.txtRutaSource.Name = "txtRutaSource";
            this.txtRutaSource.Size = new System.Drawing.Size(364, 20);
            this.txtRutaSource.TabIndex = 1;
            // 
            // txtRutaDestino
            // 
            this.txtRutaDestino.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtRutaDestino.Enabled = false;
            this.txtRutaDestino.Location = new System.Drawing.Point(11, 21);
            this.txtRutaDestino.Name = "txtRutaDestino";
            this.txtRutaDestino.Size = new System.Drawing.Size(364, 20);
            this.txtRutaDestino.TabIndex = 3;
            // 
            // btnSetDestino
            // 
            this.btnSetDestino.Location = new System.Drawing.Point(381, 19);
            this.btnSetDestino.Name = "btnSetDestino";
            this.btnSetDestino.Size = new System.Drawing.Size(75, 23);
            this.btnSetDestino.TabIndex = 2;
            this.btnSetDestino.Text = "Seleccionar";
            this.btnSetDestino.UseVisualStyleBackColor = true;
            this.btnSetDestino.Click += new System.EventHandler(this.btnSetDestino_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetSource);
            this.groupBox1.Controls.Add(this.txtRutaSource);
            this.groupBox1.Location = new System.Drawing.Point(23, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 57);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Origen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSetDestino);
            this.groupBox2.Controls.Add(this.txtRutaDestino);
            this.groupBox2.Location = new System.Drawing.Point(23, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 57);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destino";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtNuevoPath);
            this.groupBox3.Location = new System.Drawing.Point(23, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(471, 83);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nuevo Path Virtual";
            // 
            // txtNuevoPath
            // 
            this.txtNuevoPath.Location = new System.Drawing.Point(11, 21);
            this.txtNuevoPath.Name = "txtNuevoPath";
            this.txtNuevoPath.Size = new System.Drawing.Size(445, 20);
            this.txtNuevoPath.TabIndex = 4;
            // 
            // txtEstado
            // 
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtEstado.Location = new System.Drawing.Point(0, 269);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEstado.Size = new System.Drawing.Size(523, 25);
            this.txtEstado.TabIndex = 7;
            this.txtEstado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(404, 235);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 8;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(445, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "No colocar la barra inicial (/) ejemplo si queremos que el inicio de la ruta logi" +
    "ca sea \"/multi/uno\" solo ingresar \"multi/uno\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 294);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anexo de Ruta Logica";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog FolderSource;
        private System.Windows.Forms.Button btnSetSource;
        private System.Windows.Forms.TextBox txtRutaSource;
        private System.Windows.Forms.TextBox txtRutaDestino;
        private System.Windows.Forms.Button btnSetDestino;
        private System.Windows.Forms.FolderBrowserDialog FolderDestino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNuevoPath;
        private System.Windows.Forms.Label txtEstado;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label2;
    }
}

