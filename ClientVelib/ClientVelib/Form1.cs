using ClientVelib.SOAPVelibReference;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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

        private void loadMap(Station station)
        {
            map.ShowCenter = false;
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new GMap.NET.PointLatLng(station.latitude, station.longitude);
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 10;
            map.DragButton = MouseButtons.Left;
            map.MouseWheelZoomEnabled = true;
            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker = new GMarkerGoogle(new GMap.NET.PointLatLng(station.latitude, station.longitude),
                GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red);
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Station station = client.GetStationData(currentCity,comboBox1.SelectedText);
            if (station != null)
            {
                int nbBikes = station.availableBikes;
                label2.Text = nbBikes.ToString();
                loadMap(station);
            }
            else
            {
                label2.Text = null;
            }
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
