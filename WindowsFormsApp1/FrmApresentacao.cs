using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmApresentacao : Form
    {
        public FrmApresentacao()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            try
            {

                progressBar1.Value = progressBar1.Value + 1;

            }
            catch
            {

                timer1.Enabled = false;
                this.Visible = false;
                FrmNick frm = new FrmNick();
                frm.ShowDialog();

               
            }

            

        }
    }
}
