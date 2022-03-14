namespace Control_de_pagos__lab7_
{
    partial class OpcioneProyecto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuotasDeMantenimientoMasAltasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuotasDeMantenimientoMasBajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuotasMasAltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 419);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.White;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuotasDeMantenimientoMasAltasToolStripMenuItem,
            this.cuotasDeMantenimientoMasBajasToolStripMenuItem,
            this.cuotasMasAltaToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // cuotasDeMantenimientoMasAltasToolStripMenuItem
            // 
            this.cuotasDeMantenimientoMasAltasToolStripMenuItem.Name = "cuotasDeMantenimientoMasAltasToolStripMenuItem";
            this.cuotasDeMantenimientoMasAltasToolStripMenuItem.Size = new System.Drawing.Size(333, 26);
            this.cuotasDeMantenimientoMasAltasToolStripMenuItem.Text = "Cuotas de mantenimiento mas altas";
            this.cuotasDeMantenimientoMasAltasToolStripMenuItem.Click += new System.EventHandler(this.cuotasDeMantenimientoMasAltasToolStripMenuItem_Click);
            // 
            // cuotasDeMantenimientoMasBajasToolStripMenuItem
            // 
            this.cuotasDeMantenimientoMasBajasToolStripMenuItem.Name = "cuotasDeMantenimientoMasBajasToolStripMenuItem";
            this.cuotasDeMantenimientoMasBajasToolStripMenuItem.Size = new System.Drawing.Size(333, 26);
            this.cuotasDeMantenimientoMasBajasToolStripMenuItem.Text = "Cuotas de mantenimiento mas bajas";
            // 
            // cuotasMasAltaToolStripMenuItem
            // 
            this.cuotasMasAltaToolStripMenuItem.Name = "cuotasMasAltaToolStripMenuItem";
            this.cuotasMasAltaToolStripMenuItem.Size = new System.Drawing.Size(333, 26);
            this.cuotasMasAltaToolStripMenuItem.Text = "Cuotas mas alta";
            // 
            // OpcioneProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OpcioneProyecto";
            this.Text = "OpcioneProyecto";
            this.Load += new System.EventHandler(this.OpcioneProyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuotasDeMantenimientoMasAltasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuotasDeMantenimientoMasBajasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuotasMasAltaToolStripMenuItem;
    }
}