using LavaderoAutos2.Entities;
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
    public partial class FrmCRUDVehicles : Form
    {
        public FrmCRUDVehicles()
        {
            InitializeComponent();
        }

        private void FrmCRUDVehicles_Load(object sender, EventArgs e)
        {
            try
            {
                cmbType.DataSource= Enum.GetValues(typeof(VehicleType));

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {




        }

        private Vehicle getVehicle()
        {
            try
            {
                Vehicle vehicle = new Vehicle();
                vehicle.Name=txtName.Text;
                vehicle.Brand=txtBrand.Text;
                vehicle.Year =int.Parse(txtYear.Text);
                vehicle.VehicleType=(VehicleType)cmbType.SelectedItem;

                //terminar la funcion
                //poner imagenes en iconos
                // crear dal para vehicle
                return vehicle;

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void setVehicle(Vehicle vehicle)
        {
            try
            {
                if (vehicle == null)
                {
                    return;
                }
                txtName.Text=vehicle.Name;
                txtBrand.Text=vehicle.Brand;
                txtYear.Text = vehicle.Year.ToString();
                cmbType.SelectedItem=vehicle.VehicleType;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
