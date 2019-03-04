namespace Gestion_Constructora
{
    partial class bancoCuenta
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
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_datos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_banco = new System.Windows.Forms.TextBox();
            this.dgv_banco = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_cuenta = new System.Windows.Forms.DataGridView();
            this.cbo_tipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cbu = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.chk_activa = new System.Windows.Forms.CheckBox();
            this.idCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnl_busqueda.SuspendLayout();
            this.pnl_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuenta)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(470, 362);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(389, 362);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 16;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(390, 69);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(156, 23);
            this.btn_eliminar.TabIndex = 15;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(390, 40);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(156, 23);
            this.btn_editar.TabIndex = 14;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(390, 11);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(156, 23);
            this.btn_nuevo.TabIndex = 13;
            this.btn_nuevo.Text = "Ingresar nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // pnl_busqueda
            // 
            this.pnl_busqueda.Controls.Add(this.txt_busqueda);
            this.pnl_busqueda.Controls.Add(this.label2);
            this.pnl_busqueda.Location = new System.Drawing.Point(11, 11);
            this.pnl_busqueda.Name = "pnl_busqueda";
            this.pnl_busqueda.Size = new System.Drawing.Size(373, 26);
            this.pnl_busqueda.TabIndex = 12;
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
            this.pnl_datos.Controls.Add(this.chk_activa);
            this.pnl_datos.Controls.Add(this.txt_numero);
            this.pnl_datos.Controls.Add(this.txt_cbu);
            this.pnl_datos.Controls.Add(this.label4);
            this.pnl_datos.Controls.Add(this.label5);
            this.pnl_datos.Controls.Add(this.label3);
            this.pnl_datos.Controls.Add(this.cbo_tipo);
            this.pnl_datos.Controls.Add(this.label1);
            this.pnl_datos.Controls.Add(this.txt_banco);
            this.pnl_datos.Enabled = false;
            this.pnl_datos.Location = new System.Drawing.Point(11, 303);
            this.pnl_datos.Name = "pnl_datos";
            this.pnl_datos.Size = new System.Drawing.Size(373, 80);
            this.pnl_datos.TabIndex = 11;
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
            this.txt_banco.Size = new System.Drawing.Size(121, 20);
            this.txt_banco.TabIndex = 1;
            // 
            // dgv_banco
            // 
            this.dgv_banco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_banco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre});
            this.dgv_banco.Location = new System.Drawing.Point(11, 43);
            this.dgv_banco.Name = "dgv_banco";
            this.dgv_banco.Size = new System.Drawing.Size(373, 116);
            this.dgv_banco.TabIndex = 10;
            this.dgv_banco.SelectionChanged += new System.EventHandler(this.dgv_banco_SelectionChanged);
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
            this.nombre.Width = 300;
            // 
            // dgv_cuenta
            // 
            this.dgv_cuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cuenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCuenta,
            this.idBanco,
            this.tipo,
            this.numero,
            this.cbu,
            this.activa});
            this.dgv_cuenta.Location = new System.Drawing.Point(11, 166);
            this.dgv_cuenta.Name = "dgv_cuenta";
            this.dgv_cuenta.Size = new System.Drawing.Size(373, 131);
            this.dgv_cuenta.TabIndex = 18;
            this.dgv_cuenta.SelectionChanged += new System.EventHandler(this.dgv_cuenta_SelectionChanged);
            // 
            // cbo_tipo
            // 
            this.cbo_tipo.FormattingEnabled = true;
            this.cbo_tipo.Items.AddRange(new object[] {
            "CAJA DE AHORROS PESOS",
            "CUENTA CORRIENTE PESOS",
            "CAJA DE AHORROS DOLARES",
            "CUENTA CORRIENTE DOLARES"});
            this.cbo_tipo.Location = new System.Drawing.Point(214, 3);
            this.cbo_tipo.Name = "cbo_tipo";
            this.cbo_tipo.Size = new System.Drawing.Size(156, 21);
            this.cbo_tipo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "CBU:";
            // 
            // txt_cbu
            // 
            this.txt_cbu.Location = new System.Drawing.Point(41, 30);
            this.txt_cbu.Name = "txt_cbu";
            this.txt_cbu.Size = new System.Drawing.Size(329, 20);
            this.txt_cbu.TabIndex = 7;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(56, 56);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(252, 20);
            this.txt_numero.TabIndex = 8;
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
            // idCuenta
            // 
            this.idCuenta.HeaderText = "ID";
            this.idCuenta.Name = "idCuenta";
            this.idCuenta.Width = 30;
            // 
            // idBanco
            // 
            this.idBanco.HeaderText = "idBanco";
            this.idBanco.Name = "idBanco";
            this.idBanco.Visible = false;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.Width = 250;
            // 
            // numero
            // 
            this.numero.HeaderText = "Numero";
            this.numero.Name = "numero";
            this.numero.Visible = false;
            // 
            // cbu
            // 
            this.cbu.HeaderText = "CBU";
            this.cbu.Name = "cbu";
            this.cbu.Visible = false;
            // 
            // activa
            // 
            this.activa.HeaderText = "Activa";
            this.activa.Name = "activa";
            this.activa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.activa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.activa.Width = 50;
            // 
            // bancoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 392);
            this.Controls.Add(this.dgv_cuenta);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.pnl_busqueda);
            this.Controls.Add(this.pnl_datos);
            this.Controls.Add(this.dgv_banco);
            this.Name = "bancoCuenta";
            this.Text = "cuentaBanco";
            this.Load += new System.EventHandler(this.bancoCuenta_Load);
            this.pnl_busqueda.ResumeLayout(false);
            this.pnl_busqueda.PerformLayout();
            this.pnl_datos.ResumeLayout(false);
            this.pnl_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Panel pnl_busqueda;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_datos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_banco;
        private System.Windows.Forms.DataGridView dgv_banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridView dgv_cuenta;
        private System.Windows.Forms.CheckBox chk_activa;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_cbu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activa;
    }
}