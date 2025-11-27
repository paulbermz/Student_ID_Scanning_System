using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_ID_Scanning_System
{
    public partial class Barcode : Form
    {
        public Barcode()
        {
            InitializeComponent();
        }

        private void txtIDManual_Click(object sender, EventArgs e)
        {
           lblIDManual.Dispose();
        }

        private void Barcode_Load(object sender, EventArgs e)
        {

        }
    }
}
