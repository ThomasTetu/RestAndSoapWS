using Client.MathsOperationsReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        MathsOperationsClient basicClient;
        MathsOperationsClient WSClient;
        int result;
        public Form1()
        {
            InitializeComponent();
            label1.Text = null;
            basicClient = new MathsOperationsClient("MathsOperations");
            WSClient = new MathsOperationsClient("MathsOperationsWS");
            result = 0;
        }

        private void addButtonBasic_Click(object sender, EventArgs e)
        {
            result = basicClient.Add(int.Parse(NumberOne.Text), int.Parse(NumberTwo.Text));
            label1.Text = result.ToString();
        }

        private void SubButtonBasic_Click(object sender, EventArgs e)
        {
            result = basicClient.Sub(int.Parse(NumberOne.Text), int.Parse(NumberTwo.Text));
            label1.Text = result.ToString();
        }

        private void MultButtonBasic_Click(object sender, EventArgs e)
        {
            result = basicClient.Multiply(int.Parse(NumberOne.Text), int.Parse(NumberTwo.Text));
            label1.Text = result.ToString();
        }

        private void DivButtonBasic_Click(object sender, EventArgs e)
        {
            result = basicClient.Divide(int.Parse(NumberOne.Text), int.Parse(NumberTwo.Text));
            label1.Text = result.ToString();
        }

        private void AddButtonWS_Click(object sender, EventArgs e)
        {
            result = WSClient.Add(int.Parse(NumberOne.Text), int.Parse(NumberTwo.Text));
            label1.Text = result.ToString();
        }

        private void SubButtonWS_Click(object sender, EventArgs e)
        {
            result = WSClient.Sub(int.Parse(NumberOne.Text), int.Parse(NumberTwo.Text));
            label1.Text = result.ToString();
        }

        private void MultButtonWS_Click(object sender, EventArgs e)
        {
            result = WSClient.Multiply(int.Parse(NumberOne.Text), int.Parse(NumberTwo.Text));
            label1.Text = result.ToString();
        }

        private void DivButtonWS_Click(object sender, EventArgs e)
        {
            result = WSClient.Divide(int.Parse(NumberOne.Text), int.Parse(NumberTwo.Text));
            label1.Text = result.ToString();
        }
    }
}
