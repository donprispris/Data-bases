namespace AppCSBD {
  partial class FrmMenú {
    /// <summary>
    /// Variable del diseñador requerida.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén utilizando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido del método con el editor de código.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenú));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
      this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuSubProgsAlm = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuTransac = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuAlum = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.procesosToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(513, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // salirToolStripMenuItem
      // 
      this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir});
      this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
      this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
      this.salirToolStripMenuItem.Text = "Salir";
      // 
      // mnuSalir
      // 
      this.mnuSalir.Name = "mnuSalir";
      this.mnuSalir.Size = new System.Drawing.Size(96, 22);
      this.mnuSalir.Text = "Salir";
      this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
      // 
      // procesosToolStripMenuItem
      // 
      this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSubProgsAlm,
            this.mnuTransac});
      this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
      this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
      this.procesosToolStripMenuItem.Text = "Procesos";
      // 
      // mnuSubProgsAlm
      // 
      this.mnuSubProgsAlm.Name = "mnuSubProgsAlm";
      this.mnuSubProgsAlm.Size = new System.Drawing.Size(180, 22);
      this.mnuSubProgsAlm.Text = "Subprogs. alm.";
      this.mnuSubProgsAlm.Click += new System.EventHandler(this.mnuSubProgsAlm_Click);
      // 
      // mnuTransac
      // 
      this.mnuTransac.Name = "mnuTransac";
      this.mnuTransac.Size = new System.Drawing.Size(180, 22);
      this.mnuTransac.Text = "Transacciones";
      this.mnuTransac.Click += new System.EventHandler(this.mnuTransac_Click);
      // 
      // mnuAlum
      // 
      this.mnuAlum.Name = "mnuAlum";
      this.mnuAlum.Size = new System.Drawing.Size(152, 22);
      this.mnuAlum.Text = "Alumnos";
      // 
      // FrmMenú
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(513, 345);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "FrmMenú";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Menú principal";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mnuSalir;
    private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mnuAlum;
    private System.Windows.Forms.ToolStripMenuItem mnuSubProgsAlm;
    private System.Windows.Forms.ToolStripMenuItem mnuTransac;
  }
}

