
namespace SistemaPresentacion
{
    partial class FrmReservar
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
            this.lblFechaDevolucion = new System.Windows.Forms.Label();
            this.DTPFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.lblDUIen = new System.Windows.Forms.Label();
            this.tbDUIencargado = new System.Windows.Forms.TextBox();
            this.lblDUIprof = new System.Windows.Forms.Label();
            this.tbDUIprofesor = new System.Windows.Forms.TextBox();
            this.btnReservar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.AutoSize = true;
            this.lblFechaDevolucion.Location = new System.Drawing.Point(195, 97);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(101, 15);
            this.lblFechaDevolucion.TabIndex = 0;
            this.lblFechaDevolucion.Text = "Fecha Devolucion";
            // 
            // DTPFechaDevolucion
            // 
            this.DTPFechaDevolucion.Location = new System.Drawing.Point(340, 97);
            this.DTPFechaDevolucion.Name = "DTPFechaDevolucion";
            this.DTPFechaDevolucion.Size = new System.Drawing.Size(200, 23);
            this.DTPFechaDevolucion.TabIndex = 1;
            // 
            // lblDUIen
            // 
            this.lblDUIen.AutoSize = true;
            this.lblDUIen.Location = new System.Drawing.Point(195, 164);
            this.lblDUIen.Name = "lblDUIen";
            this.lblDUIen.Size = new System.Drawing.Size(85, 15);
            this.lblDUIen.TabIndex = 2;
            this.lblDUIen.Text = "DUI encargado";
            // 
            // tbDUIencargado
            // 
            this.tbDUIencargado.Location = new System.Drawing.Point(340, 164);
            this.tbDUIencargado.Name = "tbDUIencargado";
            this.tbDUIencargado.Size = new System.Drawing.Size(200, 23);
            this.tbDUIencargado.TabIndex = 3;
            // 
            // lblDUIprof
            // 
            this.lblDUIprof.AutoSize = true;
            this.lblDUIprof.Location = new System.Drawing.Point(195, 232);
            this.lblDUIprof.Name = "lblDUIprof";
            this.lblDUIprof.Size = new System.Drawing.Size(73, 15);
            this.lblDUIprof.TabIndex = 4;
            this.lblDUIprof.Text = "DUI profesor";
            // 
            // tbDUIprofesor
            // 
            this.tbDUIprofesor.Location = new System.Drawing.Point(340, 224);
            this.tbDUIprofesor.Name = "tbDUIprofesor";
            this.tbDUIprofesor.Size = new System.Drawing.Size(200, 23);
            this.tbDUIprofesor.TabIndex = 5;
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(340, 340);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(75, 23);
            this.btnReservar.TabIndex = 6;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            // 
            // FrmReservar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.tbDUIprofesor);
            this.Controls.Add(this.lblDUIprof);
            this.Controls.Add(this.tbDUIencargado);
            this.Controls.Add(this.lblDUIen);
            this.Controls.Add(this.DTPFechaDevolucion);
            this.Controls.Add(this.lblFechaDevolucion);
            this.Name = "FrmReservar";
            this.Text = "FrmReservar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaDevolucion;
        private System.Windows.Forms.DateTimePicker DTPFechaDevolucion;
        private System.Windows.Forms.Label lblDUIen;
        private System.Windows.Forms.TextBox tbDUIencargado;
        private System.Windows.Forms.Label lblDUIprof;
        private System.Windows.Forms.TextBox tbDUIprofesor;
        private System.Windows.Forms.Button btnReservar;
    }
}