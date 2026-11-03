namespace exam
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnevaluar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.lstcategorias = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnevaluar
            // 
            this.btnevaluar.Location = new System.Drawing.Point(37, 123);
            this.btnevaluar.Name = "btnevaluar";
            this.btnevaluar.Size = new System.Drawing.Size(75, 23);
            this.btnevaluar.TabIndex = 0;
            this.btnevaluar.Text = "Evaluar";
            this.btnevaluar.UseVisualStyleBackColor = true;
            this.btnevaluar.Click += new System.EventHandler(this.btnevaluar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(149, 122);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 1;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(51, 13);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(105, 13);
            this.lbltitulo.TabIndex = 2;
            this.lbltitulo.Text = "Clasificación de nota";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(51, 70);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(55, 13);
            this.lblresultado.TabIndex = 3;
            this.lblresultado.Text = "Resultado";
            // 
            // txtnota
            // 
            this.txtnota.Location = new System.Drawing.Point(54, 38);
            this.txtnota.Name = "txtnota";
            this.txtnota.Size = new System.Drawing.Size(100, 20);
            this.txtnota.TabIndex = 4;
            this.txtnota.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lstcategorias
            // 
            this.lstcategorias.FormattingEnabled = true;
            this.lstcategorias.Items.AddRange(new object[] {
            "Excelente",
            "",
            "Muy bueno",
            "",
            "Bueno",
            "",
            "Regular",
            "",
            "Deficiente"});
            this.lstcategorias.Location = new System.Drawing.Point(12, 164);
            this.lstcategorias.Name = "lstcategorias";
            this.lstcategorias.Size = new System.Drawing.Size(120, 121);
            this.lstcategorias.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 309);
            this.Controls.Add(this.lstcategorias);
            this.Controls.Add(this.txtnota);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnevaluar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnevaluar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txtnota;
        private System.Windows.Forms.ListBox lstcategorias;
    }
}

