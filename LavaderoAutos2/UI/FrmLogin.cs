using LavaderoAutos2.BusinessLogicalLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LavaderoAutos2.Entities;
using System.Net.Configuration;
using LavaderoAutos2.Services;

namespace LavaderoAutos2.UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("¿Estas seguro?", "Mensaje de atencion",MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                            this.Close();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                UserService service = new UserService();
                                
                User user1 = service.login(txtUsuario.Text, txtPassword.Text);
                this.Hide();
                
                FrmMain frm = new FrmMain(user1);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally {
            Cursor = Cursors.Default;
            }
        }
    }
}
