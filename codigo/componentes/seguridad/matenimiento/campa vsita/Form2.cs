using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace campa_vsita
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            navegador1.NavegadorMetConfigurar("tblbodegas", 4, 5);
        }
    }
}
