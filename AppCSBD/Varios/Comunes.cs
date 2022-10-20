using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCSBD.Varios {
  //Aquí se colocan rutinas (y variables) de uso común en todo el proyecto.

  class Comunes {

    /* Agrega en un ComboBox (primer parámetro), los datos que están en un DataSet
       (segundo parámetro), en la tabla y columna dadas (tercer y cuarto parámetros).
       Los datos se agregan sin repetición.
       NOTA: se debe la biblioteca: System.Windows.Forms (tal como está líneas más arriba),
       para que se pueda usar el tipo: ComboBox.
    */
    public void cargaCombo(ComboBox cbo, DataSet ds,
      String tabla, String col) {
        DataTable tabResul;

        cbo.Items.Clear();
        //La columna 'col' es la que tiene los datos que se agregarán al combo.
        tabResul = ds.Tables[tabla];
        foreach (DataRow fila in tabResul.Rows)
          if (!cbo.Items.Contains(fila[col].ToString().Trim()))
            cbo.Items.Add(fila[col].ToString().Trim());
    }

  }
}
