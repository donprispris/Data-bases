using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCSBD {
  public partial class FrmMenú : Form {
    public FrmMenú() {
      InitializeComponent();
    }

    private void mnuSalir_Click(object sender, EventArgs e) {
      Application.Exit();
    }

    private void mnuSubProgsAlm_Click(object sender, EventArgs e) {
      Procesos.FrmSubProgAlm fsp = new Procesos.FrmSubProgAlm();  //Abre la forma de los subprogs.
      fsp.Show();
    }

    private void mnuTransac_Click(object sender, EventArgs e) {
      Procesos.FrmTransac ft = new Procesos.FrmTransac();
      ft.Show();
    }

  }
}
