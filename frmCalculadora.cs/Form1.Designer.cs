namespace frmCalculadora.cs
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
            this.btnsumar = new System.Windows.Forms.Button();
            this.btnmultiplicar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblsuma1 = new System.Windows.Forms.Label();
            this.lblsuma2 = new System.Windows.Forms.Label();
            this.lblmult1 = new System.Windows.Forms.Label();
            this.lblmult2 = new System.Windows.Forms.Label();
            this.txtsuma1 = new System.Windows.Forms.TextBox();
            this.txtsuma2 = new System.Windows.Forms.TextBox();
            this.txtresultadosuma = new System.Windows.Forms.TextBox();
            this.txtmult1 = new System.Windows.Forms.TextBox();
            this.txtmult2 = new System.Windows.Forms.TextBox();
            this.txtresultadomult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsumar
            // 
            this.btnsumar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsumar.Location = new System.Drawing.Point(140, 148);
            this.btnsumar.Name = "btnsumar";
            this.btnsumar.Size = new System.Drawing.Size(75, 23);
            this.btnsumar.TabIndex = 0;
            this.btnsumar.Text = "Sumar";
            this.btnsumar.UseVisualStyleBackColor = false;
            this.btnsumar.Click += new System.EventHandler(this.btnsumar_Click);
            // 
            // btnmultiplicar
            // 
            this.btnmultiplicar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnmultiplicar.Location = new System.Drawing.Point(496, 161);
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btnmultiplicar.TabIndex = 1;
            this.btnmultiplicar.Text = "Multiplicar";
            this.btnmultiplicar.UseVisualStyleBackColor = false;
            this.btnmultiplicar.Click += new System.EventHandler(this.btnmultiplicar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Suma de dos números enteros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(446, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Multiplicación de decimales";
            // 
            // lblsuma1
            // 
            this.lblsuma1.AutoSize = true;
            this.lblsuma1.Location = new System.Drawing.Point(72, 43);
            this.lblsuma1.Name = "lblsuma1";
            this.lblsuma1.Size = new System.Drawing.Size(53, 13);
            this.lblsuma1.TabIndex = 4;
            this.lblsuma1.Text = "Número 1";
            // 
            // lblsuma2
            // 
            this.lblsuma2.AutoSize = true;
            this.lblsuma2.Location = new System.Drawing.Point(72, 73);
            this.lblsuma2.Name = "lblsuma2";
            this.lblsuma2.Size = new System.Drawing.Size(53, 13);
            this.lblsuma2.TabIndex = 5;
            this.lblsuma2.Text = "Número 2";
            // 
            // lblmult1
            // 
            this.lblmult1.AutoSize = true;
            this.lblmult1.Location = new System.Drawing.Point(407, 59);
            this.lblmult1.Name = "lblmult1";
            this.lblmult1.Size = new System.Drawing.Size(53, 13);
            this.lblmult1.TabIndex = 6;
            this.lblmult1.Text = "Número 1";
            // 
            // lblmult2
            // 
            this.lblmult2.AutoSize = true;
            this.lblmult2.Location = new System.Drawing.Point(407, 92);
            this.lblmult2.Name = "lblmult2";
            this.lblmult2.Size = new System.Drawing.Size(53, 13);
            this.lblmult2.TabIndex = 7;
            this.lblmult2.Text = "Número 2";
            // 
            // txtsuma1
            // 
            this.txtsuma1.Location = new System.Drawing.Point(131, 36);
            this.txtsuma1.Name = "txtsuma1";
            this.txtsuma1.Size = new System.Drawing.Size(100, 20);
            this.txtsuma1.TabIndex = 8;
            // 
            // txtsuma2
            // 
            this.txtsuma2.Location = new System.Drawing.Point(131, 73);
            this.txtsuma2.Name = "txtsuma2";
            this.txtsuma2.Size = new System.Drawing.Size(100, 20);
            this.txtsuma2.TabIndex = 9;
            // 
            // txtresultadosuma
            // 
            this.txtresultadosuma.Location = new System.Drawing.Point(131, 111);
            this.txtresultadosuma.Name = "txtresultadosuma";
            this.txtresultadosuma.Size = new System.Drawing.Size(100, 20);
            this.txtresultadosuma.TabIndex = 10;
            // 
            // txtmult1
            // 
            this.txtmult1.Location = new System.Drawing.Point(482, 52);
            this.txtmult1.Name = "txtmult1";
            this.txtmult1.Size = new System.Drawing.Size(100, 20);
            this.txtmult1.TabIndex = 11;
            // 
            // txtmult2
            // 
            this.txtmult2.Location = new System.Drawing.Point(482, 89);
            this.txtmult2.Name = "txtmult2";
            this.txtmult2.Size = new System.Drawing.Size(100, 20);
            this.txtmult2.TabIndex = 12;
            // 
            // txtresultadomult
            // 
            this.txtresultadomult.Location = new System.Drawing.Point(482, 125);
            this.txtresultadomult.Name = "txtresultadomult";
            this.txtresultadomult.Size = new System.Drawing.Size(100, 20);
            this.txtresultadomult.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtresultadomult);
            this.Controls.Add(this.txtmult2);
            this.Controls.Add(this.txtmult1);
            this.Controls.Add(this.txtresultadosuma);
            this.Controls.Add(this.txtsuma2);
            this.Controls.Add(this.txtsuma1);
            this.Controls.Add(this.lblmult2);
            this.Controls.Add(this.lblmult1);
            this.Controls.Add(this.lblsuma2);
            this.Controls.Add(this.lblsuma1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmultiplicar);
            this.Controls.Add(this.btnsumar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsumar;
        private System.Windows.Forms.Button btnmultiplicar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblsuma1;
        private System.Windows.Forms.Label lblsuma2;
        private System.Windows.Forms.Label lblmult1;
        private System.Windows.Forms.Label lblmult2;
        private System.Windows.Forms.TextBox txtsuma1;
        private System.Windows.Forms.TextBox txtsuma2;
        private System.Windows.Forms.TextBox txtresultadosuma;
        private System.Windows.Forms.TextBox txtmult1;
        private System.Windows.Forms.TextBox txtmult2;
        private System.Windows.Forms.TextBox txtresultadomult;
    }
}

