namespace Gestion_Constructora
{
    partial class contrato
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
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.dgv_contrato = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_arquitectoNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_arquitectoMatricula = new System.Windows.Forms.TextBox();
            this.txt_arquitectoDomicilio = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arquitectoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arquitectoMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arquitectoDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_busquedaPersona = new System.Windows.Forms.Button();
            this.txt_persona = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_busqueda.SuspendLayout();
            this.pnl_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contrato)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(470, 308);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(389, 308);
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
            this.txt_busqueda.Location = new System.Drawing.Point(105, 3);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(265, 20);
            this.txt_busqueda.TabIndex = 4;
            this.txt_busqueda.TextChanged += new System.EventHandler(this.txt_busqueda_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar por Cliente:";
            // 
            // pnl_datos
            // 
            this.pnl_datos.Controls.Add(this.btn_busquedaPersona);
            this.pnl_datos.Controls.Add(this.txt_persona);
            this.pnl_datos.Controls.Add(this.label6);
            this.pnl_datos.Controls.Add(this.txt_arquitectoDomicilio);
            this.pnl_datos.Controls.Add(this.txt_arquitectoMatricula);
            this.pnl_datos.Controls.Add(this.label5);
            this.pnl_datos.Controls.Add(this.label4);
            this.pnl_datos.Controls.Add(this.label3);
            this.pnl_datos.Controls.Add(this.txt_arquitectoNombre);
            this.pnl_datos.Controls.Add(this.label1);
            this.pnl_datos.Controls.Add(this.txt_numero);
            this.pnl_datos.Enabled = false;
            this.pnl_datos.Location = new System.Drawing.Point(11, 224);
            this.pnl_datos.Name = "pnl_datos";
            this.pnl_datos.Size = new System.Drawing.Size(373, 110);
            this.pnl_datos.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero:";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(52, 32);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(63, 20);
            this.txt_numero.TabIndex = 1;
            // 
            // dgv_contrato
            // 
            this.dgv_contrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_contrato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idCliente,
            this.Cliente,
            this.Numero,
            this.arquitectoNombre,
            this.arquitectoMatricula,
            this.arquitectoDomicilio});
            this.dgv_contrato.Location = new System.Drawing.Point(11, 43);
            this.dgv_contrato.Name = "dgv_contrato";
            this.dgv_contrato.Size = new System.Drawing.Size(373, 175);
            this.dgv_contrato.TabIndex = 10;
            this.dgv_contrato.SelectionChanged += new System.EventHandler(this.dgv_contrato_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Arquitecto Nombre:";
            // 
            // txt_arquitectoNombre
            // 
            this.txt_arquitectoNombre.Location = new System.Drawing.Point(107, 58);
            this.txt_arquitectoNombre.Name = "txt_arquitectoNombre";
            this.txt_arquitectoNombre.Size = new System.Drawing.Size(263, 20);
            this.txt_arquitectoNombre.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Arquitecto Matricula:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Arquitecto Domicilio:";
            // 
            // txt_arquitectoMatricula
            // 
            this.txt_arquitectoMatricula.Location = new System.Drawing.Point(225, 32);
            this.txt_arquitectoMatricula.Name = "txt_arquitectoMatricula";
            this.txt_arquitectoMatricula.Size = new System.Drawing.Size(145, 20);
            this.txt_arquitectoMatricula.TabIndex = 7;
            // 
            // txt_arquitectoDomicilio
            // 
            this.txt_arquitectoDomicilio.Location = new System.Drawing.Point(107, 84);
            this.txt_arquitectoDomicilio.Name = "txt_arquitectoDomicilio";
            this.txt_arquitectoDomicilio.Size = new System.Drawing.Size(263, 20);
            this.txt_arquitectoDomicilio.TabIndex = 8;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 30;
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "idCliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.Visible = false;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.Width = 200;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            // 
            // arquitectoNombre
            // 
            this.arquitectoNombre.HeaderText = "arquitectoNombre";
            this.arquitectoNombre.Name = "arquitectoNombre";
            this.arquitectoNombre.Visible = false;
            // 
            // arquitectoMatricula
            // 
            this.arquitectoMatricula.HeaderText = "arquitectoMatricula";
            this.arquitectoMatricula.Name = "arquitectoMatricula";
            this.arquitectoMatricula.Visible = false;
            // 
            // arquitectoDomicilio
            // 
            this.arquitectoDomicilio.HeaderText = "arquitectoDomicilio";
            this.arquitectoDomicilio.Name = "arquitectoDomicilio";
            this.arquitectoDomicilio.Visible = false;
            // 
            // btn_busquedaPersona
            // 
            this.btn_busquedaPersona.Location = new System.Drawing.Point(279, 4);
            this.btn_busquedaPersona.Name = "btn_busquedaPersona";
            this.btn_busquedaPersona.Size = new System.Drawing.Size(91, 24);
            this.btn_busquedaPersona.TabIndex = 11;
            this.btn_busquedaPersona.Text = "Buscar Cliente";
            this.btn_busquedaPersona.UseVisualStyleBackColor = true;
            this.btn_busquedaPersona.Click += new System.EventHandler(this.btn_busquedaPersona_Click);
            // 
            // txt_persona
            // 
            this.txt_persona.Enabled = false;
            this.txt_persona.Location = new System.Drawing.Point(52, 6);
            this.txt_persona.Name = "txt_persona";
            this.txt_persona.Size = new System.Drawing.Size(221, 20);
            this.txt_persona.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cliente:";
            // 
            // contrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 342);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.pnl_busqueda);
            this.Controls.Add(this.pnl_datos);
            this.Controls.Add(this.dgv_contrato);
            this.Name = "contrato";
            this.Text = "contrato";
            this.Load += new System.EventHandler(this.contrato_Load);
            this.pnl_busqueda.ResumeLayout(false);
            this.pnl_busqueda.PerformLayout();
            this.pnl_datos.ResumeLayout(false);
            this.pnl_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contrato)).EndInit();
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
        private System.Windows.Forms.TextBox txt_arquitectoDomicilio;
        private System.Windows.Forms.TextBox txt_arquitectoMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_arquitectoNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.DataGridView dgv_contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn arquitectoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn arquitectoMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn arquitectoDomicilio;
        private System.Windows.Forms.Button btn_busquedaPersona;
        private System.Windows.Forms.TextBox txt_persona;
        private System.Windows.Forms.Label label6;
    }
}