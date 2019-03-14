namespace Gestion_Constructora
{
    partial class localidadBusquedaRapida
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_provincia = new System.Windows.Forms.ComboBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.pnl_sitio = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_provincia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_localidad = new System.Windows.Forms.TextBox();
            this.dgv_localidad = new System.Windows.Forms.DataGridView();
            this.pnl_busqueda = new System.Windows.Forms.Panel();
            this.provinciaDataSet = new Gestion_Constructora.provinciaDataSet();
            this.provinciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provinciaTableAdapter = new Gestion_Constructora.provinciaDataSetTableAdapters.provinciaTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProvin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_busquedaLocalidad = new System.Windows.Forms.TextBox();
            this.pnl_sitio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_localidad)).BeginInit();
            this.pnl_busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provincia:";
            // 
            // cbo_provincia
            // 
            this.cbo_provincia.DataSource = this.provinciaBindingSource;
            this.cbo_provincia.DisplayMember = "nombre";
            this.cbo_provincia.FormattingEnabled = true;
            this.cbo_provincia.Location = new System.Drawing.Point(62, 2);
            this.cbo_provincia.Name = "cbo_provincia";
            this.cbo_provincia.Size = new System.Drawing.Size(308, 21);
            this.cbo_provincia.TabIndex = 1;
            this.cbo_provincia.ValueMember = "id";
            this.cbo_provincia.SelectedIndexChanged += new System.EventHandler(this.cbo_provincia_SelectedIndexChanged);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(309, 226);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 30;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(228, 226);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 29;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // pnl_sitio
            // 
            this.pnl_sitio.Controls.Add(this.label3);
            this.pnl_sitio.Controls.Add(this.txt_localidad);
            this.pnl_sitio.Controls.Add(this.label2);
            this.pnl_sitio.Controls.Add(this.txt_provincia);
            this.pnl_sitio.Enabled = false;
            this.pnl_sitio.Location = new System.Drawing.Point(11, 197);
            this.pnl_sitio.Name = "pnl_sitio";
            this.pnl_sitio.Size = new System.Drawing.Size(211, 52);
            this.pnl_sitio.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Provincia:";
            // 
            // txt_provincia
            // 
            this.txt_provincia.Location = new System.Drawing.Point(63, 4);
            this.txt_provincia.Name = "txt_provincia";
            this.txt_provincia.Size = new System.Drawing.Size(145, 20);
            this.txt_provincia.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Localidad:";
            // 
            // txt_localidad
            // 
            this.txt_localidad.Location = new System.Drawing.Point(63, 30);
            this.txt_localidad.Name = "txt_localidad";
            this.txt_localidad.Size = new System.Drawing.Size(145, 20);
            this.txt_localidad.TabIndex = 3;
            // 
            // dgv_localidad
            // 
            this.dgv_localidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_localidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idProvin,
            this.nombre,
            this.codigoPostal});
            this.dgv_localidad.Location = new System.Drawing.Point(12, 67);
            this.dgv_localidad.Name = "dgv_localidad";
            this.dgv_localidad.Size = new System.Drawing.Size(373, 128);
            this.dgv_localidad.TabIndex = 32;
            this.dgv_localidad.SelectionChanged += new System.EventHandler(this.dgv_localidad_SelectionChanged);
            // 
            // pnl_busqueda
            // 
            this.pnl_busqueda.Controls.Add(this.label1);
            this.pnl_busqueda.Controls.Add(this.cbo_provincia);
            this.pnl_busqueda.Location = new System.Drawing.Point(12, 11);
            this.pnl_busqueda.Name = "pnl_busqueda";
            this.pnl_busqueda.Size = new System.Drawing.Size(373, 26);
            this.pnl_busqueda.TabIndex = 33;
            // 
            // provinciaDataSet
            // 
            this.provinciaDataSet.DataSetName = "provinciaDataSet";
            this.provinciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provinciaBindingSource
            // 
            this.provinciaBindingSource.DataMember = "provincia";
            this.provinciaBindingSource.DataSource = this.provinciaDataSet;
            // 
            // provinciaTableAdapter
            // 
            this.provinciaTableAdapter.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 60;
            // 
            // idProvin
            // 
            this.idProvin.HeaderText = "idProvincia";
            this.idProvin.Name = "idProvin";
            this.idProvin.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Localidad";
            this.nombre.Name = "nombre";
            this.nombre.Width = 220;
            // 
            // codigoPostal
            // 
            this.codigoPostal.HeaderText = "CP";
            this.codigoPostal.Name = "codigoPostal";
            this.codigoPostal.Width = 50;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_busquedaLocalidad);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 26);
            this.panel1.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Localidad:";
            // 
            // txt_busquedaLocalidad
            // 
            this.txt_busquedaLocalidad.Location = new System.Drawing.Point(62, 3);
            this.txt_busquedaLocalidad.Name = "txt_busquedaLocalidad";
            this.txt_busquedaLocalidad.Size = new System.Drawing.Size(308, 20);
            this.txt_busquedaLocalidad.TabIndex = 7;
            this.txt_busquedaLocalidad.TextChanged += new System.EventHandler(this.txt_busquedaLocalidad_TextChanged);
            // 
            // localidadBusquedaRapida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_busqueda);
            this.Controls.Add(this.dgv_localidad);
            this.Controls.Add(this.pnl_sitio);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Name = "localidadBusquedaRapida";
            this.Text = "localidadBusquedaRapida";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.localidadBusquedaRapida_FormClosing);
            this.Load += new System.EventHandler(this.localidadBusquedaRapida_Load);
            this.pnl_sitio.ResumeLayout(false);
            this.pnl_sitio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_localidad)).EndInit();
            this.pnl_busqueda.ResumeLayout(false);
            this.pnl_busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_provincia;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Panel pnl_sitio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_localidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_provincia;
        private System.Windows.Forms.DataGridView dgv_localidad;
        private System.Windows.Forms.Panel pnl_busqueda;
        private provinciaDataSet provinciaDataSet;
        private System.Windows.Forms.BindingSource provinciaBindingSource;
        private provinciaDataSetTableAdapters.provinciaTableAdapter provinciaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProvin;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPostal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_busquedaLocalidad;
    }
}