namespace SIGEV.Vista
{
    partial class FormUbicacion
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
            this.txtEstante = new System.Windows.Forms.TextBox();
            this.txtFila = new System.Windows.Forms.TextBox();
            this.txtColumna = new System.Windows.Forms.NumericUpDown();
            this.dgvUbicaciones = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Númerofila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtColumna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUbicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEstante
            // 
            this.txtEstante.Location = new System.Drawing.Point(122, 35);
            this.txtEstante.Name = "txtEstante";
            this.txtEstante.Size = new System.Drawing.Size(164, 22);
            this.txtEstante.TabIndex = 0;
            // 
            // txtFila
            // 
            this.txtFila.Location = new System.Drawing.Point(122, 81);
            this.txtFila.Name = "txtFila";
            this.txtFila.Size = new System.Drawing.Size(164, 22);
            this.txtFila.TabIndex = 1;
            // 
            // txtColumna
            // 
            this.txtColumna.Location = new System.Drawing.Point(410, 35);
            this.txtColumna.Name = "txtColumna";
            this.txtColumna.Size = new System.Drawing.Size(135, 22);
            this.txtColumna.TabIndex = 2;
            // 
            // dgvUbicaciones
            // 
            this.dgvUbicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUbicaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Estante,
            this.Númerofila,
            this.columna});
            this.dgvUbicaciones.Location = new System.Drawing.Point(15, 167);
            this.dgvUbicaciones.Name = "dgvUbicaciones";
            this.dgvUbicaciones.RowHeadersWidth = 51;
            this.dgvUbicaciones.RowTemplate.Height = 24;
            this.dgvUbicaciones.Size = new System.Drawing.Size(553, 271);
            this.dgvUbicaciones.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(145, 129);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 32);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(364, 129);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 32);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Número Estante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numero Fila";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Columna";
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // Estante
            // 
            this.Estante.HeaderText = "Estante";
            this.Estante.MinimumWidth = 6;
            this.Estante.Name = "Estante";
            this.Estante.Width = 125;
            // 
            // Númerofila
            // 
            this.Númerofila.HeaderText = "Número Fila";
            this.Númerofila.MinimumWidth = 6;
            this.Númerofila.Name = "Númerofila";
            this.Númerofila.Width = 125;
            // 
            // columna
            // 
            this.columna.HeaderText = "Columna";
            this.columna.MinimumWidth = 6;
            this.columna.Name = "columna";
            this.columna.Width = 125;
            // 
            // FormUbicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvUbicaciones);
            this.Controls.Add(this.txtColumna);
            this.Controls.Add(this.txtFila);
            this.Controls.Add(this.txtEstante);
            this.Name = "FormUbicacion";
            this.Text = "SIGEV - Módulo de Ubicaciones";
            ((System.ComponentModel.ISupportInitialize)(this.txtColumna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUbicaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstante;
        private System.Windows.Forms.TextBox txtFila;
        private System.Windows.Forms.NumericUpDown txtColumna;
        private System.Windows.Forms.DataGridView dgvUbicaciones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Númerofila;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna;
    }
}