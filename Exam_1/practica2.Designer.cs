namespace Exam_1.ejercicios
{
    partial class practica2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnevaluar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.lblnota = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.lstcategorias = new System.Windows.Forms.ListBox();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnevaluar
            // 
            this.btnevaluar.Location = new System.Drawing.Point(12, 66);
            this.btnevaluar.Name = "btnevaluar";
            this.btnevaluar.Size = new System.Drawing.Size(75, 23);
            this.btnevaluar.TabIndex = 0;
            this.btnevaluar.Text = "Evaluar";
            this.btnevaluar.UseVisualStyleBackColor = true;
            this.btnevaluar.Click += new System.EventHandler(this.btnevaluar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(124, 66);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 1;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // lblnota
            // 
            this.lblnota.AutoSize = true;
            this.lblnota.Location = new System.Drawing.Point(12, 9);
            this.lblnota.Name = "lblnota";
            this.lblnota.Size = new System.Drawing.Size(105, 13);
            this.lblnota.TabIndex = 2;
            this.lblnota.Text = "Clasificación de nota";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(14, 102);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(55, 13);
            this.lblresultado.TabIndex = 3;
            this.lblresultado.Text = "Resultado";
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
            this.lstcategorias.Location = new System.Drawing.Point(12, 130);
            this.lstcategorias.Name = "lstcategorias";
            this.lstcategorias.Size = new System.Drawing.Size(120, 121);
            this.lstcategorias.TabIndex = 4;
            // 
            // txtnota
            // 
            this.txtnota.Location = new System.Drawing.Point(17, 25);
            this.txtnota.Name = "txtnota";
            this.txtnota.Size = new System.Drawing.Size(100, 20);
            this.txtnota.TabIndex = 5;
            // 
            // ejercicio_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtnota);
            this.Controls.Add(this.lstcategorias);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblnota);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnevaluar);
            this.Name = "ejercicio_2";
            this.Text = "ejercicio_2";
            this.Load += new System.EventHandler(this.ejercicio_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnevaluar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label lblnota;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.ListBox lstcategorias;
        private System.Windows.Forms.TextBox txtnota;
    }
}