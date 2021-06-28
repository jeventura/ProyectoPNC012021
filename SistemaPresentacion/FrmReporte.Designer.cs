
namespace SistemaPresentacion
{
    partial class FrmReporte
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
            this.DGVReporte = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVReporte
            // 
            this.DGVReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVReporte.Location = new System.Drawing.Point(12, 45);
            this.DGVReporte.Name = "DGVReporte";
            this.DGVReporte.RowTemplate.Height = 25;
            this.DGVReporte.Size = new System.Drawing.Size(776, 377);
            this.DGVReporte.TabIndex = 0;
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVReporte);
            this.Name = "FrmReporte";
            this.Text = "FrmReporte";
            ((System.ComponentModel.ISupportInitialize)(this.DGVReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVReporte;
    }
}