namespace Gestion_Constructora
{
    partial class chequeEmision
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.pnl_busqueda = new System.Windows.Forms.Panel();
            this.dgv_cheque = new System.Windows.Forms.DataGridView();
            this.txt_busquedaCheque = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_datos = new System.Windows.Forms.Panel();
            this.dtp_fechaEmision = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_fechaPago = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_importe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_banco = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_busquedaPersona = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_chequera = new System.Windows.Forms.DataGridView();
            this.idChequer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_busquedaChequera = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idChequera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personaNOmbre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cheque)).BeginInit();
            this.pnl_datos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chequera)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(471, 464);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 35;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(390, 464);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 34;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(390, 67);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(156, 23);
            this.btn_eliminar.TabIndex = 33;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(390, 38);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(156, 23);
            this.btn_editar.TabIndex = 32;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(390, 9);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(156, 23);
            this.btn_nuevo.TabIndex = 31;
            this.btn_nuevo.Text = "Emitir nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // pnl_busqueda
            // 
            this.pnl_busqueda.Controls.Add(this.dgv_cheque);
            this.pnl_busqueda.Controls.Add(this.txt_busquedaCheque);
            this.pnl_busqueda.Controls.Add(this.label2);
            this.pnl_busqueda.Location = new System.Drawing.Point(11, 211);
            this.pnl_busqueda.Name = "pnl_busqueda";
            this.pnl_busqueda.Size = new System.Drawing.Size(373, 188);
            this.pnl_busqueda.TabIndex = 30;
            // 
            // dgv_cheque
            // 
            this.dgv_cheque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cheque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idChequera,
            this.Column1,
            this.personaNOmbre,
            this.pago,
            this.emision,
            this.numero,
            this.importe});
            this.dgv_cheque.Location = new System.Drawing.Point(3, 29);
            this.dgv_cheque.Name = "dgv_cheque";
            this.dgv_cheque.Size = new System.Drawing.Size(367, 156);
            this.dgv_cheque.TabIndex = 5;
            // 
            // txt_busquedaCheque
            // 
            this.txt_busquedaCheque.Location = new System.Drawing.Point(129, 3);
            this.txt_busquedaCheque.Name = "txt_busquedaCheque";
            this.txt_busquedaCheque.Size = new System.Drawing.Size(241, 20);
            this.txt_busquedaCheque.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar numero cheque:";
            // 
            // pnl_datos
            // 
            this.pnl_datos.Controls.Add(this.dtp_fechaEmision);
            this.pnl_datos.Controls.Add(this.label8);
            this.pnl_datos.Controls.Add(this.dtp_fechaPago);
            this.pnl_datos.Controls.Add(this.label4);
            this.pnl_datos.Controls.Add(this.txt_numero);
            this.pnl_datos.Controls.Add(this.txt_importe);
            this.pnl_datos.Controls.Add(this.label5);
            this.pnl_datos.Controls.Add(this.label3);
            this.pnl_datos.Controls.Add(this.label1);
            this.pnl_datos.Controls.Add(this.txt_banco);
            this.pnl_datos.Enabled = false;
            this.pnl_datos.Location = new System.Drawing.Point(11, 405);
            this.pnl_datos.Name = "pnl_datos";
            this.pnl_datos.Size = new System.Drawing.Size(373, 80);
            this.pnl_datos.TabIndex = 29;
            // 
            // dtp_fechaEmision
            // 
            this.dtp_fechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaEmision.Location = new System.Drawing.Point(275, 29);
            this.dtp_fechaEmision.Name = "dtp_fechaEmision";
            this.dtp_fechaEmision.Size = new System.Drawing.Size(95, 20);
            this.dtp_fechaEmision.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(190, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fecha Emision:";
            // 
            // dtp_fechaPago
            // 
            this.dtp_fechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaPago.Location = new System.Drawing.Point(76, 29);
            this.dtp_fechaPago.Name = "dtp_fechaPago";
            this.dtp_fechaPago.Size = new System.Drawing.Size(95, 20);
            this.dtp_fechaPago.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha Pago:";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(93, 56);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(78, 20);
            this.txt_numero.TabIndex = 10;
            // 
            // txt_importe
            // 
            this.txt_importe.Location = new System.Drawing.Point(275, 55);
            this.txt_importe.Name = "txt_importe";
            this.txt_importe.Size = new System.Drawing.Size(95, 20);
            this.txt_importe.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Importe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero Cheque:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Banco:";
            // 
            // txt_banco
            // 
            this.txt_banco.Location = new System.Drawing.Point(50, 3);
            this.txt_banco.Name = "txt_banco";
            this.txt_banco.ReadOnly = true;
            this.txt_banco.Size = new System.Drawing.Size(320, 20);
            this.txt_banco.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_busquedaPersona);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 26);
            this.panel1.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar Persona";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_busquedaPersona
            // 
            this.txt_busquedaPersona.Enabled = false;
            this.txt_busquedaPersona.Location = new System.Drawing.Point(58, 3);
            this.txt_busquedaPersona.Name = "txt_busquedaPersona";
            this.txt_busquedaPersona.Size = new System.Drawing.Size(216, 20);
            this.txt_busquedaPersona.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Persona:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_chequera);
            this.panel2.Controls.Add(this.txt_busquedaChequera);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(11, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 164);
            this.panel2.TabIndex = 31;
            // 
            // dgv_chequera
            // 
            this.dgv_chequera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chequera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idChequer,
            this.banco,
            this.numeroCuenta,
            this.fecha});
            this.dgv_chequera.Location = new System.Drawing.Point(3, 29);
            this.dgv_chequera.Name = "dgv_chequera";
            this.dgv_chequera.Size = new System.Drawing.Size(367, 132);
            this.dgv_chequera.TabIndex = 5;
            this.dgv_chequera.SelectionChanged += new System.EventHandler(this.dgv_chequera_SelectionChanged);
            // 
            // idChequer
            // 
            this.idChequer.HeaderText = "ID";
            this.idChequer.Name = "idChequer";
            this.idChequer.Width = 30;
            // 
            // banco
            // 
            this.banco.HeaderText = "Banco";
            this.banco.Name = "banco";
            this.banco.Width = 80;
            // 
            // numeroCuenta
            // 
            this.numeroCuenta.HeaderText = "Cuenta Numero";
            this.numeroCuenta.Name = "numeroCuenta";
            this.numeroCuenta.Width = 147;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.Width = 80;
            // 
            // txt_busquedaChequera
            // 
            this.txt_busquedaChequera.Location = new System.Drawing.Point(146, 3);
            this.txt_busquedaChequera.Name = "txt_busquedaChequera";
            this.txt_busquedaChequera.Size = new System.Drawing.Size(224, 20);
            this.txt_busquedaChequera.TabIndex = 4;
            this.txt_busquedaChequera.TextChanged += new System.EventHandler(this.txt_busquedaChequera_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Buscar chequera de Banco:";
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 30;
            // 
            // idChequera
            // 
            this.idChequera.HeaderText = "idChequera";
            this.idChequera.Name = "idChequera";
            this.idChequera.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "idPersona";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // personaNOmbre
            // 
            this.personaNOmbre.HeaderText = "PersonaNombre";
            this.personaNOmbre.Name = "personaNOmbre";
            this.personaNOmbre.Visible = false;
            // 
            // pago
            // 
            this.pago.HeaderText = "Pago";
            this.pago.Name = "pago";
            this.pago.Visible = false;
            // 
            // emision
            // 
            this.emision.HeaderText = "Emision";
            this.emision.Name = "emision";
            this.emision.Width = 147;
            // 
            // numero
            // 
            this.numero.HeaderText = "numero";
            this.numero.Name = "numero";
            this.numero.Visible = false;
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            this.importe.Width = 147;
            // 
            // chequeEmision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 497);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.pnl_busqueda);
            this.Controls.Add(this.pnl_datos);
            this.Name = "chequeEmision";
            this.Text = "chequeEmision";
            this.Activated += new System.EventHandler(this.chequeEmision_Activated);
            this.Load += new System.EventHandler(this.chequeEmision_Load);
            this.pnl_busqueda.ResumeLayout(false);
            this.pnl_busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cheque)).EndInit();
            this.pnl_datos.ResumeLayout(false);
            this.pnl_datos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chequera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Panel pnl_busqueda;
        private System.Windows.Forms.TextBox txt_busquedaCheque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_datos;
        private System.Windows.Forms.DateTimePicker dtp_fechaPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_importe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_banco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_busquedaPersona;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_cheque;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_chequera;
        private System.Windows.Forms.TextBox txt_busquedaChequera;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_fechaEmision;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn idChequer;
        private System.Windows.Forms.DataGridViewTextBoxColumn banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idChequera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personaNOmbre;
        private System.Windows.Forms.DataGridViewTextBoxColumn pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn emision;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
    }
}