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
    public partial class FrmPerg9 : Form
    {
        //Recebe a informação com o Nick e pontuação do usuario
        public FrmPerg9(string Nick, string Text)
        {
            InitializeComponent();
            label2.Text = Nick;
            label5.Text = Text;
        }

        //Button é chamado, atribui 1 ponto caso a reposta esteja correta e mostra a alternativa exata
        private void button1_Click(object sender, EventArgs e)
        {
            //Variavel auxiliar para contar e atribuir os pontos
            int Cont = 0;

            if (radioButton1.Checked)
            {

                radioButton5.Visible = true;
                Cont = Convert.ToInt16(label5.Text);
                Cont++;

            }
            if (radioButton2.Checked)
            {
                radioButton5.Visible = true;
                Cont = Convert.ToInt16(label5.Text);
            }
            if (radioButton3.Checked)
            {
                radioButton5.Visible = true;
                Cont = Convert.ToInt16(label5.Text);
                

            }
            if (radioButton4.Checked)
            {

                radioButton5.Visible = true;
                Cont = Convert.ToInt16(label5.Text);
               

            }

            label5.Text = Convert.ToString(Cont);
            button1.Visible = false;
            button2.Visible = true;
        }

        //Guarda Nick e Ponto do usuario e manda para proxima tela
        private void button2_Click(object sender, EventArgs e)
        {

            var form = new FrmPerg10(label2.Text, label5.Text);
            form.Show();
            this.Visible = false;

        }

       
    }
}
