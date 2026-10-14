namespace Unidad_4.Practicas
{
    partial class Estudian_tes
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
            this.components = new System.ComponentModel.Container();
            this.lblguardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.lblcurso = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtcurso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblguardar
            // 
            this.lblguardar.BackColor = System.Drawing.Color.DarkGray;
            this.lblguardar.Location = new System.Drawing.Point(87, 112);
            this.lblguardar.Name = "lblguardar";
            this.lblguardar.Size = new System.Drawing.Size(100, 35);
            this.lblguardar.TabIndex = 0;
            this.lblguardar.Text = "Guardar";
            this.lblguardar.UseVisualStyleBackColor = false;
            this.lblguardar.Click += new System.EventHandler(this.lblguardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(19, 20);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Location = new System.Drawing.Point(19, 51);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(32, 13);
            this.lbledad.TabIndex = 2;
            this.lbledad.Text = "Edad";
            // 
            // lblcurso
            // 
            this.lblcurso.AutoSize = true;
            this.lblcurso.Location = new System.Drawing.Point(19, 77);
            this.lblcurso.Name = "lblcurso";
            this.lblcurso.Size = new System.Drawing.Size(34, 13);
            this.lblcurso.TabIndex = 3;
            this.lblcurso.Text = "Curso";
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.Gray;
            this.txtnombre.Location = new System.Drawing.Point(87, 13);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 4;
            // 
            // txtedad
            // 
            this.txtedad.BackColor = System.Drawing.Color.Gray;
            this.txtedad.Location = new System.Drawing.Point(87, 44);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 20);
            this.txtedad.TabIndex = 5;
            // 
            // txtcurso
            // 
            this.txtcurso.BackColor = System.Drawing.Color.Gray;
            this.txtcurso.Location = new System.Drawing.Point(87, 70);
            this.txtcurso.Name = "txtcurso";
            this.txtcurso.Size = new System.Drawing.Size(100, 20);
            this.txtcurso.TabIndex = 6;
            // 
            // Estudian_tes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 182);
            this.Controls.Add(this.txtcurso);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblcurso);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblguardar);
            this.Name = "Estudian_tes";
            this.Text = "Estudian_tes";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lblguardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtcurso;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblcurso;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lblnombre;
    }
}