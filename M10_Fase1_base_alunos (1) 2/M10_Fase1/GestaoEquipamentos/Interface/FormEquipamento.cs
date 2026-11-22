using GestaoEquipamentos.Modelo;
using System;
using System.Windows.Forms;

namespace GestaoEquipamentos.Interface
{
    public partial class FormEquipamento : Form
    {
        // TODO Fase 1: criar o campo público EquipamentoCriado (do tipo Equipamento)
        // TODO Fase 1: criar o campo privado equipamentoEmEdicao (fica null no modo adicionar)
        public Equipamento EquipamentoCriado;
        private Equipamento equipamentoEmEdicao;

        // Construtor para ADICIONAR
        public FormEquipamento()
        {
            InitializeComponent();
            nudAno.Minimum = Equipamento.ANO_MINIMO_AQUISICAO;
            nudAno.Maximum = DateTime.Today.Year;
            nudAno.Value = DateTime.Today.Year;

            Text = "Adicionar equipamento";
            equipamentoEmEdicao = null;
        }


        public FormEquipamento(Equipamento eq)
        {
            InitializeComponent();
            Text = "Editar equipamento";

            // Guardar o equipamento que veio do formulário principal
            equipamentoEmEdicao = eq;

            // Preencher as caixas com os dados atuais
            txtMarca.Text = eq.marca;
            txtModelo.Text = eq.modelo;
            txtNumeroSerie.Text = eq.sala;
            nudAno.Text = eq.anoAquisicao.ToString();
            nudPreco.Text = eq.precoCompra.ToString();
        }
        // TODO Fase 1: criar um segundo construtor, para EDITAR, que recebe o equipamento selecionado,
        //              o guarda em equipamentoEmEdicao e preenche as caixas com os dados dele

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // TODO Fase 1: ler os dados das caixas; no modo adicionar criar o objeto com new e guardá-lo
            //              em EquipamentoCriado; no modo editar alterar os campos de equipamentoEmEdicao
            //              (sem criar nenhum objeto novo). No fim: DialogResult = DialogResult.OK;
            if (txtMarca.Text == "" || txtModelo.Text == "" || txtSala.Text == "" )  //|| nudAno.Value == 0 || nudAno.Value == 0)
            {
                MessageBox.Show("Certifique-se de que todos os dados foram devidamente preenchimento");
                return;
            }
            
            string marca = txtMarca.Text.Trim();
            string modelo = txtModelo.Text.Trim();
            string sala=txtSala.Text.Trim();
            string numeroSerie = txtNumeroSerie.Text.Trim();
            int anoAquipamento = (int)nudAno.Value;
            decimal preco = nudPreco.Value;

            if (equipamentoEmEdicao == null)
            {   
                //Estamos no modo adicionar:cria um novo objeto
                EquipamentoCriado = new Equipamento(marca, modelo, numeroSerie, anoAquipamento, preco);
            }
            else
            {
                equipamentoEmEdicao.marca = marca;
                equipamentoEmEdicao.modelo = modelo;
                equipamentoEmEdicao.sala = numeroSerie;
                equipamentoEmEdicao.anoAquisicao = anoAquipamento;
                equipamentoEmEdicao.precoCompra = preco;
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
