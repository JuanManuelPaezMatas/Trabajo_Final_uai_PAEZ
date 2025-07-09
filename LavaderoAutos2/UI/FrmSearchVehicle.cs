using LavaderoAutos2.Entities;
using LavaderoAutos2.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LavaderoAutos2.UI
{
    public partial class FrmSearchVehicle : Form, IidiomaObserver
    {
        public FrmSearchVehicle()
        {
            InitializeComponent();
        }

        public void CambiarIdioma(string idioma)
        {
            throw new NotImplementedException();
        }

        private void FrmSearchVehicle_Load(object sender, EventArgs e)
        {
            try
            {
                VehicleService service= new VehicleService(); 
                cmbSearchVehicle.DataSource=service.getAllVehicles();
                cmbSearchVehicle.DisplayMember="Name";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
