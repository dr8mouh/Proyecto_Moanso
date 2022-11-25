
namespace SistemaProduccion.Crud
{
    partial class FrmCategoriaMueble
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
            this.btnMostrarRegistrosAnulados = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNumPersonas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvCategoriaMueble = new System.Windows.Forms.DataGridView();
            this.bntNuevo = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriaMueble)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarRegistrosAnulados
            // 
            this.btnMostrarRegistrosAnulados.Location = new System.Drawing.Point(881, -133);
            this.btnMostrarRegistrosAnulados.Name = "btnMostrarRegistrosAnulados";
            this.btnMostrarRegistrosAnulados.Size = new System.Drawing.Size(128, 54);
            this.btnMostrarRegistrosAnulados.TabIndex = 27;
            this.btnMostrarRegistrosAnulados.Text = "Mostar Registro anulados";
            this.btnMostrarRegistrosAnulados.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSeleccionarCliente);
            this.groupBox3.Controls.Add(this.txtIdCliente);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(530, 424);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(394, 147);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Validar Muble";
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(266, 24);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(104, 47);
            this.btnSeleccionarCliente.TabIndex = 3;
            this.btnSeleccionarCliente.Text = "Seleccionar Mueble";
            this.btnSeleccionarCliente.UseVisualStyleBackColor = true;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(144, 44);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 22);
            this.txtIdCliente.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "ID MUEBLE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtNumPersonas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 420);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 309);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Mueble";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(377, 174);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 45);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(377, 106);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(108, 45);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(377, 40);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 45);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Grabar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtNumPersonas
            // 
            this.txtNumPersonas.Location = new System.Drawing.Point(156, 115);
            this.txtNumPersonas.Name = "txtNumPersonas";
            this.txtNumPersonas.Size = new System.Drawing.Size(93, 22);
            this.txtNumPersonas.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CATEGORIA";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(156, 51);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(131, 22);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID CATEGORIA";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(901, 338);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 54);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(901, 219);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(128, 54);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(700, -133);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(128, 54);
            this.btnNuevo.TabIndex = 20;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvCategoriaMueble
            // 
            this.dgvCategoriaMueble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoriaMueble.Location = new System.Drawing.Point(3, 12);
            this.dgvCategoriaMueble.Name = "dgvCategoriaMueble";
            this.dgvCategoriaMueble.RowHeadersWidth = 51;
            this.dgvCategoriaMueble.RowTemplate.Height = 24;
            this.dgvCategoriaMueble.Size = new System.Drawing.Size(865, 402);
            this.dgvCategoriaMueble.TabIndex = 19;
            // 
            // bntNuevo
            // 
            this.bntNuevo.Location = new System.Drawing.Point(901, 12);
            this.bntNuevo.Name = "bntNuevo";
            this.bntNuevo.Size = new System.Drawing.Size(128, 54);
            this.bntNuevo.TabIndex = 28;
            this.bntNuevo.Text = "Nuevo";
            this.bntNuevo.UseVisualStyleBackColor = true;
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(901, 116);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(128, 54);
            this.btnAnular.TabIndex = 21;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            // 
            // FrmCategoriaMueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 760);
            this.Controls.Add(this.bntNuevo);
            this.Controls.Add(this.btnMostrarRegistrosAnulados);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvCategoriaMueble);
            this.Name = "FrmCategoriaMueble";
            this.Text = "FrmCategoriaMueble";
            this.Load += new System.EventHandler(this.FrmCategoriaMueble_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriaMueble)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarRegistrosAnulados;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSeleccionarCliente;
        public System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNumPersonas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvCategoriaMueble;
        private System.Windows.Forms.Button bntNuevo;
        private System.Windows.Forms.Button btnAnular;
    }
}