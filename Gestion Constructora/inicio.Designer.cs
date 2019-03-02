namespace Gestion_Constructora
{
    partial class inicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.obrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMSitioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMDeTareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obrasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(750, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // obrasToolStripMenuItem
            // 
            this.obrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMSitioToolStripMenuItem,
            this.aBMDeTareaToolStripMenuItem});
            this.obrasToolStripMenuItem.Name = "obrasToolStripMenuItem";
            this.obrasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.obrasToolStripMenuItem.Text = "Obras";
            // 
            // aBMSitioToolStripMenuItem
            // 
            this.aBMSitioToolStripMenuItem.Name = "aBMSitioToolStripMenuItem";
            this.aBMSitioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aBMSitioToolStripMenuItem.Text = "ABM de Sitio";
            this.aBMSitioToolStripMenuItem.Click += new System.EventHandler(this.aBMSitioToolStripMenuItem_Click);
            // 
            // aBMDeTareaToolStripMenuItem
            // 
            this.aBMDeTareaToolStripMenuItem.Name = "aBMDeTareaToolStripMenuItem";
            this.aBMDeTareaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aBMDeTareaToolStripMenuItem.Text = "ABM de Tarea";
            this.aBMDeTareaToolStripMenuItem.Click += new System.EventHandler(this.aBMDeTareaToolStripMenuItem_Click);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 432);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "inicio";
            this.Text = "inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem obrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMSitioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMDeTareaToolStripMenuItem;
    }
}