namespace Gestion_Constructora
{
    partial class chequeTercero
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
            this.dgv_cheque = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titularCuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRecibido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.pnl_busqueda = new System.Windows.Forms.Panel();
            this.chk_cartera = new System.Windows.Forms.CheckBox();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_datos = new System.Windows.Forms.Panel();
            this.cbo_provincia = new System.Windows.Forms.ComboBox();
            this.dtp_fechaRecibido = new System.Windows.Forms.DateTimePicker();
            this.dtp_fechaEmision = new System.Windows.Forms.DateTimePicker();
            this.dtp_fechaCobro = new System.Windows.Forms.DateTimePicker();
            this.txt_importe = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.cbo_tipo = new System.Windows.Forms.ComboBox();
            this.cbo_banco = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_busquedaPersona = new System.Windows.Forms.Button();
            this.txt_persona = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_cuit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_titular = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_fechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.cbo_destino = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_salida = new System.Windows.Forms.Button();
            this.btn_busquedaLocalidad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cheque)).BeginInit();
            this.pnl_busqueda.SuspendLayout();
            this.pnl_datos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_cheque
            // 
            this.dgv_cheque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cheque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idBanco,
            this.idLocalidad,
            this.idTipo,
            this.numero,
            this.titular,
            this.titularCuit,
            this.importe,
            this.fechaCobro,
            this.fechaEmision,
            this.fechaRecibido,
            this.idDestino,
            this.fechaSalida,
            this.idPersona});
            this.dgv_cheque.Location = new System.Drawing.Point(12, 44);
            this.dgv_cheque.Name = "dgv_cheque";
            this.dgv_cheque.Size = new System.Drawing.Size(489, 175);
            this.dgv_cheque.TabIndex = 26;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 30;
            // 
            // idBanco
            // 
            this.idBanco.HeaderText = "idBanco";
            this.idBanco.Name = "idBanco";
            this.idBanco.Visible = false;
            // 
            // idLocalidad
            // 
            this.idLocalidad.HeaderText = "IdLocalidad";
            this.idLocalidad.Name = "idLocalidad";
            this.idLocalidad.Visible = false;
            // 
            // idTipo
            // 
            this.idTipo.HeaderText = "idTipo";
            this.idTipo.Name = "idTipo";
            this.idTipo.Visible = false;
            // 
            // numero
            // 
            this.numero.HeaderText = "Numero";
            this.numero.Name = "numero";
            this.numero.Width = 150;
            // 
            // titular
            // 
            this.titular.HeaderText = "Titular";
            this.titular.Name = "titular";
            this.titular.Width = 190;
            // 
            // titularCuit
            // 
            this.titularCuit.HeaderText = "TitularCuit";
            this.titularCuit.Name = "titularCuit";
            this.titularCuit.Visible = false;
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            this.importe.Width = 75;
            // 
            // fechaCobro
            // 
            this.fechaCobro.HeaderText = "FechaCobro";
            this.fechaCobro.Name = "fechaCobro";
            this.fechaCobro.Visible = false;
            // 
            // fechaEmision
            // 
            this.fechaEmision.HeaderText = "FechaEmision";
            this.fechaEmision.Name = "fechaEmision";
            this.fechaEmision.Visible = false;
            // 
            // fechaRecibido
            // 
            this.fechaRecibido.HeaderText = "FechaRecibido";
            this.fechaRecibido.Name = "fechaRecibido";
            this.fechaRecibido.Visible = false;
            // 
            // idDestino
            // 
            this.idDestino.HeaderText = "idDestino";
            this.idDestino.Name = "idDestino";
            this.idDestino.Visible = false;
            // 
            // fechaSalida
            // 
            this.fechaSalida.HeaderText = "FechaSalida";
            this.fechaSalida.Name = "fechaSalida";
            this.fechaSalida.Visible = false;
            // 
            // idPersona
            // 
            this.idPersona.HeaderText = "idPersona";
            this.idPersona.Name = "idPersona";
            this.idPersona.Visible = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(588, 387);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 25;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(507, 387);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 24;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(507, 72);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(156, 23);
            this.btn_eliminar.TabIndex = 23;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(507, 43);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(156, 23);
            this.btn_editar.TabIndex = 22;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(507, 14);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(156, 23);
            this.btn_nuevo.TabIndex = 21;
            this.btn_nuevo.Text = "Ingresar nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            // 
            // pnl_busqueda
            // 
            this.pnl_busqueda.Controls.Add(this.chk_cartera);
            this.pnl_busqueda.Controls.Add(this.txt_busqueda);
            this.pnl_busqueda.Controls.Add(this.label2);
            this.pnl_busqueda.Location = new System.Drawing.Point(12, 12);
            this.pnl_busqueda.Name = "pnl_busqueda";
            this.pnl_busqueda.Size = new System.Drawing.Size(489, 26);
            this.pnl_busqueda.TabIndex = 20;
            // 
            // chk_cartera
            // 
            this.chk_cartera.AutoSize = true;
            this.chk_cartera.Location = new System.Drawing.Point(411, 4);
            this.chk_cartera.Name = "chk_cartera";
            this.chk_cartera.Size = new System.Drawing.Size(75, 17);
            this.chk_cartera.TabIndex = 5;
            this.chk_cartera.Text = "En cartera";
            this.chk_cartera.UseVisualStyleBackColor = true;
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Location = new System.Drawing.Point(108, 3);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(297, 20);
            this.txt_busqueda.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar por numero:";
            // 
            // pnl_datos
            // 
            this.pnl_datos.Controls.Add(this.btn_busquedaLocalidad);
            this.pnl_datos.Controls.Add(this.cbo_provincia);
            this.pnl_datos.Controls.Add(this.dtp_fechaRecibido);
            this.pnl_datos.Controls.Add(this.dtp_fechaEmision);
            this.pnl_datos.Controls.Add(this.dtp_fechaCobro);
            this.pnl_datos.Controls.Add(this.txt_importe);
            this.pnl_datos.Controls.Add(this.txt_numero);
            this.pnl_datos.Controls.Add(this.cbo_tipo);
            this.pnl_datos.Controls.Add(this.cbo_banco);
            this.pnl_datos.Controls.Add(this.label13);
            this.pnl_datos.Controls.Add(this.label12);
            this.pnl_datos.Controls.Add(this.label11);
            this.pnl_datos.Controls.Add(this.label10);
            this.pnl_datos.Controls.Add(this.label9);
            this.pnl_datos.Controls.Add(this.label8);
            this.pnl_datos.Controls.Add(this.label7);
            this.pnl_datos.Controls.Add(this.btn_busquedaPersona);
            this.pnl_datos.Controls.Add(this.txt_persona);
            this.pnl_datos.Controls.Add(this.label6);
            this.pnl_datos.Controls.Add(this.txt_usuario);
            this.pnl_datos.Controls.Add(this.txt_cuit);
            this.pnl_datos.Controls.Add(this.label5);
            this.pnl_datos.Controls.Add(this.label4);
            this.pnl_datos.Controls.Add(this.label3);
            this.pnl_datos.Controls.Add(this.label1);
            this.pnl_datos.Controls.Add(this.txt_titular);
            this.pnl_datos.Location = new System.Drawing.Point(12, 225);
            this.pnl_datos.Name = "pnl_datos";
            this.pnl_datos.Size = new System.Drawing.Size(489, 248);
            this.pnl_datos.TabIndex = 19;
            // 
            // cbo_provincia
            // 
            this.cbo_provincia.FormattingEnabled = true;
            this.cbo_provincia.Location = new System.Drawing.Point(64, 55);
            this.cbo_provincia.Name = "cbo_provincia";
            this.cbo_provincia.Size = new System.Drawing.Size(121, 21);
            this.cbo_provincia.TabIndex = 29;
            // 
            // dtp_fechaRecibido
            // 
            this.dtp_fechaRecibido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaRecibido.Location = new System.Drawing.Point(346, 161);
            this.dtp_fechaRecibido.Name = "dtp_fechaRecibido";
            this.dtp_fechaRecibido.Size = new System.Drawing.Size(96, 20);
            this.dtp_fechaRecibido.TabIndex = 28;
            // 
            // dtp_fechaEmision
            // 
            this.dtp_fechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaEmision.Location = new System.Drawing.Point(341, 136);
            this.dtp_fechaEmision.Name = "dtp_fechaEmision";
            this.dtp_fechaEmision.Size = new System.Drawing.Size(96, 20);
            this.dtp_fechaEmision.TabIndex = 27;
            // 
            // dtp_fechaCobro
            // 
            this.dtp_fechaCobro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaCobro.Location = new System.Drawing.Point(334, 114);
            this.dtp_fechaCobro.Name = "dtp_fechaCobro";
            this.dtp_fechaCobro.Size = new System.Drawing.Size(96, 20);
            this.dtp_fechaCobro.TabIndex = 26;
            // 
            // txt_importe
            // 
            this.txt_importe.Location = new System.Drawing.Point(302, 81);
            this.txt_importe.Name = "txt_importe";
            this.txt_importe.Size = new System.Drawing.Size(175, 20);
            this.txt_importe.TabIndex = 25;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(302, 55);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(175, 20);
            this.txt_numero.TabIndex = 24;
            // 
            // cbo_tipo
            // 
            this.cbo_tipo.FormattingEnabled = true;
            this.cbo_tipo.Location = new System.Drawing.Point(302, 30);
            this.cbo_tipo.Name = "cbo_tipo";
            this.cbo_tipo.Size = new System.Drawing.Size(121, 21);
            this.cbo_tipo.TabIndex = 23;
            // 
            // cbo_banco
            // 
            this.cbo_banco.FormattingEnabled = true;
            this.cbo_banco.Location = new System.Drawing.Point(302, 3);
            this.cbo_banco.Name = "cbo_banco";
            this.cbo_banco.Size = new System.Drawing.Size(121, 21);
            this.cbo_banco.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(255, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Fecha Recibido:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(256, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Fecha Emision:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(256, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Fecha Cobro:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(256, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Importe:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Numero:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tipo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Banco:";
            // 
            // btn_busquedaPersona
            // 
            this.btn_busquedaPersona.Location = new System.Drawing.Point(158, 112);
            this.btn_busquedaPersona.Name = "btn_busquedaPersona";
            this.btn_busquedaPersona.Size = new System.Drawing.Size(50, 23);
            this.btn_busquedaPersona.TabIndex = 14;
            this.btn_busquedaPersona.Text = "Buscar";
            this.btn_busquedaPersona.UseVisualStyleBackColor = true;
            // 
            // txt_persona
            // 
            this.txt_persona.Location = new System.Drawing.Point(52, 114);
            this.txt_persona.Name = "txt_persona";
            this.txt_persona.Size = new System.Drawing.Size(100, 20);
            this.txt_persona.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Persona:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(66, 80);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(125, 20);
            this.txt_usuario.TabIndex = 11;
            // 
            // txt_cuit
            // 
            this.txt_cuit.Location = new System.Drawing.Point(52, 29);
            this.txt_cuit.Name = "txt_cuit";
            this.txt_cuit.Size = new System.Drawing.Size(175, 20);
            this.txt_cuit.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Localidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Provincia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CUIT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titular:";
            // 
            // txt_titular
            // 
            this.txt_titular.Location = new System.Drawing.Point(52, 3);
            this.txt_titular.Name = "txt_titular";
            this.txt_titular.Size = new System.Drawing.Size(175, 20);
            this.txt_titular.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtp_fechaSalida);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.cbo_destino);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(508, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 158);
            this.panel1.TabIndex = 27;
            // 
            // dtp_fechaSalida
            // 
            this.dtp_fechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaSalida.Location = new System.Drawing.Point(30, 105);
            this.dtp_fechaSalida.Name = "dtp_fechaSalida";
            this.dtp_fechaSalida.Size = new System.Drawing.Size(96, 20);
            this.dtp_fechaSalida.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(54, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Fecha Salida:";
            // 
            // cbo_destino
            // 
            this.cbo_destino.FormattingEnabled = true;
            this.cbo_destino.Location = new System.Drawing.Point(17, 31);
            this.cbo_destino.Name = "cbo_destino";
            this.cbo_destino.Size = new System.Drawing.Size(121, 21);
            this.cbo_destino.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Destino:";
            // 
            // btn_salida
            // 
            this.btn_salida.Location = new System.Drawing.Point(507, 139);
            this.btn_salida.Name = "btn_salida";
            this.btn_salida.Size = new System.Drawing.Size(156, 23);
            this.btn_salida.TabIndex = 28;
            this.btn_salida.Text = "Dar salida";
            this.btn_salida.UseVisualStyleBackColor = true;
            // 
            // btn_busquedaLocalidad
            // 
            this.btn_busquedaLocalidad.Location = new System.Drawing.Point(200, 79);
            this.btn_busquedaLocalidad.Name = "btn_busquedaLocalidad";
            this.btn_busquedaLocalidad.Size = new System.Drawing.Size(50, 23);
            this.btn_busquedaLocalidad.TabIndex = 30;
            this.btn_busquedaLocalidad.Text = "Buscar";
            this.btn_busquedaLocalidad.UseVisualStyleBackColor = true;
            this.btn_busquedaLocalidad.Click += new System.EventHandler(this.btn_busquedaLocalidad_Click);
            // 
            // chequeTercero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 485);
            this.Controls.Add(this.btn_salida);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_cheque);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.pnl_busqueda);
            this.Controls.Add(this.pnl_datos);
            this.Name = "chequeTercero";
            this.Text = "chequeTercero";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cheque)).EndInit();
            this.pnl_busqueda.ResumeLayout(false);
            this.pnl_busqueda.PerformLayout();
            this.pnl_datos.ResumeLayout(false);
            this.pnl_datos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cheque;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Panel pnl_busqueda;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_datos;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_cuit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_titular;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn titular;
        private System.Windows.Forms.DataGridViewTextBoxColumn titularCuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCobro;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRecibido;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersona;
        private System.Windows.Forms.CheckBox chk_cartera;
        private System.Windows.Forms.DateTimePicker dtp_fechaRecibido;
        private System.Windows.Forms.DateTimePicker dtp_fechaEmision;
        private System.Windows.Forms.DateTimePicker dtp_fechaCobro;
        private System.Windows.Forms.TextBox txt_importe;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.ComboBox cbo_tipo;
        private System.Windows.Forms.ComboBox cbo_banco;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_busquedaPersona;
        private System.Windows.Forms.TextBox txt_persona;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtp_fechaSalida;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbo_destino;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_salida;
        private System.Windows.Forms.ComboBox cbo_provincia;
        private System.Windows.Forms.Button btn_busquedaLocalidad;
    }
}