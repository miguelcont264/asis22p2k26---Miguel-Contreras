using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capa_vista_Mantenimiento2k26
{
    public partial class Frmmantenimieto_bodegas : Form
    {
        public Frmmantenimieto_bodegas()
        {
            InitializeComponent();
            navegador1.NavegadorMetConfigurar("tblbodegas", 4, 5);
        }
    }
}
