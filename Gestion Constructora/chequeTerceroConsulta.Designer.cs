namespace Gestion_Constructora
{
    partial class chequeTerceroConsulta
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
            this.banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_cartera = new System.Windows.Forms.CheckBox();
            this.chk_corriente = new System.Windows.Forms.CheckBox();
            this.chk_aCobrar = new System.Windows.Forms.CheckBox();
            this.chk_vencido = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_dias = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cheque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dias)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_cheque
            // 
            this.dgv_cheque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cheque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.banco,
            this.numero,
            this.importe,
            this.tipo,
            this.destino,
            this.fechaCobro});
            this.dgv_cheque.Location = new System.Drawing.Point(30, 57);
            this.dgv_cheque.Name = "dgv_cheque";
            this.dgv_cheque.Size = new System.Drawing.Size(732, 276);
            this.dgv_cheque.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 30;
            // 
            // banco
            // 
            this.banco.HeaderText = "Banco";
            this.banco.Name = "banco";
            this.banco.Width = 155;
            // 
            // numero
            // 
            this.numero.HeaderText = "Numero";
            this.numero.Name = "numero";
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            // 
            // destino
            // 
            this.destino.HeaderText = "Destino";
            this.destino.Name = "destino";
            // 
            // fechaCobro
            // 
            this.fechaCobro.HeaderText = "Fecha Cobro";
            this.fechaCobro.Name = "fechaCobro";
            // 
            // chk_cartera
            // 
            this.chk_cartera.AutoSize = true;
            this.chk_cartera.Location = new System.Drawing.Point(165, 32);
            this.chk_cartera.Name = "chk_cartera";
            this.chk_cartera.Size = new System.Drawing.Size(76, 17);
            this.chk_cartera.TabIndex = 1;
            this.chk_cartera.Text = "En Cartera";
            this.chk_cartera.UseVisualStyleBackColor = true;
            this.chk_cartera.CheckedChanged += new System.EventHandler(this.chk_cartera_CheckedChanged);
            // 
            // chk_corriente
            // 
            this.chk_corriente.AutoSize = true;
            this.chk_corriente.Location = new System.Drawing.Point(275, 32);
            this.chk_corriente.Name = "chk_corriente";
            this.chk_corriente.Size = new System.Drawing.Size(68, 17);
            this.chk_corriente.TabIndex = 2;
            this.chk_corriente.Text = "Corriente";
            this.chk_corriente.UseVisualStyleBackColor = true;
            this.chk_corriente.CheckedChanged += new System.EventHandler(this.chk_corriente_CheckedChanged);
            // 
            // chk_aCobrar
            // 
            this.chk_aCobrar.AutoSize = true;
            this.chk_aCobrar.Location = new System.Drawing.Point(3, 3);
            this.chk_aCobrar.Name = "chk_aCobrar";
            this.chk_aCobrar.Size = new System.Drawing.Size(15, 14);
            this.chk_aCobrar.TabIndex = 3;
            this.chk_aCobrar.UseVisualStyleBackColor = true;
            this.chk_aCobrar.CheckedChanged += new System.EventHandler(this.chk_aCobrar_CheckedChanged);
            // 
            // chk_vencido
            // 
            this.chk_vencido.AutoSize = true;
            this.chk_vencido.Location = new System.Drawing.Point(555, 32);
            this.chk_vencido.Name = "chk_vencido";
            this.chk_vencido.Size = new System.Drawing.Size(65, 17);
            this.chk_vencido.TabIndex = 4;
            this.chk_vencido.Text = "Vencido";
            this.chk_vencido.UseVisualStyleBackColor = true;
            this.chk_vencido.CheckedChanged += new System.EventHandler(this.chk_vencido_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "A cobrar en";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "dias";
            // 
            // nud_dias
            // 
            this.nud_dias.Enabled = false;
            this.nud_dias.Location = new System.Drawing.Point(92, 0);
            this.nud_dias.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nud_dias.Name = "nud_dias";
            this.nud_dias.Size = new System.Drawing.Size(43, 20);
            this.nud_dias.TabIndex = 7;
            this.nud_dias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_dias.ValueChanged += new System.EventHandler(this.nud_dias_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chk_aCobrar);
            this.panel1.Controls.Add(this.nud_dias);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(349, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 22);
            this.panel1.TabIndex = 8;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(703, 351);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 9;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total seleccionado:";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(401, 353);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 13;
            // 
            // chequeTerceroConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 386);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chk_vencido);
            this.Controls.Add(this.chk_corriente);
            this.Controls.Add(this.chk_cartera);
            this.Controls.Add(this.dgv_cheque);
            this.Name = "chequeTerceroConsulta";
            this.Text = "chequeTerceroConsulta";
            this.Load += new System.EventHandler(this.chequeTerceroConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cheque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dias)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cheque;
        private System.Windows.Forms.CheckBox chk_cartera;
        private System.Windows.Forms.CheckBox chk_corriente;
        private System.Windows.Forms.CheckBox chk_aCobrar;
        private System.Windows.Forms.CheckBox chk_vencido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_dias;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCobro;
    }
}