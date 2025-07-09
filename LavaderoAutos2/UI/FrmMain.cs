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
using LavaderoAutos2.Services;

namespace LavaderoAutos2
{
    public partial class FrmMain : Form, IidiomaObserver
    {
        protected User User { get; set; }
        protected IFormObserver _observer {  get; set; }
        public FrmMain(User user)
        {
            InitializeComponent();
            this.User = user;   
            
        }

        public void addObserver(IFormObserver observer)
        {
            this._observer = observer;
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
                
                Internationalization.Instancia.suscribir(frmCRUDVehicles);
             frmCRUDVehicles.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CambiarIdioma(string idioma)
        {
            this.Text = "Principal " + idioma;

        }

        private void mnuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            try
            {
                FrmLanguage f = new FrmLanguage();  
                Internationalization.Instancia.suscribir(f);
                f.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                this._observer.OnFormClosed();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message  );
               
            }
        }
    }
}
