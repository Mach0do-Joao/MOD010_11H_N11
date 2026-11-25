using GestaoEquipamentos.Logica;
using GestaoEquipamentos.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestaoEquipamentos.Interface
{
    public partial class FormEquipamento : Form
    {
        public Equipamento EquipamentoCriado;
        // TODO Fase 1: criar o campo público EquipamentoCriado (do tipo Equipamento)
        private Equipamento equipamentoEmEdicao;
        // TODO Fase 1: criar o campo privado equipamentoEmEdicao (fica null no modo adicionar)
        private List<Equipamento> equipamentos = new List<Equipamento>();

        // Construtor para ADICIONAR

        public FormEquipamento()
        {
            InitializeComponent();
            Text = "Adicionar equipamento";
            nudAno.Minimum = Equipamento.ANO_MINIMO_AQUISICAO;
            nudAno.Maximum = DateTime.Today.Year;
            nudAno.Value = DateTime.Today.Year;
        }

        // Construtor para EDITAR: recebe o equipamento que está selecionado na lista
        public FormEquipamento(Equipamento equipamento)
        {
            InitializeComponent();
            Text = "Editar equipamento";
            nudAno.Minimum = Equipamento.ANO_MINIMO_AQUISICAO;
            nudAno.Maximum = DateTime.Today.Year;

            equipamentoEmEdicao = equipamento;
            txtMarca.Text = equipamento.marca;
            txtModelo.Text = equipamento.modelo;
            txtSala.Text = equipamento.sala;
            nudAno.Value = equipamento.anoAquisicao;
            nudPreco.Value = equipamento.ObterPrecoCompra();
        }

        // Guardar o equipamento que veio do formulário principal
        private ListViewItem CriarLinha(Equipamento equipamento)
        {
            ListViewItem linha = new ListViewItem(equipamento.ObterId().ToString());
            linha.SubItems.Add("");                             // Tipo (Fase 6)
            linha.SubItems.Add(equipamento.marca);
            linha.SubItems.Add(equipamento.modelo);
            linha.SubItems.Add("");                             // N.º de série (Fase 3)
            linha.SubItems.Add(equipamento.sala);
            linha.SubItems.Add(equipamento.anoAquisicao.ToString());
            linha.SubItems.Add(equipamento.ObterPrecoCompra().ToString("0.00") + " €");
            linha.SubItems.Add("");                             // Estado (Fase 8)
            linha.SubItems.Add("");                             // Valor atual (Fase 6)
            return linha;
        }


        // Guardar o equipamento que veio do formulário principal
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // TODO Fase 1: ler os dados das caixas; no modo adicionar criar o objeto com new e guardá-lo
            //              em EquipamentoCriado; no modo editar alterar os campos de equipamentoEmEdicao
            //              (sem criar nenhum objeto novo). No fim: DialogResult = DialogResult.OK;
            string marca = txtMarca.Text.Trim();
            string modelo = txtModelo.Text.Trim();
            string sala = txtSala.Text.Trim();
            int anoAquisicao = (int)nudAno.Value;           // conversão explícita (cast): decimal -> int
            decimal precoCompra = nudPreco.Value;

            // Validar TUDO antes de criar ou alterar o objeto
            if (marca == "" || modelo == "" || sala == "")
            {
                MessageBox.Show("Preencha a marca, o modelo e a sala.", "Dados em falta",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (precoCompra <= 0)
            {
                MessageBox.Show("O preço tem de ser maior do que zero.", "Dados inválidos",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (equipamentoEmEdicao == null)
            {
                // Modo ADICIONAR: cria um objeto NOVO
                EquipamentoCriado = new Equipamento(marca, modelo, sala, anoAquisicao, precoCompra);
            }
            else
            {
                // Modo EDITAR: altera o objeto que já existe (não cria nenhum objeto novo)
                equipamentoEmEdicao.marca = marca;
                equipamentoEmEdicao.modelo = modelo;
                equipamentoEmEdicao.sala = sala;
                equipamentoEmEdicao.anoAquisicao = anoAquisicao;
                equipamentoEmEdicao.AlterarPrecoCompra(precoCompra);
            }

            DialogResult = DialogResult.OK;     // fecha o formulário e devolve OK a quem o abriu
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AtualizarResumo()
        {
            lblResumo.Text = "Equipamentos na lista: " + equipamentos.Count;
        }

        // Devolve o equipamento selecionado na lista, ou null se não houver nenhum selecionado
        private Equipamento ObterEquipamentoSelecionado()
        {
            if (lvEquipamentos.SelectedIndices.Count == 0)
            {
                return null;
            }
            int indice = lvEquipamentos.SelectedIndices[0];
            return equipamentos[indice];
        }
        // TODO Fase 1: criar um segundo construtor, para EDITAR, que recebe o equipamento selecionado,
        //              o guarda em equipamentoEmEdicao e preenche as caixas com os dados dele

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // TODO Fase 1: ler os dados das caixas; no modo adicionar criar o objeto com new e guardá-lo
            //              em EquipamentoCriado; no modo editar alterar os campos de equipamentoEmEdicao
            //              (sem criar nenhum objeto novo). No fim: DialogResult = DialogResult.OK;
            string marca = txtMarca.Text.Trim();
            string modelo = txtModelo.Text.Trim();
            string sala = txtSala.Text.Trim();
            int anoAquisicao = (int)nudAno.Value;           // conversão explícita (cast): decimal -> int
            decimal precoCompra = nudPreco.Value;

            // Validar TUDO antes de criar ou alterar o objeto
            if (marca == "" || modelo == "" || sala == "")
            {
                MessageBox.Show("Preencha a marca, o modelo e a sala.", "Dados em falta",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (precoCompra <= 0)
            {
                MessageBox.Show("O preço tem de ser maior do que zero.", "Dados inválidos",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (equipamentoEmEdicao == null)
            {
                // Modo ADICIONAR: cria um objeto NOVO
                EquipamentoCriado = new Equipamento(marca, modelo, sala, anoAquisicao, precoCompra);
            }
            else
            {
                // Modo EDITAR: altera o objeto que já existe (não cria nenhum objeto novo)
                equipamentoEmEdicao.marca = marca;
                equipamentoEmEdicao.modelo = modelo;
                equipamentoEmEdicao.sala = sala;
                equipamentoEmEdicao.anoAquisicao = anoAquisicao;
                equipamentoEmEdicao.AlterarPrecoCompra(precoCompra);
            }

            DialogResult = DialogResult.OK;     // fecha o formulário e devolve OK a quem o abriu
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO Fase 6: ativar só o grupo do tipo escolhido (grpComputador, grpImpressora, grpProjetor)
        }

        private void grpComputador_Enter(object sender, EventArgs e)
        {

        }
    }
}
