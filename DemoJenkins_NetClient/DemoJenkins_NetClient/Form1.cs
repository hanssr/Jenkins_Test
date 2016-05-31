using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoJenkins_NetClient.BussLog;

namespace DemoJenkins_NetClient
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox3.Text);
            int suma = CalculadoraFacade.Suma(a, b);
            textBox2.Text = suma.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox3.Text);
            int resta = CalculadoraFacade.Resta(a, b);
            textBox2.Text = resta.ToString();
        }
    }
}
