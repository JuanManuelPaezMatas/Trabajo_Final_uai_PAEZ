using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LavaderoAutos2.Services;

namespace LavaderoAutos2.UI
{
    public partial class FrmLanguage : Form, IidiomaObserver
    {
        public FrmLanguage()
        {
            InitializeComponent();
        }

        private void FrmLanguage_Load(object sender, EventArgs e)
        {
            try
            {
                List<string> list = new List<string>();
                list.Add("ES");
                list.Add("EN");
                list.Add("DE");
                cmbLanguage.DataSource = list;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Internationalization.Instancia.CambiarIdioma(cmbLanguage.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void CambiarIdioma(string idioma)
        {
            this.Text="Idioma "+ idioma;

        }
    }
}
