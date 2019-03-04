namespace Gestion_Constructora
{
    partial class chequera
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
            this.dgv_chequera = new System.Windows.Forms.DataGridView();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.pnl_busqueda = new System.Windows.Forms.Panel();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_datos = new System.Windows.Forms.Panel();
            this.chk_activa = new System.Windows.Forms.CheckBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cuenta = new System.Windows.Forms.TextBox();
            this.dgv_cuenta = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_numeroInicial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.idChequera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chequera)).BeginInit();
            this.pnl_busqueda.SuspendLayout();
            this.pnl_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuenta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_chequera
            // 
            this.dgv_chequera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chequera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idChequera,
            this.idCuenta,
            this.inicial,
            this.cantidad,
            this.fecha,
            this.activa});
            this.dgv_chequera.Location = new System.Drawing.Point(11, 164);
            this.dgv_chequera.Name = "dgv_chequera";
            this.dgv_chequera.Size = new System.Drawing.Size(373, 131);
            this.dgv_chequera.TabIndex = 27;
            this.dgv_chequera.SelectionChanged += new System.EventHandler(this.dgv_chequera_SelectionChanged);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(470, 360);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 26;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(389, 360);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 25;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(390, 67);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(156, 23);
            this.btn_eliminar.TabIndex = 24;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(390, 38);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(156, 23);
            this.btn_editar.TabIndex = 23;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(390, 9);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(156, 23);
            this.btn_nuevo.TabIndex = 22;
            this.btn_nuevo.Text = "Ingresar nueva";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // pnl_busqueda
            // 
            this.pnl_busqueda.Controls.Add(this.txt_busqueda);
            this.pnl_busqueda.Controls.Add(this.label2);
            this.pnl_busqueda.Location = new System.Drawing.Point(11, 9);
            this.pnl_busqueda.Name = "pnl_busqueda";
            this.pnl_busqueda.Size = new System.Drawing.Size(373, 26);
            this.pnl_busqueda.TabIndex = 21;
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Location = new System.Drawing.Point(85, 3);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(285, 20);
            this.txt_busqueda.TabIndex = 4;
            this.txt_busqueda.TextChanged += new System.EventHandler(this.txt_busqueda_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar banco:";
            // 
            // pnl_datos
            // 
            this.pnl_datos.Controls.Add(this.dtp_fecha);
            this.pnl_datos.Controls.Add(this.label4);
            this.pnl_datos.Controls.Add(this.txt_numeroInicial);
            this.pnl_datos.Controls.Add(this.chk_activa);
            this.pnl_datos.Controls.Add(this.txt_cantidad);
            this.pnl_datos.Controls.Add(this.label5);
            this.pnl_datos.Controls.Add(this.label3);
            this.pnl_datos.Controls.Add(this.label1);
            this.pnl_datos.Controls.Add(this.txt_cuenta);
            this.pnl_datos.Enabled = false;
            this.pnl_datos.Location = new System.Drawing.Point(11, 301);
            this.pnl_datos.Name = "pnl_datos";
            this.pnl_datos.Size = new System.Drawing.Size(373, 80);
            this.pnl_datos.TabIndex = 20;
            // 
            // chk_activa
            // 
            this.chk_activa.AutoSize = true;
            this.chk_activa.Checked = true;
            this.chk_activa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_activa.Location = new System.Drawing.Point(314, 58);
            this.chk_activa.Name = "chk_activa";
            this.chk_activa.Size = new System.Drawing.Size(56, 17);
            this.chk_activa.TabIndex = 9;
            this.chk_activa.Text = "Activa";
            this.chk_activa.UseVisualStyleBackColor = true;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(260, 55);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(50, 20);
            this.txt_cantidad.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cantidad de Cheques:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero Inicial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cuenta:";
            // 
            // txt_cuenta
            // 
            this.txt_cuenta.Location = new System.Drawing.Point(53, 3);
            this.txt_cuenta.Name = "txt_cuenta";
            this.txt_cuenta.ReadOnly = true;
            this.txt_cuenta.Size = new System.Drawing.Size(317, 20);
            this.txt_cuenta.TabIndex = 1;
            // 
            // dgv_cuenta
            // 
            this.dgv_cuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cuenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.banco,
            this.ctaNumero});
            this.dgv_cuenta.Location = new System.Drawing.Point(11, 41);
            this.dgv_cuenta.Name = "dgv_cuenta";
            this.dgv_cuenta.Size = new System.Drawing.Size(373, 116);
            this.dgv_cuenta.TabIndex = 19;
            this.dgv_cuenta.SelectionChanged += new System.EventHandler(this.dgv_cuenta_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 30;
            // 
            // banco
            // 
            this.banco.HeaderText = "Banco";
            this.banco.Name = "banco";
            this.banco.Width = 165;
            // 
            // ctaNumero
            // 
            this.ctaNumero.HeaderText = "Cuenta Numero";
            this.ctaNumero.Name = "ctaNumero";
            this.ctaNumero.Width = 165;
            // 
            // txt_numeroInicial
            // 
            this.txt_numeroInicial.Location = new System.Drawing.Point(86, 56);
            this.txt_numeroInicial.Name = "txt_numeroInicial";
            this.txt_numeroInicial.Size = new System.Drawing.Size(50, 20);
            this.txt_numeroInicial.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha de Recepcion:";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(117, 30);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(253, 20);
            this.dtp_fecha.TabIndex = 12;
            // 
            // idChequera
            // 
            this.idChequera.HeaderText = "ID";
            this.idChequera.Name = "idChequera";
            this.idChequera.Width = 30;
            // 
            // idCuenta
            // 
            this.idCuenta.HeaderText = "idCuenta";
            this.idCuenta.Name = "idCuenta";
            this.idCuenta.Visible = false;
            // 
            // inicial
            // 
            this.inicial.HeaderText = "Inicial";
            this.inicial.Name = "inicial";
            this.inicial.Visible = false;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 125;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.Width = 125;
            // 
            // activa
            // 
            this.activa.HeaderText = "Activa";
            this.activa.Name = "activa";
            this.activa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.activa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.activa.Width = 50;
            // 
            // chequera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 392);
            this.Controls.Add(this.dgv_chequera);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.pnl_busqueda);
            this.Controls.Add(this.pnl_datos);
            this.Controls.Add(this.dgv_cuenta);
            this.Name = "chequera";
            this.Text = "chequera";
            this.Load += new System.EventHandler(this.chequera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chequera)).EndInit();
            this.pnl_busqueda.ResumeLayout(false);
            this.pnl_busqueda.PerformLayout();
            this.pnl_datos.ResumeLayout(false);
            this.pnl_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_chequera;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Panel pnl_busqueda;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_datos;
        private System.Windows.Forms.CheckBox chk_activa;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cuenta;
        private System.Windows.Forms.DataGridView dgv_cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctaNumero;
        private System.Windows.Forms.TextBox txt_numeroInicial;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idChequera;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activa;
    }
}