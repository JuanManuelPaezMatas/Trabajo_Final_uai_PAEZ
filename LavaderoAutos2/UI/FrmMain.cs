using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LavaderoAutos2.BusinessLogicalLayer;
using LavaderoAutos2.DataAccessLayer;
using LavaderoAutos2.Entities;
using LavaderoAutos2.UI;

namespace LavaderoAutos2
{
    public partial class FrmMain : Form
    {
        protected User User { get; set; }
        public FrmMain(User user)
        {
            InitializeComponent();
            this.User = user;   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                lblUser.Text = this.User.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void grdUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCrudCar_Click(object sender, EventArgs e)
        {
            try
            {
             FrmCRUDVehicles frmCRUDVehicles = new FrmCRUDVehicles();
             frmCRUDVehicles.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
