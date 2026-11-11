using GestaoEquipamentos.Modelo;
using System;
using System.Windows.Forms;

namespace GestaoEquipamentos.Interface
{
    public partial class FormEquipamento : Form
    {
        // TODO Fase 1: criar o campo público EquipamentoCriado (do tipo Equipamento)
        // TODO Fase 1: criar o campo privado equipamentoEmEdicao (fica null no modo adicionar)
        public equipamento EquipamentoCriado;
        private equipamento equipamentoEmEdicao;

        // Construtor para ADICIONAR
        public FormEquipamento()
        {
            InitializeComponent();
            Text = "Adicionar equipamento";
            equipamentoEmEdicao = null;
        }

        public FormEquipamento(equipamento eq)
        {
            InitializeComponent();
            Text = "Editar equipamento";

            // Guardar o equipamento que veio do formulário principal
            equipamentoEmEdicao = eq;

            // Preencher as caixas com os dados atuais
            txtMarca.Text = eq.Marca;
            txtModelo.Text = eq.Modelo;
            txtNumeroSerie.Text = eq.Sala;
            nudAno.Text = eq.AnoAquisicao.ToString();
            nudPreco.Text = eq.PrecoCompra.ToString();
        }
        // TODO Fase 1: criar um segundo construtor, para EDITAR, que recebe o equipamento selecionado,
        //              o guarda em equipamentoEmEdicao e preenche as caixas com os dados dele

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // TODO Fase 1: ler os dados das caixas; no modo adicionar criar o objeto com new e guardá-lo
            //              em EquipamentoCriado; no modo editar alterar os campos de equipamentoEmEdicao
            //              (sem criar nenhum objeto novo). No fim: DialogResult = DialogResult.OK;
            InitializeComponent();
            Text = "Editar equipamento";

            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("Por favor, adicine a marca.", "Aviso");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                MessageBox.Show("Por favor, adicine o modelo.", "Aviso");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumeroSerie.Text))
            {
                MessageBox.Show("Por favor, adicine o número.", "Aviso");
                return;
            }

            if (string.IsNullOrWhiteSpace(nudAno.Text))
            {
                MessageBox.Show("Por favor, adicine o ano.", "Aviso");
                return;
            }

            if (string.IsNullOrWhiteSpace(nudPreco.Text))
            {
                MessageBox.Show("Por favor, adicine o preço.", "Aviso");
                return;
            }

            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string numeroSerie = txtNumeroSerie.Text;

            int ano = int.Parse(nudAno.Text);
            decimal preco = decimal.Parse(nudPreco.Text);

            if (equipamentoEmEdicao == null)
            {
                EquipamentoCriado = new equipamento(marca, modelo, numeroSerie, ano, preco);
            }
            else
            {
                equipamentoEmEdicao.Marca = marca;
                equipamentoEmEdicao.Modelo = modelo;
                equipamentoEmEdicao.Sala = numeroSerie;
                equipamentoEmEdicao.AnoAquisicao = ano;
                equipamentoEmEdicao.PrecoCompra = preco;
            }
                // Fechar o formulário com o resultado OK
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
    }   
}
