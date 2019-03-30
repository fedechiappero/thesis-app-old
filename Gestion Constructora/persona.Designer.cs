namespace Gestion_Constructora
{
    partial class persona
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
            this.dgv_persona = new System.Windows.Forms.DataGridView();
            this.pnl_busqueda = new System.Windows.Forms.Panel();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_datos = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.cbo_documentoTipo = new System.Windows.Forms.ComboBox();
            this.documentotipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentoTipoDataSet = new Gestion_Constructora.documentoTipoDataSet();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_localidad = new System.Windows.Forms.TextBox();
            this.btn_busquedaLocalidad = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.chk_juridica = new System.Windows.Forms.CheckBox();
            this.txt_cuit = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_celular = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.documentotipoTableAdapter = new Gestion_Constructora.documentoTipoDataSetTableAdapters.documentotipoTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juridica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDocumentoTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_persona)).BeginInit();
            this.pnl_busqueda.SuspendLayout();
            this.pnl_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentotipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentoTipoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_persona
            // 
            this.dgv_persona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_persona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.cuit,
            this.juridica,
            this.celular,
            this.dni,
            this.idDocumentoTipo,
            this.email,
            this.idLocalidad,
            this.localidad,
            this.direccion});
            this.dgv_persona.Location = new System.Drawing.Point(12, 44);
            this.dgv_persona.Name = "dgv_persona";
            this.dgv_persona.Size = new System.Drawing.Size(574, 175);
            this.dgv_persona.TabIndex = 26;
            this.dgv_persona.SelectionChanged += new System.EventHandler(this.dgv_persona_SelectionChanged);
            // 
            // pnl_busqueda
            // 
            this.pnl_busqueda.Controls.Add(this.txt_busqueda);
            this.pnl_busqueda.Controls.Add(this.label2);
            this.pnl_busqueda.Location = new System.Drawing.Point(12, 12);
            this.pnl_busqueda.Name = "pnl_busqueda";
            this.pnl_busqueda.Size = new System.Drawing.Size(305, 26);
            this.pnl_busqueda.TabIndex = 20;
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Location = new System.Drawing.Point(52, 3);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(250, 20);
            this.txt_busqueda.TabIndex = 4;
            this.txt_busqueda.TextChanged += new System.EventHandler(this.txt_busqueda_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar:";
            // 
            // pnl_datos
            // 
            this.pnl_datos.Controls.Add(this.label10);
            this.pnl_datos.Controls.Add(this.txt_dni);
            this.pnl_datos.Controls.Add(this.cbo_documentoTipo);
            this.pnl_datos.Controls.Add(this.label9);
            this.pnl_datos.Controls.Add(this.txt_direccion);
            this.pnl_datos.Controls.Add(this.label6);
            this.pnl_datos.Controls.Add(this.txt_localidad);
            this.pnl_datos.Controls.Add(this.btn_busquedaLocalidad);
            this.pnl_datos.Controls.Add(this.label5);
            this.pnl_datos.Controls.Add(this.chk_juridica);
            this.pnl_datos.Controls.Add(this.txt_cuit);
            this.pnl_datos.Controls.Add(this.label8);
            this.pnl_datos.Controls.Add(this.txt_email);
            this.pnl_datos.Controls.Add(this.txt_celular);
            this.pnl_datos.Controls.Add(this.label4);
            this.pnl_datos.Controls.Add(this.label3);
            this.pnl_datos.Controls.Add(this.label1);
            this.pnl_datos.Controls.Add(this.txt_nombre);
            this.pnl_datos.Enabled = false;
            this.pnl_datos.Location = new System.Drawing.Point(12, 225);
            this.pnl_datos.Name = "pnl_datos";
            this.pnl_datos.Size = new System.Drawing.Size(574, 113);
            this.pnl_datos.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(176, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Tipo Documento:";
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(54, 55);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(82, 20);
            this.txt_dni.TabIndex = 41;
            // 
            // cbo_documentoTipo
            // 
            this.cbo_documentoTipo.DataSource = this.documentotipoBindingSource;
            this.cbo_documentoTipo.DisplayMember = "descripcion";
            this.cbo_documentoTipo.FormattingEnabled = true;
            this.cbo_documentoTipo.Location = new System.Drawing.Point(271, 54);
            this.cbo_documentoTipo.Name = "cbo_documentoTipo";
            this.cbo_documentoTipo.Size = new System.Drawing.Size(121, 21);
            this.cbo_documentoTipo.TabIndex = 42;
            this.cbo_documentoTipo.ValueMember = "id";
            // 
            // documentotipoBindingSource
            // 
            this.documentotipoBindingSource.DataMember = "documentotipo";
            this.documentotipoBindingSource.DataSource = this.documentoTipoDataSet;
            // 
            // documentoTipoDataSet
            // 
            this.documentoTipoDataSet.DataSetName = "documentoTipoDataSet";
            this.documentoTipoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "D.N.I:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(320, 85);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(200, 20);
            this.txt_direccion.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Direccion:";
            // 
            // txt_localidad
            // 
            this.txt_localidad.Enabled = false;
            this.txt_localidad.Location = new System.Drawing.Point(65, 85);
            this.txt_localidad.Name = "txt_localidad";
            this.txt_localidad.Size = new System.Drawing.Size(100, 20);
            this.txt_localidad.TabIndex = 37;
            // 
            // btn_busquedaLocalidad
            // 
            this.btn_busquedaLocalidad.Location = new System.Drawing.Point(177, 83);
            this.btn_busquedaLocalidad.Name = "btn_busquedaLocalidad";
            this.btn_busquedaLocalidad.Size = new System.Drawing.Size(50, 23);
            this.btn_busquedaLocalidad.TabIndex = 36;
            this.btn_busquedaLocalidad.Text = "Buscar";
            this.btn_busquedaLocalidad.UseVisualStyleBackColor = true;
            this.btn_busquedaLocalidad.Click += new System.EventHandler(this.btn_busquedaLocalidad_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Localidad:";
            // 
            // chk_juridica
            // 
            this.chk_juridica.AutoSize = true;
            this.chk_juridica.Location = new System.Drawing.Point(397, 6);
            this.chk_juridica.Name = "chk_juridica";
            this.chk_juridica.Size = new System.Drawing.Size(104, 17);
            this.chk_juridica.TabIndex = 15;
            this.chk_juridica.Text = "Persona Juridica";
            this.chk_juridica.UseVisualStyleBackColor = true;
            // 
            // txt_cuit
            // 
            this.txt_cuit.Location = new System.Drawing.Point(308, 3);
            this.txt_cuit.Mask = "99-99999999-9";
            this.txt_cuit.Name = "txt_cuit";
            this.txt_cuit.Size = new System.Drawing.Size(82, 20);
            this.txt_cuit.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "CUIT:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(308, 29);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(175, 20);
            this.txt_email.TabIndex = 9;
            // 
            // txt_celular
            // 
            this.txt_celular.Location = new System.Drawing.Point(52, 29);
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(200, 20);
            this.txt_celular.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Celular:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(52, 3);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(200, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(673, 308);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 31;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(592, 308);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 30;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(592, 72);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(156, 23);
            this.btn_eliminar.TabIndex = 29;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(592, 43);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(156, 23);
            this.btn_editar.TabIndex = 28;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(592, 14);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(156, 23);
            this.btn_nuevo.TabIndex = 27;
            this.btn_nuevo.Text = "Ingresar nueva";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // documentotipoTableAdapter
            // 
            this.documentotipoTableAdapter.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 30;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 200;
            // 
            // cuit
            // 
            this.cuit.HeaderText = "Cuit";
            this.cuit.Name = "cuit";
            // 
            // juridica
            // 
            this.juridica.HeaderText = "Juridica";
            this.juridica.Name = "juridica";
            this.juridica.Visible = false;
            // 
            // celular
            // 
            this.celular.HeaderText = "Celular";
            this.celular.Name = "celular";
            this.celular.Visible = false;
            // 
            // dni
            // 
            this.dni.HeaderText = "Dni";
            this.dni.Name = "dni";
            this.dni.Visible = false;
            // 
            // idDocumentoTipo
            // 
            this.idDocumentoTipo.HeaderText = "IDDocumentoTipo";
            this.idDocumentoTipo.Name = "idDocumentoTipo";
            this.idDocumentoTipo.Visible = false;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.Visible = false;
            // 
            // idLocalidad
            // 
            this.idLocalidad.HeaderText = "IdLocalidad";
            this.idLocalidad.Name = "idLocalidad";
            this.idLocalidad.Visible = false;
            // 
            // localidad
            // 
            this.localidad.HeaderText = "Localidad";
            this.localidad.Name = "localidad";
            this.localidad.Width = 200;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.Visible = false;
            // 
            // persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 349);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.dgv_persona);
            this.Controls.Add(this.pnl_busqueda);
            this.Controls.Add(this.pnl_datos);
            this.Name = "persona";
            this.Text = "persona";
            this.Load += new System.EventHandler(this.persona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_persona)).EndInit();
            this.pnl_busqueda.ResumeLayout(false);
            this.pnl_busqueda.PerformLayout();
            this.pnl_datos.ResumeLayout(false);
            this.pnl_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentotipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentoTipoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_persona;
        private System.Windows.Forms.Panel pnl_busqueda;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_datos;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_celular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.CheckBox chk_juridica;
        private System.Windows.Forms.MaskedTextBox txt_cuit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.TextBox txt_localidad;
        private System.Windows.Forms.Button btn_busquedaLocalidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.ComboBox cbo_documentoTipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label6;
        private documentoTipoDataSet documentoTipoDataSet;
        private System.Windows.Forms.BindingSource documentotipoBindingSource;
        private documentoTipoDataSetTableAdapters.documentotipoTableAdapter documentotipoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn juridica;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocumentoTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
    }
}