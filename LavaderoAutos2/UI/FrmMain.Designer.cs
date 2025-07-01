namespace LavaderoAutos2
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.btnCrudCar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grdServiciosActivas = new System.Windows.Forms.DataGridView();
            this.grdServiciosEspera = new System.Windows.Forms.DataGridView();
            this.lblUser = new System.Windows.Forms.Label();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdServiciosActivas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdServiciosEspera)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.SteelBlue;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCrudCar,
            this.toolStripMenuItem1});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(800, 40);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // btnCrudCar
            // 
            this.btnCrudCar.Image = ((System.Drawing.Image)(resources.GetObject("btnCrudCar.Image")));
            this.btnCrudCar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCrudCar.Name = "btnCrudCar";
            this.btnCrudCar.Size = new System.Drawing.Size(44, 36);
            this.btnCrudCar.Click += new System.EventHandler(this.btnCrudCar_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(91, 36);
            this.toolStripMenuItem1.Text = "CrudServicios";
            // 
            // grdServiciosActivas
            // 
            this.grdServiciosActivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdServiciosActivas.Location = new System.Drawing.Point(12, 81);
            this.grdServiciosActivas.Name = "grdServiciosActivas";
            this.grdServiciosActivas.Size = new System.Drawing.Size(776, 184);
            this.grdServiciosActivas.TabIndex = 1;
            // 
            // grdServiciosEspera
            // 
            this.grdServiciosEspera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdServiciosEspera.Location = new System.Drawing.Point(12, 271);
            this.grdServiciosEspera.Name = "grdServiciosEspera";
            this.grdServiciosEspera.Size = new System.Drawing.Size(776, 150);
            this.grdServiciosEspera.TabIndex = 2;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(12, 52);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(51, 20);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "label1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.grdServiciosEspera);
            this.Controls.Add(this.grdServiciosActivas);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdServiciosActivas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdServiciosEspera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem btnCrudCar;
        private System.Windows.Forms.DataGridView grdServiciosActivas;
        private System.Windows.Forms.DataGridView grdServiciosEspera;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label lblUser;
    }
}

