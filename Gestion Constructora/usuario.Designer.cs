namespace Gestion_Constructora
{
    partial class usuario
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
            this.pnl_busqueda = new System.Windows.Forms.Panel();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_datos = new System.Windows.Forms.Panel();
            this.cbo_nivel = new System.Windows.Forms.ComboBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_confirma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_usuario = new System.Windows.Forms.DataGridView();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_buscarTodo = new System.Windows.Forms.CheckBox();
            this.pnl_busqueda.SuspendLayout();
            this.pnl_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(470, 254);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(389, 254);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 16;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(390, 40);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(156, 23);
            this.btn_eliminar.TabIndex = 15;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(390, 11);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(156, 23);
            this.btn_editar.TabIndex = 14;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // pnl_busqueda
            // 
            this.pnl_busqueda.Controls.Add(this.chk_buscarTodo);
            this.pnl_busqueda.Controls.Add(this.txt_busqueda);
            this.pnl_busqueda.Controls.Add(this.label2);
            this.pnl_busqueda.Location = new System.Drawing.Point(11, 11);
            this.pnl_busqueda.Name = "pnl_busqueda";
            this.pnl_busqueda.Size = new System.Drawing.Size(373, 26);
            this.pnl_busqueda.TabIndex = 12;
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Location = new System.Drawing.Point(52, 3);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(229, 20);
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
            this.pnl_datos.Controls.Add(this.txt_password);
            this.pnl_datos.Controls.Add(this.label1);
            this.pnl_datos.Controls.Add(this.cbo_nivel);
            this.pnl_datos.Controls.Add(this.txt_usuario);
            this.pnl_datos.Controls.Add(this.txt_confirma);
            this.pnl_datos.Controls.Add(this.label7);
            this.pnl_datos.Controls.Add(this.label6);
            this.pnl_datos.Controls.Add(this.label5);
            this.pnl_datos.Enabled = false;
            this.pnl_datos.Location = new System.Drawing.Point(11, 224);
            this.pnl_datos.Name = "pnl_datos";
            this.pnl_datos.Size = new System.Drawing.Size(373, 53);
            this.pnl_datos.TabIndex = 11;
            // 
            // cbo_nivel
            // 
            this.cbo_nivel.FormattingEnabled = true;
            this.cbo_nivel.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.cbo_nivel.Location = new System.Drawing.Point(326, 3);
            this.cbo_nivel.Name = "cbo_nivel";
            this.cbo_nivel.Size = new System.Drawing.Size(43, 21);
            this.cbo_nivel.TabIndex = 12;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(52, 3);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(175, 20);
            this.txt_usuario.TabIndex = 11;
            // 
            // txt_confirma
            // 
            this.txt_confirma.Location = new System.Drawing.Point(240, 29);
            this.txt_confirma.Name = "txt_confirma";
            this.txt_confirma.PasswordChar = '●';
            this.txt_confirma.Size = new System.Drawing.Size(130, 20);
            this.txt_confirma.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nivel de Acceso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Confirme:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Usuario:";
            // 
            // dgv_usuario
            // 
            this.dgv_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.user,
            this.nivel});
            this.dgv_usuario.Location = new System.Drawing.Point(11, 43);
            this.dgv_usuario.Name = "dgv_usuario";
            this.dgv_usuario.Size = new System.Drawing.Size(373, 175);
            this.dgv_usuario.TabIndex = 18;
            this.dgv_usuario.SelectionChanged += new System.EventHandler(this.dgv_usuario_SelectionChanged);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(67, 29);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.Size = new System.Drawing.Size(110, 20);
            this.txt_password.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Password:";
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
            // user
            // 
            this.user.HeaderText = "Usuario";
            this.user.Name = "user";
            // 
            // nivel
            // 
            this.nivel.HeaderText = "Nivel";
            this.nivel.Name = "nivel";
            this.nivel.Visible = false;
            // 
            // chk_buscarTodo
            // 
            this.chk_buscarTodo.AutoSize = true;
            this.chk_buscarTodo.Location = new System.Drawing.Point(287, 5);
            this.chk_buscarTodo.Name = "chk_buscarTodo";
            this.chk_buscarTodo.Size = new System.Drawing.Size(83, 17);
            this.chk_buscarTodo.TabIndex = 5;
            this.chk_buscarTodo.Text = "Buscar todo";
            this.chk_buscarTodo.UseVisualStyleBackColor = true;
            this.chk_buscarTodo.CheckedChanged += new System.EventHandler(this.chk_usuario_CheckedChanged);
            // 
            // usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 289);
            this.Controls.Add(this.dgv_usuario);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.pnl_busqueda);
            this.Controls.Add(this.pnl_datos);
            this.Name = "usuario";
            this.Text = "usuario";
            this.Load += new System.EventHandler(this.usuario_Load);
            this.pnl_busqueda.ResumeLayout(false);
            this.pnl_busqueda.PerformLayout();
            this.pnl_datos.ResumeLayout(false);
            this.pnl_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Panel pnl_busqueda;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_datos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_nivel;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_confirma;
        private System.Windows.Forms.DataGridView dgv_usuario;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivel;
        private System.Windows.Forms.CheckBox chk_buscarTodo;
    }
}