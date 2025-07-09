namespace LavaderoAutos2.UI
{
    partial class FrmSearchVehicle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbSearchVehicle = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbSearchVehicle
            // 
            this.cmbSearchVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchVehicle.FormattingEnabled = true;
            this.cmbSearchVehicle.Location = new System.Drawing.Point(12, 27);
            this.cmbSearchVehicle.Name = "cmbSearchVehicle";
            this.cmbSearchVehicle.Size = new System.Drawing.Size(767, 21);
            this.cmbSearchVehicle.TabIndex = 0;
            // 
            // FrmSearchVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 76);
            this.Controls.Add(this.cmbSearchVehicle);
            this.Name = "FrmSearchVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.FrmSearchVehicle_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSearchVehicle;
    }
}