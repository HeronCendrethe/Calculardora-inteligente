using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadorav2
{
    public partial class FormInversoProporcional : Form
    {
        public int Verifica;
        public float resultado;
        public FormInversoProporcional()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegraTresInversa regraTresInversa = new RegraTresInversa();
            regraTresInversa.primeiroFator = Convert.ToInt32(txtFator1Inverso.Text);
            regraTresInversa.segundoFator = Convert.ToInt32(txtFator2Inverso.Text);
            regraTresInversa.terceiroFator = Convert.ToInt32(txtFator3Inverso.Text);

            float x = 0;
            
            regraTresInversa.x = (regraTresInversa.segundoFator * regraTresInversa.primeiroFator) / ( regraTresInversa.terceiroFator);
        
            Form1 form1 = new Form1();
             Verifica = 1;
            form1.resultadofinal = regraTresInversa.x;
          
            this.Close();
            form1.Show();
            

        }
    }
}
