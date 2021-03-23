
namespace PARCIAL1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtgTabla = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(109, 78);
            this.txtEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(132, 22);
            this.txtEmpleado.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(109, 145);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(317, 78);
            this.txtDui.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(132, 22);
            this.txtDui.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(317, 145);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(132, 22);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(533, 78);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(533, 145);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(132, 22);
            this.txtCargo.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(109, 208);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(132, 22);
            this.txtApellido.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id_empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Empl_email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Empl_DUI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Emple_direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Empl_nombre";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(317, 208);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(132, 22);
            this.txtTelefono.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(529, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Empl_cargo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Empl_tel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 188);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Empl_apellido";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(109, 257);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dtgTabla
            // 
            this.dtgTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNombre,
            this.ColumnApellido,
            this.ColumnDui,
            this.ColumnEmail,
            this.ColumnTelefono,
            this.ColumnDireccion,
            this.ColumnCargo});
            this.dtgTabla.Location = new System.Drawing.Point(13, 310);
            this.dtgTabla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgTabla.Name = "dtgTabla";
            this.dtgTabla.RowHeadersWidth = 51;
            this.dtgTabla.Size = new System.Drawing.Size(1025, 185);
            this.dtgTabla.TabIndex = 20;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.MinimumWidth = 6;
            this.ColumnNombre.Name = "ColumnNombre";
            // 
            // ColumnApellido
            // 
            this.ColumnApellido.HeaderText = "Apellido";
            this.ColumnApellido.MinimumWidth = 6;
            this.ColumnApellido.Name = "ColumnApellido";
            // 
            // ColumnDui
            // 
            this.ColumnDui.HeaderText = "DUI";
            this.ColumnDui.MinimumWidth = 6;
            this.ColumnDui.Name = "ColumnDui";
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.MinimumWidth = 6;
            this.ColumnEmail.Name = "ColumnEmail";
            // 
            // ColumnTelefono
            // 
            this.ColumnTelefono.HeaderText = "Telefono";
            this.ColumnTelefono.MinimumWidth = 6;
            this.ColumnTelefono.Name = "ColumnTelefono";
            // 
            // ColumnDireccion
            // 
            this.ColumnDireccion.HeaderText = "Direcion";
            this.ColumnDireccion.MinimumWidth = 6;
            this.ColumnDireccion.Name = "ColumnDireccion";
            // 
            // ColumnCargo
            // 
            this.ColumnCargo.HeaderText = "Cargo";
            this.ColumnCargo.MinimumWidth = 6;
            this.ColumnCargo.Name = "ColumnCargo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 494);
            this.Controls.Add(this.dtgTabla);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtEmpleado);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dtgTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDui;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCargo;
    }
}

