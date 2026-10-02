namespace SIGEV.Vista
{
    partial class FormMenu
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
            this.btnUbicaciones = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnLotes = new System.Windows.Forms.Button();
            this.btnKardex = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblUsuarioLogueado = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUbicaciones
            // 
            this.btnUbicaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(73)))), ((int)(((byte)(101)))));
            this.btnUbicaciones.FlatAppearance.BorderSize = 0;
            this.btnUbicaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbicaciones.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnUbicaciones.ForeColor = System.Drawing.Color.White;
            this.btnUbicaciones.Location = new System.Drawing.Point(427, 87);
            this.btnUbicaciones.Name = "btnUbicaciones";
            this.btnUbicaciones.Size = new System.Drawing.Size(197, 38);
            this.btnUbicaciones.TabIndex = 0;
            this.btnUbicaciones.Text = " Ubicacion";
            this.btnUbicaciones.UseVisualStyleBackColor = false;
            this.btnUbicaciones.Click += new System.EventHandler(this.btnUbicaciones_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(73)))), ((int)(((byte)(101)))));
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Location = new System.Drawing.Point(27, 87);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(197, 38);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnLotes
            // 
            this.btnLotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(73)))), ((int)(((byte)(101)))));
            this.btnLotes.FlatAppearance.BorderSize = 0;
            this.btnLotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLotes.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnLotes.ForeColor = System.Drawing.Color.White;
            this.btnLotes.Location = new System.Drawing.Point(27, 229);
            this.btnLotes.Name = "btnLotes";
            this.btnLotes.Size = new System.Drawing.Size(197, 40);
            this.btnLotes.TabIndex = 2;
            this.btnLotes.Text = "Lotes";
            this.btnLotes.UseVisualStyleBackColor = false;
            this.btnLotes.Click += new System.EventHandler(this.btnLotes_Click);
            // 
            // btnKardex
            // 
            this.btnKardex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(73)))), ((int)(((byte)(101)))));
            this.btnKardex.FlatAppearance.BorderSize = 0;
            this.btnKardex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKardex.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnKardex.ForeColor = System.Drawing.Color.White;
            this.btnKardex.Location = new System.Drawing.Point(427, 229);
            this.btnKardex.Name = "btnKardex";
            this.btnKardex.Size = new System.Drawing.Size(197, 40);
            this.btnKardex.TabIndex = 3;
            this.btnKardex.Text = "Kardex";
            this.btnKardex.UseVisualStyleBackColor = false;
            this.btnKardex.Click += new System.EventHandler(this.btnKardex_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCerrarSesion.Location = new System.Drawing.Point(523, 13);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(197, 33);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblUsuarioLogueado
            // 
            this.lblUsuarioLogueado.AutoSize = true;
            this.lblUsuarioLogueado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogueado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblUsuarioLogueado.Location = new System.Drawing.Point(60, 18);
            this.lblUsuarioLogueado.Name = "lblUsuarioLogueado";
            this.lblUsuarioLogueado.Size = new System.Drawing.Size(75, 23);
            this.lblUsuarioLogueado.TabIndex = 5;
            this.lblUsuarioLogueado.Text = "Usuario:";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblUsuarioLogueado);
            this.panelHeader.Controls.Add(this.btnCerrarSesion);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(782, 65);
            this.panelHeader.TabIndex = 7;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(782, 353);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnKardex);
            this.Controls.Add(this.btnLotes);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnUbicaciones);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUbicaciones;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnLotes;
        private System.Windows.Forms.Button btnKardex;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lblUsuarioLogueado;
        private System.Windows.Forms.Panel panelHeader;
    }
}