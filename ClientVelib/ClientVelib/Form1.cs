using ClientVelib.SOAPVelibReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientVelib
{
    public partial class Form1 : Form
    {
        private SOAPVelibReference.VelibOperationsClient client;
        private string currentCity;

        public VelibOperationsClient Client { get => client; set => client = value; }

        public Form1()
        {
            InitializeComponent();
            client = new VelibOperationsClient();
            comboBox2.Items.Clear();
            foreach (var item in Client.GetContracts())
            {
                comboBox2.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nbBikes = client.GetNbAvailableBikes(currentCity, (string)comboBox1.SelectedItem);
            label2.Text = nbBikes.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentCity = comboBox2.Text;

            if (currentCity != "")
            {
                comboBox1.Items.Clear();
                foreach (var item in Client.GetStations(currentCity)) { 
                    comboBox1.Items.Add(item);
                }
            }
           
        }
    }
}
