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


    public partial class FrmCRUDVehicles : Form, IidiomaObserver
    {
        public FrmCRUDVehicles()
        {
            InitializeComponent();
        }

        private void FrmCRUDVehicles_Load(object sender, EventArgs e)
        {
            try
            {
                CambiarIdioma(Internationalization.Instancia.Idioma);
                cmbType.DataSource= Enum.GetValues(typeof(VehicleType));
                this.cleanForm();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.cleanForm();



        }

        private Vehicle getVehicle()
        {
            try
            {
                Vehicle vehicle = new Vehicle();
                vehicle.Name=txtName.Text;
                vehicle.Brand=txtBrand.Text;
                
                if (txtYear.Text!="")
                vehicle.Year =int.Parse(txtYear.Text);

                vehicle.VehicleType=(VehicleType)cmbType.SelectedItem;

                
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

        private void cleanForm() {
            txtBrand.Text = "";
            txtName.Text = "";
            txtYear.Text = "";
            cmbType.SelectedIndex = 0;

        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Vehicle vehicle;
                vehicle = getVehicle();
                VehicleService vehicleService = new VehicleService();
                vehicleService.createVecicle(vehicle);
                MessageBox.Show("El vehiculo ha sido creado ");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void CambiarIdioma(string idioma)
        {



            this.Text = "Vehiculos " + idioma;


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSearchVehicle form= new FrmSearchVehicle();
                Internationalization.Instancia.suscribir(form);
                form.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
