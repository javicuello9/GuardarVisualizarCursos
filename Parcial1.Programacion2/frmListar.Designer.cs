namespace Parcial1.Programacion2
{
    partial class frmListar
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
            this.dgvAltas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAltas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAltas
            // 
            this.dgvAltas.AllowUserToAddRows = false;
            this.dgvAltas.AllowUserToDeleteRows = false;
            this.dgvAltas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAltas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAltas.Location = new System.Drawing.Point(0, 0);
            this.dgvAltas.Name = "dgvAltas";
            this.dgvAltas.ReadOnly = true;
            this.dgvAltas.Size = new System.Drawing.Size(729, 358);
            this.dgvAltas.TabIndex = 0;
            // 
            // frmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 358);
            this.Controls.Add(this.dgvAltas);
            this.Name = "frmListar";
            this.Text = "Listado de Altas";
            this.Load += new System.EventHandler(this.frmListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAltas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAltas;
    }
}