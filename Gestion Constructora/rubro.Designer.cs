﻿namespace Gestion_Constructora
{
    partial class rubro
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
            this.txt_rubro = new System.Windows.Forms.TextBox();
            this.dgv_rubro = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_busqueda.SuspendLayout();
            this.pnl_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rubro)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(471, 227);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 25;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(390, 227);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 24;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(390, 69);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(156, 23);
            this.btn_eliminar.TabIndex = 23;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(390, 40);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(156, 23);
            this.btn_editar.TabIndex = 22;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(390, 11);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(156, 23);
            this.btn_nuevo.TabIndex = 21;
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
            this.pnl_busqueda.TabIndex = 20;
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Location = new System.Drawing.Point(52, 3);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(318, 20);
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
            this.pnl_datos.Controls.Add(this.label1);
            this.pnl_datos.Controls.Add(this.txt_rubro);
            this.pnl_datos.Enabled = false;
            this.pnl_datos.Location = new System.Drawing.Point(11, 224);
            this.pnl_datos.Name = "pnl_datos";
            this.pnl_datos.Size = new System.Drawing.Size(373, 26);
            this.pnl_datos.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rubro:";
            // 
            // txt_rubro
            // 
            this.txt_rubro.Location = new System.Drawing.Point(48, 3);
            this.txt_rubro.Name = "txt_rubro";
            this.txt_rubro.Size = new System.Drawing.Size(322, 20);
            this.txt_rubro.TabIndex = 1;
            // 
            // dgv_rubro
            // 
            this.dgv_rubro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rubro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre});
            this.dgv_rubro.Location = new System.Drawing.Point(11, 43);
            this.dgv_rubro.Name = "dgv_rubro";
            this.dgv_rubro.Size = new System.Drawing.Size(373, 175);
            this.dgv_rubro.TabIndex = 18;
            this.dgv_rubro.SelectionChanged += new System.EventHandler(this.dgv_rubro_SelectionChanged);
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
            // rubro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 261);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.pnl_busqueda);
            this.Controls.Add(this.pnl_datos);
            this.Controls.Add(this.dgv_rubro);
            this.Name = "rubro";
            this.Text = "rubro";
            this.Load += new System.EventHandler(this.rubro_Load);
            this.pnl_busqueda.ResumeLayout(false);
            this.pnl_busqueda.PerformLayout();
            this.pnl_datos.ResumeLayout(false);
            this.pnl_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rubro)).EndInit();
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
        private System.Windows.Forms.TextBox txt_rubro;
        private System.Windows.Forms.DataGridView dgv_rubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
    }
}