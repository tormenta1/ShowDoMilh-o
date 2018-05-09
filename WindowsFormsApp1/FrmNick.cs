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
    public partial class FrmNick : Form
    {
        public FrmNick()
        {
            InitializeComponent();
           
        }


        //Button é chamado e manda a informação do Usuario para a prox tela
        private void button1_Click(object sender, EventArgs e)
        {

            var form = new FrmPerg1(textBox1.Text);
            form.Show();
            this.Visible = false;
           



        }

    }
}
