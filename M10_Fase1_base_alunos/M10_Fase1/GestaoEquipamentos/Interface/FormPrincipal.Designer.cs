namespace GestaoEquipamentos.Interface
{
    partial class FormPrincipal
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
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.lblFiltroEstado = new System.Windows.Forms.Label();
            this.cmbFiltroEstado = new System.Windows.Forms.ComboBox();
            this.btnImpressorasCores = new System.Windows.Forms.Button();
            this.btnPoucaRam = new System.Windows.Forms.Button();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.btnAlterarResponsavel = new System.Windows.Forms.Button();
            this.lvEquipamentos = new System.Windows.Forms.ListView();
            this.colId = new System.Windows.Forms.ColumnHeader();
            this.colTipo = new System.Windows.Forms.ColumnHeader();
            this.colMarca = new System.Windows.Forms.ColumnHeader();
            this.colModelo = new System.Windows.Forms.ColumnHeader();
            this.colNumeroSerie = new System.Windows.Forms.ColumnHeader();
            this.colSala = new System.Windows.Forms.ColumnHeader();
            this.colAno = new System.Windows.Forms.ColumnHeader();
            this.colPreco = new System.Windows.Forms.ColumnHeader();
            this.colEstado = new System.Windows.Forms.ColumnHeader();
            this.colValorAtual = new System.Windows.Forms.ColumnHeader();
            this.lblDetalhes = new System.Windows.Forms.Label();
            this.txtDetalhes = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblResumo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // lblPesquisa
            //
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(12, 17);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(60, 15);
            this.lblPesquisa.TabIndex = 0;
            this.lblPesquisa.Text = "Pesquisar:";
            //
            // txtPesquisa
            //
            this.txtPesquisa.Location = new System.Drawing.Point(82, 13);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(200, 23);
            this.txtPesquisa.TabIndex = 1;
            //
            // btnPesquisar
            //
            this.btnPesquisar.Location = new System.Drawing.Point(288, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(90, 26);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            //
            // btnMostrarTodos
            //
            this.btnMostrarTodos.Location = new System.Drawing.Point(384, 12);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(105, 26);
            this.btnMostrarTodos.TabIndex = 3;
            this.btnMostrarTodos.Text = "Mostrar todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            //
            // lblFiltroEstado
            //
            this.lblFiltroEstado.AutoSize = true;
            this.lblFiltroEstado.Location = new System.Drawing.Point(505, 17);
            this.lblFiltroEstado.Name = "lblFiltroEstado";
            this.lblFiltroEstado.Size = new System.Drawing.Size(45, 15);
            this.lblFiltroEstado.TabIndex = 4;
            this.lblFiltroEstado.Text = "Estado:";
            //
            // cmbFiltroEstado
            //
            this.cmbFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroEstado.Enabled = false;
            this.cmbFiltroEstado.FormattingEnabled = true;
            this.cmbFiltroEstado.Location = new System.Drawing.Point(556, 13);
            this.cmbFiltroEstado.Name = "cmbFiltroEstado";
            this.cmbFiltroEstado.Size = new System.Drawing.Size(130, 23);
            this.cmbFiltroEstado.TabIndex = 5;
            this.cmbFiltroEstado.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroEstado_SelectedIndexChanged);
            //
            // btnImpressorasCores
            //
            this.btnImpressorasCores.Location = new System.Drawing.Point(702, 12);
            this.btnImpressorasCores.Name = "btnImpressorasCores";
            this.btnImpressorasCores.Size = new System.Drawing.Size(140, 26);
            this.btnImpressorasCores.TabIndex = 6;
            this.btnImpressorasCores.Text = "Impressoras a cores";
            this.btnImpressorasCores.UseVisualStyleBackColor = true;
            this.btnImpressorasCores.Click += new System.EventHandler(this.btnImpressorasCores_Click);
            //
            // btnPoucaRam
            //
            this.btnPoucaRam.Location = new System.Drawing.Point(848, 12);
            this.btnPoucaRam.Name = "btnPoucaRam";
            this.btnPoucaRam.Size = new System.Drawing.Size(190, 26);
            this.btnPoucaRam.TabIndex = 7;
            this.btnPoucaRam.Text = "Computadores com pouca RAM";
            this.btnPoucaRam.UseVisualStyleBackColor = true;
            this.btnPoucaRam.Click += new System.EventHandler(this.btnPoucaRam_Click);
            //
            // lblResponsavel
            //
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.Location = new System.Drawing.Point(12, 53);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(160, 15);
            this.lblResponsavel.TabIndex = 8;
            this.lblResponsavel.Text = "Responsável de informática:";
            //
            // txtResponsavel
            //
            this.txtResponsavel.Location = new System.Drawing.Point(178, 49);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(200, 23);
            this.txtResponsavel.TabIndex = 9;
            //
            // btnAlterarResponsavel
            //
            this.btnAlterarResponsavel.Location = new System.Drawing.Point(384, 48);
            this.btnAlterarResponsavel.Name = "btnAlterarResponsavel";
            this.btnAlterarResponsavel.Size = new System.Drawing.Size(105, 26);
            this.btnAlterarResponsavel.TabIndex = 10;
            this.btnAlterarResponsavel.Text = "Alterar";
            this.btnAlterarResponsavel.UseVisualStyleBackColor = true;
            this.btnAlterarResponsavel.Click += new System.EventHandler(this.btnAlterarResponsavel_Click);
            //
            // lvEquipamentos
            //
            this.lvEquipamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvEquipamentos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colTipo,
            this.colMarca,
            this.colModelo,
            this.colNumeroSerie,
            this.colSala,
            this.colAno,
            this.colPreco,
            this.colEstado,
            this.colValorAtual});
            this.lvEquipamentos.FullRowSelect = true;
            this.lvEquipamentos.GridLines = true;
            this.lvEquipamentos.HideSelection = false;
            this.lvEquipamentos.Location = new System.Drawing.Point(12, 88);
            this.lvEquipamentos.MultiSelect = false;
            this.lvEquipamentos.Name = "lvEquipamentos";
            this.lvEquipamentos.Size = new System.Drawing.Size(790, 440);
            this.lvEquipamentos.TabIndex = 11;
            this.lvEquipamentos.UseCompatibleStateImageBehavior = false;
            this.lvEquipamentos.View = System.Windows.Forms.View.Details;
            this.lvEquipamentos.SelectedIndexChanged += new System.EventHandler(this.lvEquipamentos_SelectedIndexChanged);
            this.lvEquipamentos.DoubleClick += new System.EventHandler(this.lvEquipamentos_DoubleClick);
            //
            // colId
            //
            this.colId.Text = "Id";
            this.colId.Width = 40;
            //
            // colTipo
            //
            this.colTipo.Text = "Tipo";
            this.colTipo.Width = 85;
            //
            // colMarca
            //
            this.colMarca.Text = "Marca";
            this.colMarca.Width = 70;
            //
            // colModelo
            //
            this.colModelo.Text = "Modelo";
            this.colModelo.Width = 115;
            //
            // colNumeroSerie
            //
            this.colNumeroSerie.Text = "N.º de série";
            this.colNumeroSerie.Width = 95;
            //
            // colSala
            //
            this.colSala.Text = "Sala";
            this.colSala.Width = 85;
            //
            // colAno
            //
            this.colAno.Text = "Ano";
            this.colAno.Width = 45;
            //
            // colPreco
            //
            this.colPreco.Text = "Preço";
            this.colPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colPreco.Width = 80;
            //
            // colEstado
            //
            this.colEstado.Text = "Estado";
            this.colEstado.Width = 85;
            //
            // colValorAtual
            //
            this.colValorAtual.Text = "Valor atual";
            this.colValorAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colValorAtual.Width = 80;
            //
            // lblDetalhes
            //
            this.lblDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetalhes.AutoSize = true;
            this.lblDetalhes.Location = new System.Drawing.Point(815, 68);
            this.lblDetalhes.Name = "lblDetalhes";
            this.lblDetalhes.Size = new System.Drawing.Size(52, 15);
            this.lblDetalhes.TabIndex = 12;
            this.lblDetalhes.Text = "Detalhes";
            //
            // txtDetalhes
            //
            this.txtDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetalhes.Location = new System.Drawing.Point(815, 88);
            this.txtDetalhes.Multiline = true;
            this.txtDetalhes.Name = "txtDetalhes";
            this.txtDetalhes.ReadOnly = true;
            this.txtDetalhes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetalhes.Size = new System.Drawing.Size(223, 440);
            this.txtDetalhes.TabIndex = 13;
            //
            // btnAdicionar
            //
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdicionar.Location = new System.Drawing.Point(12, 538);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(110, 30);
            this.btnAdicionar.TabIndex = 14;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            //
            // btnEditar
            //
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.Location = new System.Drawing.Point(128, 538);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 30);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            //
            // btnRemover
            //
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemover.Location = new System.Drawing.Point(244, 538);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(110, 30);
            this.btnRemover.TabIndex = 16;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            //
            // lblResumo
            //
            this.lblResumo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResumo.Location = new System.Drawing.Point(12, 576);
            this.lblResumo.Name = "lblResumo";
            this.lblResumo.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lblResumo.Size = new System.Drawing.Size(1026, 42);
            this.lblResumo.TabIndex = 17;
            this.lblResumo.Text = "Resumo";
            //
            // FormPrincipal
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 630);
            this.Controls.Add(this.lblResumo);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtDetalhes);
            this.Controls.Add(this.lblDetalhes);
            this.Controls.Add(this.lvEquipamentos);
            this.Controls.Add(this.btnAlterarResponsavel);
            this.Controls.Add(this.txtResponsavel);
            this.Controls.Add(this.lblResponsavel);
            this.Controls.Add(this.btnPoucaRam);
            this.Controls.Add(this.btnImpressorasCores);
            this.Controls.Add(this.cmbFiltroEstado);
            this.Controls.Add(this.lblFiltroEstado);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblPesquisa);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Equipamentos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Label lblFiltroEstado;
        private System.Windows.Forms.ComboBox cmbFiltroEstado;
        private System.Windows.Forms.Button btnImpressorasCores;
        private System.Windows.Forms.Button btnPoucaRam;
        private System.Windows.Forms.Label lblResponsavel;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.Button btnAlterarResponsavel;
        private System.Windows.Forms.ListView lvEquipamentos;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colTipo;
        private System.Windows.Forms.ColumnHeader colMarca;
        private System.Windows.Forms.ColumnHeader colModelo;
        private System.Windows.Forms.ColumnHeader colNumeroSerie;
        private System.Windows.Forms.ColumnHeader colSala;
        private System.Windows.Forms.ColumnHeader colAno;
        private System.Windows.Forms.ColumnHeader colPreco;
        private System.Windows.Forms.ColumnHeader colEstado;
        private System.Windows.Forms.ColumnHeader colValorAtual;
        private System.Windows.Forms.Label lblDetalhes;
        private System.Windows.Forms.TextBox txtDetalhes;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblResumo;
    }
}
