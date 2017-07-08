namespace ISWGestAcaApp
{
    partial class ventanaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaLogin));
            this.botonAdmin = new System.Windows.Forms.Button();
            this.botonEmple = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.botonCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonAdmin
            // 
            this.botonAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botonAdmin.AutoSize = true;
            this.botonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAdmin.Location = new System.Drawing.Point(96, 182);
            this.botonAdmin.Name = "botonAdmin";
            this.botonAdmin.Size = new System.Drawing.Size(181, 83);
            this.botonAdmin.TabIndex = 0;
            this.botonAdmin.Text = "Administrador";
            this.botonAdmin.UseVisualStyleBackColor = true;
            this.botonAdmin.Click += new System.EventHandler(this.botonAdmin_Click);
            // 
            // botonEmple
            // 
            this.botonEmple.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botonEmple.AutoSize = true;
            this.botonEmple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEmple.Location = new System.Drawing.Point(305, 182);
            this.botonEmple.Name = "botonEmple";
            this.botonEmple.Size = new System.Drawing.Size(181, 83);
            this.botonEmple.TabIndex = 1;
            this.botonEmple.Text = "Empleado";
            this.botonEmple.UseVisualStyleBackColor = true;
            this.botonEmple.Click += new System.EventHandler(this.botonEmple_Click_1);
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(212, 117);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(143, 20);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Identificarse como:";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            // 
            // botonCerrar
            // 
            this.botonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botonCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCerrar.Location = new System.Drawing.Point(470, 418);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(102, 31);
            this.botonCerrar.TabIndex = 3;
            this.botonCerrar.Text = "Cerrar";
            this.botonCerrar.UseVisualStyleBackColor = true;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // ventanaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.botonCerrar);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.botonEmple);
            this.Controls.Add(this.botonAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "ventanaLogin";
            this.Text = "Login-GestAcaMapache";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ventanaLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAdmin;
        private System.Windows.Forms.Button botonEmple;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button botonCerrar;
    }
}