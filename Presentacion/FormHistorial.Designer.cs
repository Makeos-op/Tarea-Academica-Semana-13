namespace Presentacion
{
    partial class FormHistorial
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
            this.dgHistorial = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Registrar = new System.Windows.Forms.Button();
            this.TB_CodigoEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Inicio = new System.Windows.Forms.DateTimePicker();
            this.Fin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgHistorial
            // 
            this.dgHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistorial.Location = new System.Drawing.Point(306, 43);
            this.dgHistorial.Name = "dgHistorial";
            this.dgHistorial.RowHeadersWidth = 51;
            this.dgHistorial.RowTemplate.Height = 24;
            this.dgHistorial.Size = new System.Drawing.Size(469, 239);
            this.dgHistorial.TabIndex = 21;
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(122, 245);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 20;
            this.Eliminar.Text = "button3";
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(171, 201);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 19;
            this.Modificar.Text = "button2";
            this.Modificar.UseVisualStyleBackColor = true;
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(72, 201);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(75, 23);
            this.Registrar.TabIndex = 18;
            this.Registrar.Text = "button1";
            this.Registrar.UseVisualStyleBackColor = true;
            // 
            // TB_CodigoEmpleado
            // 
            this.TB_CodigoEmpleado.Location = new System.Drawing.Point(72, 72);
            this.TB_CodigoEmpleado.Name = "TB_CodigoEmpleado";
            this.TB_CodigoEmpleado.Size = new System.Drawing.Size(195, 22);
            this.TB_CodigoEmpleado.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // Inicio
            // 
            this.Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Inicio.Location = new System.Drawing.Point(72, 115);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(110, 22);
            this.Inicio.TabIndex = 25;
            // 
            // Fin
            // 
            this.Fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fin.Location = new System.Drawing.Point(72, 145);
            this.Fin.Name = "Fin";
            this.Fin.Size = new System.Drawing.Size(110, 22);
            this.Fin.TabIndex = 26;
            // 
            // FormHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 309);
            this.Controls.Add(this.Fin);
            this.Controls.Add(this.Inicio);
            this.Controls.Add(this.dgHistorial);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.TB_CodigoEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHistorial";
            this.Text = "FormHistorial";
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgHistorial;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.TextBox TB_CodigoEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Inicio;
        private System.Windows.Forms.DateTimePicker Fin;
    }
}