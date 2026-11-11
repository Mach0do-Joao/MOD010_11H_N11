namespace GestaoEquipamentos.Interface
{
    partial class FormEquipamento
    {
        /// <summary>
        /// Variável necessária para o Designer.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão a ser utilizados.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblNumeroSerie = new System.Windows.Forms.Label();
            this.txtNumeroSerie = new System.Windows.Forms.TextBox();
            this.lblSala = new System.Windows.Forms.Label();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.nudAno = new System.Windows.Forms.NumericUpDown();
            this.lblPreco = new System.Windows.Forms.Label();
            this.nudPreco = new System.Windows.Forms.NumericUpDown();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.grpComputador = new System.Windows.Forms.GroupBox();
            this.lblRam = new System.Windows.Forms.Label();
            this.nudRam = new System.Windows.Forms.NumericUpDown();
            this.chkSSD = new System.Windows.Forms.CheckBox();
            this.grpImpressora = new System.Windows.Forms.GroupBox();
            this.chkCores = new System.Windows.Forms.CheckBox();
            this.grpProjetor = new System.Windows.Forms.GroupBox();
            this.lblLumens = new System.Windows.Forms.Label();
            this.nudLumens = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).BeginInit();
            this.grpComputador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRam)).BeginInit();
            this.grpImpressora.SuspendLayout();
            this.grpProjetor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLumens)).BeginInit();
            this.SuspendLayout();
            //
            // lblTipo
            //
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(15, 21);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(33, 15);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            //
            // cmbTipo
            //
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Enabled = false;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Computador",
            "Impressora",
            "Projetor"});
            this.cmbTipo.Location = new System.Drawing.Point(130, 17);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(150, 23);
            this.cmbTipo.TabIndex = 1;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            //
            // lblMarca
            //
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(15, 54);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(43, 15);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca:";
            //
            // txtMarca
            //
            this.txtMarca.Location = new System.Drawing.Point(130, 50);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(150, 23);
            this.txtMarca.TabIndex = 3;
            //
            // lblModelo
            //
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(15, 87);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(51, 15);
            this.lblModelo.TabIndex = 4;
            this.lblModelo.Text = "Modelo:";
            //
            // txtModelo
            //
            this.txtModelo.Location = new System.Drawing.Point(130, 83);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(150, 23);
            this.txtModelo.TabIndex = 5;
            //
            // lblNumeroSerie
            //
            this.lblNumeroSerie.AutoSize = true;
            this.lblNumeroSerie.Location = new System.Drawing.Point(15, 120);
            this.lblNumeroSerie.Name = "lblNumeroSerie";
            this.lblNumeroSerie.Size = new System.Drawing.Size(73, 15);
            this.lblNumeroSerie.TabIndex = 6;
            this.lblNumeroSerie.Text = "N.º de série:";
            //
            // txtNumeroSerie
            //
            this.txtNumeroSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroSerie.Location = new System.Drawing.Point(130, 116);
            this.txtNumeroSerie.Name = "txtNumeroSerie";
            this.txtNumeroSerie.Size = new System.Drawing.Size(150, 23);
            this.txtNumeroSerie.TabIndex = 7;
            //
            // lblSala
            //
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(15, 153);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(31, 15);
            this.lblSala.TabIndex = 8;
            this.lblSala.Text = "Sala:";
            //
            // txtSala
            //
            this.txtSala.Location = new System.Drawing.Point(130, 149);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(150, 23);
            this.txtSala.TabIndex = 9;
            //
            // lblAno
            //
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(15, 186);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(103, 15);
            this.lblAno.TabIndex = 10;
            this.lblAno.Text = "Ano de aquisição:";
            //
            // nudAno
            //
            this.nudAno.Location = new System.Drawing.Point(130, 182);
            this.nudAno.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudAno.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.nudAno.Name = "nudAno";
            this.nudAno.Size = new System.Drawing.Size(80, 23);
            this.nudAno.TabIndex = 11;
            this.nudAno.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            //
            // lblPreco
            //
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(15, 219);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(105, 15);
            this.lblPreco.TabIndex = 12;
            this.lblPreco.Text = "Preço de compra €:";
            //
            // nudPreco
            //
            this.nudPreco.DecimalPlaces = 2;
            this.nudPreco.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPreco.Location = new System.Drawing.Point(130, 215);
            this.nudPreco.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPreco.Name = "nudPreco";
            this.nudPreco.Size = new System.Drawing.Size(100, 23);
            this.nudPreco.TabIndex = 13;
            this.nudPreco.ThousandsSeparator = true;
            //
            // lblEstado
            //
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(15, 252);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 15);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado:";
            //
            // cmbEstado
            //
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Enabled = false;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(130, 248);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(150, 23);
            this.cmbEstado.TabIndex = 15;
            //
            // grpComputador
            //
            this.grpComputador.Controls.Add(this.chkSSD);
            this.grpComputador.Controls.Add(this.nudRam);
            this.grpComputador.Controls.Add(this.lblRam);
            this.grpComputador.Enabled = false;
            this.grpComputador.Location = new System.Drawing.Point(305, 12);
            this.grpComputador.Name = "grpComputador";
            this.grpComputador.Size = new System.Drawing.Size(240, 90);
            this.grpComputador.TabIndex = 16;
            this.grpComputador.TabStop = false;
            this.grpComputador.Text = "Computador";
            //
            // lblRam
            //
            this.lblRam.AutoSize = true;
            this.lblRam.Location = new System.Drawing.Point(12, 28);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(84, 15);
            this.lblRam.TabIndex = 0;
            this.lblRam.Text = "Memória (GB):";
            //
            // nudRam
            //
            this.nudRam.Location = new System.Drawing.Point(110, 24);
            this.nudRam.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nudRam.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRam.Name = "nudRam";
            this.nudRam.Size = new System.Drawing.Size(70, 23);
            this.nudRam.TabIndex = 1;
            this.nudRam.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            //
            // chkSSD
            //
            this.chkSSD.AutoSize = true;
            this.chkSSD.Checked = true;
            this.chkSSD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSSD.Location = new System.Drawing.Point(15, 58);
            this.chkSSD.Name = "chkSSD";
            this.chkSSD.Size = new System.Drawing.Size(77, 19);
            this.chkSSD.TabIndex = 2;
            this.chkSSD.Text = "Disco SSD";
            this.chkSSD.UseVisualStyleBackColor = true;
            //
            // grpImpressora
            //
            this.grpImpressora.Controls.Add(this.chkCores);
            this.grpImpressora.Enabled = false;
            this.grpImpressora.Location = new System.Drawing.Point(305, 110);
            this.grpImpressora.Name = "grpImpressora";
            this.grpImpressora.Size = new System.Drawing.Size(240, 60);
            this.grpImpressora.TabIndex = 17;
            this.grpImpressora.TabStop = false;
            this.grpImpressora.Text = "Impressora";
            //
            // chkCores
            //
            this.chkCores.AutoSize = true;
            this.chkCores.Location = new System.Drawing.Point(15, 26);
            this.chkCores.Name = "chkCores";
            this.chkCores.Size = new System.Drawing.Size(108, 19);
            this.chkCores.TabIndex = 0;
            this.chkCores.Text = "Imprime a cores";
            this.chkCores.UseVisualStyleBackColor = true;
            //
            // grpProjetor
            //
            this.grpProjetor.Controls.Add(this.nudLumens);
            this.grpProjetor.Controls.Add(this.lblLumens);
            this.grpProjetor.Enabled = false;
            this.grpProjetor.Location = new System.Drawing.Point(305, 178);
            this.grpProjetor.Name = "grpProjetor";
            this.grpProjetor.Size = new System.Drawing.Size(240, 60);
            this.grpProjetor.TabIndex = 18;
            this.grpProjetor.TabStop = false;
            this.grpProjetor.Text = "Projetor";
            //
            // lblLumens
            //
            this.lblLumens.AutoSize = true;
            this.lblLumens.Location = new System.Drawing.Point(12, 27);
            this.lblLumens.Name = "lblLumens";
            this.lblLumens.Size = new System.Drawing.Size(50, 15);
            this.lblLumens.TabIndex = 0;
            this.lblLumens.Text = "Lumens:";
            //
            // nudLumens
            //
            this.nudLumens.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudLumens.Location = new System.Drawing.Point(110, 23);
            this.nudLumens.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudLumens.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudLumens.Name = "nudLumens";
            this.nudLumens.Size = new System.Drawing.Size(90, 23);
            this.nudLumens.TabIndex = 1;
            this.nudLumens.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            //
            // btnGuardar
            //
            this.btnGuardar.Location = new System.Drawing.Point(335, 290);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            //
            // btnCancelar
            //
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(445, 290);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            //
            // FormEquipamento
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(560, 335);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grpProjetor);
            this.Controls.Add(this.grpImpressora);
            this.Controls.Add(this.grpComputador);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.nudPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.nudAno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.txtNumeroSerie);
            this.Controls.Add(this.lblNumeroSerie);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblTipo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEquipamento";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Equipamento";
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).EndInit();
            this.grpComputador.ResumeLayout(false);
            this.grpComputador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRam)).EndInit();
            this.grpImpressora.ResumeLayout(false);
            this.grpImpressora.PerformLayout();
            this.grpProjetor.ResumeLayout(false);
            this.grpProjetor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLumens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblNumeroSerie;
        private System.Windows.Forms.TextBox txtNumeroSerie;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.NumericUpDown nudAno;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.NumericUpDown nudPreco;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.GroupBox grpComputador;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.NumericUpDown nudRam;
        private System.Windows.Forms.CheckBox chkSSD;
        private System.Windows.Forms.GroupBox grpImpressora;
        private System.Windows.Forms.CheckBox chkCores;
        private System.Windows.Forms.GroupBox grpProjetor;
        private System.Windows.Forms.Label lblLumens;
        private System.Windows.Forms.NumericUpDown nudLumens;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
