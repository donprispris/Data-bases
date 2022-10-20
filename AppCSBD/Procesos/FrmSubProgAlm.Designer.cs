namespace AppCSBD.Procesos {
  partial class FrmSubProgAlm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.btnProc = new System.Windows.Forms.Button();
      this.btnFunc = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnProc
      // 
      this.btnProc.Location = new System.Drawing.Point(90, 54);
      this.btnProc.Name = "btnProc";
      this.btnProc.Size = new System.Drawing.Size(236, 49);
      this.btnProc.TabIndex = 0;
      this.btnProc.Text = "Procedimiento: dada una materia (par.) cuenta la cantidad de alumnos que la lleva" +
    "n";
      this.btnProc.UseVisualStyleBackColor = true;
      this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
      // 
      // btnFunc
      // 
      this.btnFunc.Location = new System.Drawing.Point(90, 142);
      this.btnFunc.Name = "btnFunc";
      this.btnFunc.Size = new System.Drawing.Size(236, 55);
      this.btnFunc.TabIndex = 1;
      this.btnFunc.Text = "Función: dado un alumno (par.) cuenta la cantidad de materias que lleva";
      this.btnFunc.UseVisualStyleBackColor = true;
      this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
      // 
      // FrmSubProgAlm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(441, 316);
      this.Controls.Add(this.btnFunc);
      this.Controls.Add(this.btnProc);
      this.Name = "FrmSubProgAlm";
      this.Text = "Ejecución de subprogramas almacenados";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnProc;
    private System.Windows.Forms.Button btnFunc;
  }
}