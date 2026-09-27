namespace Calculadora
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
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSuma1 = new System.Windows.Forms.Label();
            this.lblSuma2 = new System.Windows.Forms.Label();
            this.lbldec1 = new System.Windows.Forms.Label();
            this.lbldec2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtSuma1 = new System.Windows.Forms.TextBox();
            this.txtSuma2 = new System.Windows.Forms.TextBox();
            this.txtdec1 = new System.Windows.Forms.TextBox();
            this.txtdec2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSumar
            // 
            this.btnSumar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSumar.Location = new System.Drawing.Point(65, 153);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(75, 23);
            this.btnSumar.TabIndex = 0;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = false;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnMultiplicar.Location = new System.Drawing.Point(359, 153);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplicar.TabIndex = 1;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Suma de dos números enteros ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(325, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Multiplicación de dos números decimales";
            // 
            // lblSuma1
            // 
            this.lblSuma1.AutoSize = true;
            this.lblSuma1.Location = new System.Drawing.Point(32, 55);
            this.lblSuma1.Name = "lblSuma1";
            this.lblSuma1.Size = new System.Drawing.Size(53, 13);
            this.lblSuma1.TabIndex = 4;
            this.lblSuma1.Text = "Número 1";
            this.lblSuma1.Click += new System.EventHandler(this.lblSuma1_Click);
            // 
            // lblSuma2
            // 
            this.lblSuma2.AutoSize = true;
            this.lblSuma2.Location = new System.Drawing.Point(32, 88);
            this.lblSuma2.Name = "lblSuma2";
            this.lblSuma2.Size = new System.Drawing.Size(53, 13);
            this.lblSuma2.TabIndex = 5;
            this.lblSuma2.Text = "Número 2";
            // 
            // lbldec1
            // 
            this.lbldec1.AutoSize = true;
            this.lbldec1.Location = new System.Drawing.Point(325, 48);
            this.lbldec1.Name = "lbldec1";
            this.lbldec1.Size = new System.Drawing.Size(56, 13);
            this.lbldec1.TabIndex = 6;
            this.lbldec1.Text = "Número 1 ";
            this.lbldec1.Click += new System.EventHandler(this.lbldec1_Click);
            // 
            // lbldec2
            // 
            this.lbldec2.AutoSize = true;
            this.lbldec2.Location = new System.Drawing.Point(325, 88);
            this.lbldec2.Name = "lbldec2";
            this.lbldec2.Size = new System.Drawing.Size(53, 13);
            this.lbldec2.TabIndex = 7;
            this.lbldec2.Text = "Número 2";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResultado.Location = new System.Drawing.Point(30, 118);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProducto.Location = new System.Drawing.Point(325, 118);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(55, 13);
            this.lblProducto.TabIndex = 9;
            this.lblProducto.Text = "Resultado";
            // 
            // txtSuma1
            // 
            this.txtSuma1.Location = new System.Drawing.Point(91, 55);
            this.txtSuma1.Name = "txtSuma1";
            this.txtSuma1.Size = new System.Drawing.Size(100, 20);
            this.txtSuma1.TabIndex = 10;
            // 
            // txtSuma2
            // 
            this.txtSuma2.Location = new System.Drawing.Point(89, 81);
            this.txtSuma2.Name = "txtSuma2";
            this.txtSuma2.Size = new System.Drawing.Size(100, 20);
            this.txtSuma2.TabIndex = 11;
            // 
            // txtdec1
            // 
            this.txtdec1.Location = new System.Drawing.Point(387, 45);
            this.txtdec1.Name = "txtdec1";
            this.txtdec1.Size = new System.Drawing.Size(100, 20);
            this.txtdec1.TabIndex = 12;
            // 
            // txtdec2
            // 
            this.txtdec2.Location = new System.Drawing.Point(387, 81);
            this.txtdec2.Name = "txtdec2";
            this.txtdec2.Size = new System.Drawing.Size(100, 20);
            this.txtdec2.TabIndex = 13;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(91, 118);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 14;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(387, 115);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(100, 20);
            this.txtProducto.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtdec2);
            this.Controls.Add(this.txtdec1);
            this.Controls.Add(this.txtSuma2);
            this.Controls.Add(this.txtSuma1);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lbldec2);
            this.Controls.Add(this.lbldec1);
            this.Controls.Add(this.lblSuma2);
            this.Controls.Add(this.lblSuma1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSumar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSuma1;
        private System.Windows.Forms.Label lblSuma2;
        private System.Windows.Forms.Label lbldec1;
        private System.Windows.Forms.Label lbldec2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtSuma1;
        private System.Windows.Forms.TextBox txtSuma2;
        private System.Windows.Forms.TextBox txtdec1;
        private System.Windows.Forms.TextBox txtdec2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtProducto;
    }
}

