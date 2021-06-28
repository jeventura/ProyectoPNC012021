
namespace SistemaPresentacion
{
    partial class FrmReservas
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
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(237, 138);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(105, 43);
            this.btnReservar.TabIndex = 0;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(411, 138);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(115, 43);
            this.btnDevolver.TabIndex = 1;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(271, 52);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(219, 23);
            this.tbISBN.TabIndex = 2;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(216, 55);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 15);
            this.lblISBN.TabIndex = 3;
            this.lblISBN.Text = "ISBN";
            // 
            // FrmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 267);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.tbISBN);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.btnReservar);
            this.Name = "FrmReservas";
            this.Text = "FrmReservas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.Label lblISBN;
    }
}