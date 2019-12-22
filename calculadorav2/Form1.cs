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
    public partial class Form1 : Form
    {
        public int X;
        public int Y;
        public float resultadofinal;
     
     
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           
            lblRegraTres.Visible = false;
            txtBusca.SelectionLength = 0;
            pictureBox4.Visible = false;
            btninversamenteProporcional.Visible = false;
            btnDiretamenteProporcional.Visible = false;
         



            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(pictureBox3, "Alternar entre o modo noturno e claro.");
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(pictureBox4, "Sair");
            lblCalc.Focus();
            TextBox text = new TextBox();
            this.AcceptButton = btnBusca;

           
            txtBusca.Visible = true;
            lblResultado2.Text = Convert.ToString(resultadofinal);
      



        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void txtFechar_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            pictureBox1.Visible = false;

            pictureBox4.Visible = true;




        }








        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {


        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {


        }

        private void lblCalc_MouseMove(object sender, MouseEventArgs e)
        {





        }

        private void lblCalc_MouseLeave(object sender, EventArgs e)
        {




        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {



        }



        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox1.Visible = true;
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            FormInversoProporcional formInversoProporcional = new FormInversoProporcional();
            formInversoProporcional.Close();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            txtBusca.Text = "";
        }

        private void textBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            textBox1.Visible = false;
            textBox1.Enabled = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Form1 form1 = new Form1();
            if (e.Button != MouseButtons.Left) return;
            form1.X = this.Left - MousePosition.X;
            form1.Y = this.Top - MousePosition.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Form1 form1 = new Form1();
            if (e.Button != MouseButtons.Left) return;
            this.Left = form1.X + MousePosition.X;
            this.Top = form1.Y + MousePosition.Y;
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            string busca;
            busca = txtBusca.Text.ToLower();
            
            switch (busca)
            {
                case "regra de três":

                    btnDiretamenteProporcional.Visible = true;
                    btninversamenteProporcional.Visible = true;
                   
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            FormProporcional formProporcional = new FormProporcional();

            this.Hide();
            formProporcional.Show();
            this.Hide();
            
            
        }

        private void inversamenteProporcional_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            FormInversoProporcional formInversoProporcional = new FormInversoProporcional();
            
            
            this.Hide();

            formInversoProporcional.Show();
            
        }
    }
    
}
