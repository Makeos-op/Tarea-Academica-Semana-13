namespace Presentacion
{
    partial class FormEmpleos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_nombre = new System.Windows.Forms.TextBox();
            this.TB_salariomin = new System.Windows.Forms.TextBox();
            this.TB_salariomax = new System.Windows.Forms.TextBox();
            this.Registrar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.dgEmpleos = new System.Windows.Forms.DataGridView();
            this.Historial_Empleos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // TB_nombre
            // 
            this.TB_nombre.Location = new System.Drawing.Point(74, 70);
            this.TB_nombre.Name = "TB_nombre";
            this.TB_nombre.Size = new System.Drawing.Size(195, 22);
            this.TB_nombre.TabIndex = 3;
            // 
            // TB_salariomin
            // 
            this.TB_salariomin.Location = new System.Drawing.Point(74, 107);
            this.TB_salariomin.Name = "TB_salariomin";
            this.TB_salariomin.Size = new System.Drawing.Size(195, 22);
            this.TB_salariomin.TabIndex = 4;
            // 
            // TB_salariomax
            // 
            this.TB_salariomax.Location = new System.Drawing.Point(74, 145);
            this.TB_salariomax.Name = "TB_salariomax";
            this.TB_salariomax.Size = new System.Drawing.Size(195, 22);
            this.TB_salariomax.TabIndex = 5;
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(74, 181);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(75, 23);
            this.Registrar.TabIndex = 6;
            this.Registrar.Text = "button1";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(175, 181);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 7;
            this.Modificar.Text = "button2";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(74, 224);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 8;
            this.Eliminar.Text = "button3";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // dgEmpleos
            // 
            this.dgEmpleos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleos.Location = new System.Drawing.Point(308, 41);
            this.dgEmpleos.Name = "dgEmpleos";
            this.dgEmpleos.RowHeadersWidth = 51;
            this.dgEmpleos.RowTemplate.Height = 24;
            this.dgEmpleos.Size = new System.Drawing.Size(469, 239);
            this.dgEmpleos.TabIndex = 9;
            // 
            // Historial_Empleos
            // 
            this.Historial_Empleos.Location = new System.Drawing.Point(175, 224);
            this.Historial_Empleos.Name = "Historial_Empleos";
            this.Historial_Empleos.Size = new System.Drawing.Size(75, 23);
            this.Historial_Empleos.TabIndex = 10;
            this.Historial_Empleos.Text = "button4";
            this.Historial_Empleos.UseVisualStyleBackColor = true;
            this.Historial_Empleos.Click += new System.EventHandler(this.Historial_Empleos_Click);
            // 
            // FormEmpleos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 298);
            this.Controls.Add(this.Historial_Empleos);
            this.Controls.Add(this.dgEmpleos);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.TB_salariomax);
            this.Controls.Add(this.TB_salariomin);
            this.Controls.Add(this.TB_nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEmpleos";
            this.Text = "FormEmpleos";
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_nombre;
        private System.Windows.Forms.TextBox TB_salariomin;
        private System.Windows.Forms.TextBox TB_salariomax;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.DataGridView dgEmpleos;
        private System.Windows.Forms.Button Historial_Empleos;
    }
}