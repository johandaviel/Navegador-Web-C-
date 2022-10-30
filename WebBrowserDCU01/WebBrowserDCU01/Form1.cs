using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserDCU01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<String> Favorites = new List<string>();
        List<String> Historial = new List<string>();

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //boton atras
            webBrowser1.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //boton adelante
            webBrowser1.GoForward();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            //textbox
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //boton stop
            webBrowser1.Stop();
        }

        private void btnfavorites_Click(object sender, EventArgs e)
        {
            Favorites.Add(webBrowser1.Url.ToString());
            ActualizarLista();
        }

        private void ActualizarLista()
        {
            foreach(string elemento in Favorites)
            {
                toolStripComboBox1.Items.Add(elemento);
            }
        }


        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            //combo box
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripComboBox1.SelectedItem.ToString());
        }

        private void cmbHistorial_Click(object sender, EventArgs e)
        {

        }
    }
}
