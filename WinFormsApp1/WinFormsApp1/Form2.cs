using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Абоненты");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show(
                "Оборудование");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
              "Активы");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
              "Crm");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
              "Событие");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
              "Отчет");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
              "Собрание");
        }
    }
}
