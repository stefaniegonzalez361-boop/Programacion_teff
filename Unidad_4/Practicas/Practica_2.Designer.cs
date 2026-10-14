namespace Unidad_4.Practicas
{
    partial class Practica_2
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
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.lblproducto = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnguardar.Location = new System.Drawing.Point(106, 125);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 37);
            this.btnguardar.TabIndex = 0;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.Pink;
            this.txtnombre.Location = new System.Drawing.Point(106, 28);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(132, 37);
            this.txtnombre.TabIndex = 1;
            // 
            // txtprecio
            // 
            this.txtprecio.BackColor = System.Drawing.Color.LightPink;
            this.txtprecio.Location = new System.Drawing.Point(106, 71);
            this.txtprecio.Multiline = true;
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(132, 38);
            this.txtprecio.TabIndex = 2;
            this.txtprecio.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblproducto
            // 
            this.lblproducto.AutoSize = true;
            this.lblproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblproducto.Location = new System.Drawing.Point(28, 41);
            this.lblproducto.Name = "lblproducto";
            this.lblproducto.Size = new System.Drawing.Size(50, 13);
            this.lblproducto.TabIndex = 3;
            this.lblproducto.Text = "Producto";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblprecio.Location = new System.Drawing.Point(28, 85);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(37, 13);
            this.lblprecio.TabIndex = 4;
            this.lblprecio.Text = "Precio";
            // 
            // Practica_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 174);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lblproducto);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btnguardar);
            this.Name = "Practica_2";
            this.Text = "Practica_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label lblproducto;
        private System.Windows.Forms.Label lblprecio;
    }
}