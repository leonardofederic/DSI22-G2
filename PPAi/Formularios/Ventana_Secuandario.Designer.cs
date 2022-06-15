namespace PPAi.Formularios
{
    partial class Ventana_Secuandario
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grid_RT = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_NumeroRT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_NombreRT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_motivo = new System.Windows.Forms.ComboBox();
            this.txt_fechaPrevista = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_notificar = new System.Windows.Forms.ComboBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_RT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo Recurso Tecnologico :";
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Aceptar.Location = new System.Drawing.Point(668, 431);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(80, 27);
            this.Btn_Aceptar.TabIndex = 2;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.UseVisualStyleBackColor = false;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha Fin Prevista";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "N°Recursos Tecnológicos";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 50000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // grid_RT
            // 
            this.grid_RT.AllowUserToAddRows = false;
            this.grid_RT.AllowUserToDeleteRows = false;
            this.grid_RT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_RT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.grid_RT.Location = new System.Drawing.Point(12, 27);
            this.grid_RT.Name = "grid_RT";
            this.grid_RT.ReadOnly = true;
            this.grid_RT.Size = new System.Drawing.Size(694, 249);
            this.grid_RT.TabIndex = 8;
            this.grid_RT.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_RT_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tipo de Recurso";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Número RT";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Marca";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Modelo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // txt_NumeroRT
            // 
            this.txt_NumeroRT.Location = new System.Drawing.Point(187, 292);
            this.txt_NumeroRT.Name = "txt_NumeroRT";
            this.txt_NumeroRT.Size = new System.Drawing.Size(100, 20);
            this.txt_NumeroRT.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(342, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Recursos Tecnológicos";
            // 
            // txt_NombreRT
            // 
            this.txt_NombreRT.Location = new System.Drawing.Point(512, 292);
            this.txt_NombreRT.Name = "txt_NombreRT";
            this.txt_NombreRT.Size = new System.Drawing.Size(236, 20);
            this.txt_NombreRT.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(125, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Motivos";
            // 
            // cbx_motivo
            // 
            this.cbx_motivo.FormattingEnabled = true;
            this.cbx_motivo.Items.AddRange(new object[] {
            "Preventivo",
            "Mantenimiento Correctivo"});
            this.cbx_motivo.Location = new System.Drawing.Point(187, 331);
            this.cbx_motivo.Name = "cbx_motivo";
            this.cbx_motivo.Size = new System.Drawing.Size(148, 21);
            this.cbx_motivo.TabIndex = 15;
            // 
            // txt_fechaPrevista
            // 
            this.txt_fechaPrevista.Location = new System.Drawing.Point(512, 332);
            this.txt_fechaPrevista.Name = "txt_fechaPrevista";
            this.txt_fechaPrevista.Size = new System.Drawing.Size(200, 20);
            this.txt_fechaPrevista.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Forma de Notificar";
            // 
            // cbx_notificar
            // 
            this.cbx_notificar.FormattingEnabled = true;
            this.cbx_notificar.Items.AddRange(new object[] {
            "Email ",
            "Whatsapp"});
            this.cbx_notificar.Location = new System.Drawing.Point(187, 371);
            this.cbx_notificar.Name = "cbx_notificar";
            this.cbx_notificar.Size = new System.Drawing.Size(164, 21);
            this.cbx_notificar.TabIndex = 18;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.Location = new System.Drawing.Point(570, 431);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(80, 27);
            this.Btn_Cancelar.TabIndex = 19;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.Location = new System.Drawing.Point(472, 431);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(80, 27);
            this.Btn_Buscar.TabIndex = 20;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 231;
            this.label3.Text = "Hora";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(512, 4);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(84, 20);
            this.txtHora.TabIndex = 230;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(612, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 229;
            this.label8.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(662, 4);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(94, 20);
            this.txtFecha.TabIndex = 228;
            // 
            // Ventana_Secuandario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPAi.Properties.Resources._5;
            this.ClientSize = new System.Drawing.Size(763, 484);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.cbx_notificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_fechaPrevista);
            this.Controls.Add(this.cbx_motivo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_NombreRT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_NumeroRT);
            this.Controls.Add(this.grid_RT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.label1);
            this.Name = "Ventana_Secuandario";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_RT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView grid_RT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txt_NumeroRT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_NombreRT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_motivo;
        private System.Windows.Forms.DateTimePicker txt_fechaPrevista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_notificar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFecha;
    }
}