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
   
    public partial class RFID : Form
    {
        public RFID()
        {
            InitializeComponent();
        }

        private void txtIDManual_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RFID_Click(object sender, EventArgs e)
        {
            lblIDManual.Dispose();
        }
    }
}
