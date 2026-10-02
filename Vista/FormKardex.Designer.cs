namespace SIGEV.Vista
{
    partial class FormKardex
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
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtIdLote = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.dgvKardex = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrarMovimiento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKardex)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "",
            "Entrada",
            "Salida"});
            this.cmbTipo.Location = new System.Drawing.Point(191, 34);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(155, 24);
            this.cmbTipo.TabIndex = 0;
            // 
            // txtIdLote
            // 
            this.txtIdLote.Location = new System.Drawing.Point(191, 79);
            this.txtIdLote.Name = "txtIdLote";
            this.txtIdLote.Size = new System.Drawing.Size(155, 22);
            this.txtIdLote.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(191, 123);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(54, 22);
            this.txtCantidad.TabIndex = 2;
            // 
            // dgvKardex
            // 
            this.dgvKardex.BackgroundColor = System.Drawing.Color.White;
            this.dgvKardex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKardex.Location = new System.Drawing.Point(352, 20);
            this.dgvKardex.Name = "dgvKardex";
            this.dgvKardex.RowHeadersWidth = 51;
            this.dgvKardex.RowTemplate.Height = 24;
            this.dgvKardex.Size = new System.Drawing.Size(436, 206);
            this.dgvKardex.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de Movimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id Lote";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad a mover";
            // 
            // btnRegistrarMovimiento
            // 
            this.btnRegistrarMovimiento.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarMovimiento.Location = new System.Drawing.Point(16, 176);
            this.btnRegistrarMovimiento.Name = "btnRegistrarMovimiento";
            this.btnRegistrarMovimiento.Size = new System.Drawing.Size(110, 35);
            this.btnRegistrarMovimiento.TabIndex = 7;
            this.btnRegistrarMovimiento.Text = "Registrar";
            this.btnRegistrarMovimiento.UseVisualStyleBackColor = true;
            this.btnRegistrarMovimiento.Click += new System.EventHandler(this.btnRegistrarMovimiento_Click);
            // 
            // FormKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 232);
            this.Controls.Add(this.btnRegistrarMovimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKardex);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtIdLote);
            this.Controls.Add(this.cmbTipo);
            this.Name = "FormKardex";
            this.Text = "FormKardex";
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKardex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtIdLote;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.DataGridView dgvKardex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrarMovimiento;
    }
}