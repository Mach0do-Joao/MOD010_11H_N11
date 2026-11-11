using System;
using System.Windows.Forms;
using GestaoEquipamentos.Modelo;

namespace GestaoEquipamentos.Interface
{
    public partial class FormEquipamento : Form
    {
        // TODO Fase 1: criar o campo público EquipamentoCriado (do tipo Equipamento)
        public Equipamento EquipamentoCriado;

        // TODO Fase 1: criar o campo privado equipamentoEmEdicao (fica null no modo adicionar)
        private Equipamento equipamentoEmEdicao;

        // Construtor para ADICIONAR
        public FormEquipamento()
        {
            InitializeComponent();
            Text = "Adicionar equipamento";
            equipamentoEmEdicao = null;
        }

        // TODO Fase 1: criar um segundo construtor, para EDITAR, que recebe o equipamento selecionado,
        //              o guarda em equipamentoEmEdicao e preenche as caixas com os dados dele

        public FormEquipamento(Equipamento equipamento)
        {
            InitializeComponent();
            Text = "Editar equipamento";

            equipamentoEmEdicao = equipamento;

            cmbTipo.SelectedItem = equipamentoEmEdicao.Tipo;
            txtMarca.Text = equipamentoEmEdicao.Marca;
            txtModelo.Text = equipamentoEmEdicao.Modelo;
            txtNumeroSerie.Text = equipamentoEmEdicao.NumeroSerie;
            txtSala.Text = equipamentoEmEdicao.Sala;
            nudAno.Value = equipamentoEmEdicao.Ano;
            nudPreco.Value = (decimal)equipamentoEmEdicao.Preco;
            cmbEstado.SelectedItem = equipamentoEmEdicao.Estado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // TODO Fase 1: ler os dados das caixas; no modo adicionar criar o objeto com new e guardá-lo
            if (equipamentoEmEdicao == null)
            {
                EquipamentoCriado = new Equipamento();

                EquipamentoCriado.Tipo = cmbTipo.SelectedItem?.ToString();
                EquipamentoCriado.Marca = txtMarca.Text;
                EquipamentoCriado.Modelo = txtModelo.Text;
                EquipamentoCriado.NumeroSerie = txtNumeroSerie.Text;
                EquipamentoCriado.Sala = txtSala.Text;
                EquipamentoCriado.Ano = (int)nudAno.Value;
                EquipamentoCriado.Preco = nudPreco.Value;
                EquipamentoCriado.Estado = cmbEstado.SelectedItem?.ToString();
            }
            //              em EquipamentoCriado; no modo editar alterar os campos de equipamentoEmEdicao
            //              (sem criar nenhum objeto novo). No fim: DialogResult = DialogResult.OK;
            else
            {
                equipamentoEmEdicao.Tipo = cmbTipo.SelectedItem?.ToString();
                equipamentoEmEdicao.Marca = txtMarca.Text;
                equipamentoEmEdicao.Modelo = txtModelo.Text;
                equipamentoEmEdicao.NumeroSerie = txtNumeroSerie.Text;
                equipamentoEmEdicao.Sala = txtSala.Text;
                equipamentoEmEdicao.Ano = (int)nudAno.Value;
                equipamentoEmEdicao.Preco = nudPreco.Value;
                equipamentoEmEdicao.Estado = cmbEstado.SelectedItem?.ToString();
            }
            DialogResult = DialogResult.OK;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO Fase 6: ativar só o grupo do tipo escolhido (grpComputador, grpImpressora, grpProjetor)
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
