using GestaoEquipamentos.Logica;
using GestaoEquipamentos.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestaoEquipamentos.Interface
{
    public partial class FormEquipamento : Form
    {
        // TODO Fase 1: criar o campo público EquipamentoCriado (do tipo Equipamento)
        // TODO Fase 1: criar o campo privado equipamentoEmEdicao (fica null no modo adicionar)
        private List<Equipamento> equipamentos = new List<Equipamento>();

        // Construtor para ADICIONAR
        public FormPrincipal()
        {
            InitializeComponent();
            Text = "Gestão de Equipamentos - " + Escola.NOME;
            DadosExemplo.Carregar(equipamentos);
            txtResponsavel.Text = Escola.ObterResponsavel();

            MostrarEquipamentos();
        }

        private void MostrarEquipamentos()
        {
            lvEquipamentos.Items.Clear();
            foreach (Equipamento equipamento in equipamentos)
            {
                lvEquipamentos.Items.Add(CriarLinha(equipamento));
            }
            txtDetalhes.Text = "";
            AtualizarResumo();
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
            if (txtMarca.Text == "" || txtModelo.Text == "" || txtSala.Text == "")  //|| nudAno.Value == 0 || nudAno.Value == 0)
            {
                MessageBox.Show("Certifique-se de que todos os dados foram devidamente preenchimento");
                return;
            }

            string marca = txtMarca.Text.Trim();
            string modelo = txtModelo.Text.Trim();
            string sala = txtSala.Text.Trim();
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

        private void grpComputador_Enter(object sender, EventArgs e)
        {

        }
    }
}
