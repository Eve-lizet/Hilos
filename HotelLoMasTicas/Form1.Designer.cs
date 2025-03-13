namespace HotelLoMasTicas
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
            this.titulo1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.crearcuenta = new System.Windows.Forms.Button();
            this.iniciarsesion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulo1
            // 
            this.titulo1.AutoSize = true;
            this.titulo1.Font = new System.Drawing.Font("Engravers MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo1.Location = new System.Drawing.Point(4, 13);
            this.titulo1.Name = "titulo1";
            this.titulo1.Size = new System.Drawing.Size(241, 28);
            this.titulo1.TabIndex = 0;
            this.titulo1.Text = "HoltelBook";
            this.titulo1.Click += new System.EventHandler(this.titulo1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.titulo1);
            this.panel1.Location = new System.Drawing.Point(283, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 55);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // crearcuenta
            // 
            this.crearcuenta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.crearcuenta.Location = new System.Drawing.Point(299, 298);
            this.crearcuenta.Name = "crearcuenta";
            this.crearcuenta.Size = new System.Drawing.Size(217, 48);
            this.crearcuenta.TabIndex = 2;
            this.crearcuenta.Text = "Crear cuenta";
            this.crearcuenta.UseVisualStyleBackColor = false;
            this.crearcuenta.Click += new System.EventHandler(this.crearcuenta_Click);
            // 
            // iniciarsesion
            // 
            this.iniciarsesion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.iniciarsesion.Location = new System.Drawing.Point(222, 352);
            this.iniciarsesion.Name = "iniciarsesion";
            this.iniciarsesion.Size = new System.Drawing.Size(367, 44);
            this.iniciarsesion.TabIndex = 3;
            this.iniciarsesion.Text = "Iniciar Sesión";
            this.iniciarsesion.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iniciarsesion);
            this.Controls.Add(this.crearcuenta);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titulo1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button crearcuenta;
        private System.Windows.Forms.Button iniciarsesion;
    }
}

