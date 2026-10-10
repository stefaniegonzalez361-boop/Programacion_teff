namespace Practica_programada
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
            this.txtmostrardia = new System.Windows.Forms.TextBox();
            this.btnmostrardia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtmostrardia
            // 
            this.txtmostrardia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtmostrardia.Location = new System.Drawing.Point(46, 31);
            this.txtmostrardia.Multiline = true;
            this.txtmostrardia.Name = "txtmostrardia";
            this.txtmostrardia.Size = new System.Drawing.Size(100, 34);
            this.txtmostrardia.TabIndex = 0;
            // 
            // btnmostrardia
            // 
            this.btnmostrardia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnmostrardia.Location = new System.Drawing.Point(46, 71);
            this.btnmostrardia.Name = "btnmostrardia";
            this.btnmostrardia.Size = new System.Drawing.Size(100, 48);
            this.btnmostrardia.TabIndex = 1;
            this.btnmostrardia.Text = "Mostrar Día ";
            this.btnmostrardia.UseVisualStyleBackColor = false;
            this.btnmostrardia.Click += new System.EventHandler(this.btnmostrardia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 144);
            this.Controls.Add(this.btnmostrardia);
            this.Controls.Add(this.txtmostrardia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmostrardia;
        private System.Windows.Forms.Button btnmostrardia;
    }
}

