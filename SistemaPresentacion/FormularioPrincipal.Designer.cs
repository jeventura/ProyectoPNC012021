
namespace SistemaPresentacion
{
    partial class FormularioPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FrmAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.ALibros = new System.Windows.Forms.ToolStripMenuItem();
            this.FrmConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.CLibro = new System.Windows.Forms.ToolStripMenuItem();
            this.FrmEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.ELibros = new System.Windows.Forms.ToolStripMenuItem();
            this.FrmModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.MLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.FrmReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.RLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.FrmReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.RELibros = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printPreviewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FrmAgregar,
            this.FrmConsultar,
            this.FrmEliminar,
            this.FrmModificar,
            this.FrmReporte,
            this.FrmReserva});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // FrmAgregar
            // 
            this.FrmAgregar.DoubleClickEnabled = true;
            this.FrmAgregar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ALibros});
            this.FrmAgregar.Name = "FrmAgregar";
            this.FrmAgregar.Size = new System.Drawing.Size(61, 20);
            this.FrmAgregar.Text = "Agregar";
            this.FrmAgregar.Click += new System.EventHandler(this.FrmAgregar_Click);
            // 
            // ALibros
            // 
            this.ALibros.DoubleClickEnabled = true;
            this.ALibros.Name = "ALibros";
            this.ALibros.Size = new System.Drawing.Size(106, 22);
            this.ALibros.Text = "Libros";
            this.ALibros.Click += new System.EventHandler(this.ALibroToolStriMenuItem_Click);
            // 
            // FrmConsultar
            // 
            this.FrmConsultar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CLibro});
            this.FrmConsultar.Name = "FrmConsultar";
            this.FrmConsultar.Size = new System.Drawing.Size(70, 20);
            this.FrmConsultar.Text = "Consultar";
            // 
            // CLibro
            // 
            this.CLibro.Name = "CLibro";
            this.CLibro.Size = new System.Drawing.Size(180, 22);
            this.CLibro.Text = "Libro";
            this.CLibro.Click += new System.EventHandler(this.CLibro_Click);
            // 
            // FrmEliminar
            // 
            this.FrmEliminar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ELibros});
            this.FrmEliminar.Name = "FrmEliminar";
            this.FrmEliminar.Size = new System.Drawing.Size(62, 20);
            this.FrmEliminar.Text = "Eliminar";
            this.FrmEliminar.Click += new System.EventHandler(this.FrmEliminar_Click);
            // 
            // ELibros
            // 
            this.ELibros.Name = "ELibros";
            this.ELibros.Size = new System.Drawing.Size(180, 22);
            this.ELibros.Text = "Libros";
            this.ELibros.Click += new System.EventHandler(this.ELibros_Click);
            // 
            // FrmModificar
            // 
            this.FrmModificar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MLibros});
            this.FrmModificar.Name = "FrmModificar";
            this.FrmModificar.Size = new System.Drawing.Size(70, 20);
            this.FrmModificar.Text = "Modificar";
            // 
            // MLibros
            // 
            this.MLibros.Name = "MLibros";
            this.MLibros.Size = new System.Drawing.Size(106, 22);
            this.MLibros.Text = "Libros";
            // 
            // FrmReporte
            // 
            this.FrmReporte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RLibros});
            this.FrmReporte.Name = "FrmReporte";
            this.FrmReporte.Size = new System.Drawing.Size(60, 20);
            this.FrmReporte.Text = "Reporte";
            // 
            // RLibros
            // 
            this.RLibros.Name = "RLibros";
            this.RLibros.Size = new System.Drawing.Size(180, 22);
            this.RLibros.Text = "Libros";
            this.RLibros.Click += new System.EventHandler(this.RLibros_Click);
            // 
            // FrmReserva
            // 
            this.FrmReserva.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RELibros});
            this.FrmReserva.Name = "FrmReserva";
            this.FrmReserva.Size = new System.Drawing.Size(59, 20);
            this.FrmReserva.Text = "Reserva";
            // 
            // RELibros
            // 
            this.RELibros.Name = "RELibros";
            this.RELibros.Size = new System.Drawing.Size(106, 22);
            this.RELibros.Text = "Libros";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.printToolStripButton,
            this.printPreviewToolStripButton,
            this.toolStripSeparator2,
            this.helpToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(784, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "Nuevo";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "Abrir";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "Guardar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "Imprimir";
            // 
            // printPreviewToolStripButton
            // 
            this.printPreviewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printPreviewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripButton.Image")));
            this.printPreviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printPreviewToolStripButton.Name = "printPreviewToolStripButton";
            this.printPreviewToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printPreviewToolStripButton.Text = "Vista previa de impresión";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "Ayuda";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 539);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(784, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormularioPrincipal";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton printPreviewToolStripButton;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem FrmAgregar;
        private System.Windows.Forms.ToolStripMenuItem ALibros;
        private System.Windows.Forms.ToolStripMenuItem FrmConsultar;
        private System.Windows.Forms.ToolStripMenuItem CLibro;
        private System.Windows.Forms.ToolStripMenuItem FrmEliminar;
        private System.Windows.Forms.ToolStripMenuItem ELibros;
        private System.Windows.Forms.ToolStripMenuItem FrmModificar;
        private System.Windows.Forms.ToolStripMenuItem MLibros;
        private System.Windows.Forms.ToolStripMenuItem FrmReporte;
        private System.Windows.Forms.ToolStripMenuItem RLibros;
        private System.Windows.Forms.ToolStripMenuItem FrmReserva;
        private System.Windows.Forms.ToolStripMenuItem RELibros;
    }
}



