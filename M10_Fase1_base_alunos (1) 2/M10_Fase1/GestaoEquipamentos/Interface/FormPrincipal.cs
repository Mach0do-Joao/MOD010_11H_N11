using GestaoEquipamentos.Modelo;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Windows.Forms;
// TODO Fase 1: depois de criar a classe Equipamento na pasta Modelo, acrescentar:
//              using GestaoEquipamentos.Modelo;

namespace GestaoEquipamentos.Interface
{
    public partial class FormPrincipal : Form
    {
        // TODO Fase 1: criar o campo List<Equipamento> equipamentos (já com new)
        List<equipamento> Equipamentos = new List<equipamento>();

        public FormPrincipal()
        {
            InitializeComponent();

            // Computadores de Aluno e Professor
            Equipamentos.Add(new equipamento("HP", "ProDesk", "B12", 2020, 650));
            Equipamentos.Add(new equipamento("Lenovo", "ProDesk", "B02", 2019, 500));
            Equipamentos.Add(new equipamento("HP", "ProDesk", "C02", 2024, 750));
            Equipamentos.Add(new equipamento("HP", "ProDesk", "C09", 2020, 550));

            // Projeção e Interatividade
            Equipamentos.Add(new equipamento("Epson", "EB-685W", "PROJ-01", 2019, 1200));

            // Impressão
            Equipamentos.Add(new equipamento("APC", "Back-UPS 1400VA", "UPS-01", 2021, 160));

            MostrarEquipamentos();
            // TODO Fase 1: no fim do construtor, chamar MostrarEquipamentos()
        }

        private void MostrarEquipamentos()
        {
            lvEquipamentos.Items.Clear();

            for (int i = 0; i < Equipamentos.Count; i++)
            {

                equipamento eq = Equipamentos[i];

                ListViewItem linha = new ListViewItem(""); // Id

                linha.SubItems.Add("");                     // Tipo
                linha.SubItems.Add(eq.Marca);                  // Marca
                linha.SubItems.Add(eq.Modelo);              // Modelo
                linha.SubItems.Add("");                     // N.º de série
                linha.SubItems.Add(eq.Sala);                // Sala
                linha.SubItems.Add(eq.AnoAquisicao.ToString()); // Ano
                linha.SubItems.Add(eq.PrecoCompra.ToString());  // Preço
                linha.SubItems.Add("");                     // Estado
                linha.SubItems.Add("");                     // Valor atual

                lvEquipamentos.Items.Add(linha);
            }

            lblResumo.Text = "Equipamentos na lista:" + Equipamentos.Count;
        }
        // TODO Fase 1: criar o método MostrarEquipamentos(), que limpa a ListView
        //              (lvEquipamentos.Items.Clear()) e junta uma linha por equipamento.
        //              Ordem das colunas: Id, Tipo, Marca, Modelo, N.º de série, Sala, Ano,
        //              Preço, Estado, Valor atual. Por agora, Id, Tipo, N.º de série, Estado
        //              e Valor atual ficam vazias ("").
        //              Dica:  ListViewItem linha = new ListViewItem("");
        //                     linha.SubItems.Add("");  linha.SubItems.Add(equipamento.Marca); ...
        //                     lvEquipamentos.Items.Add(linha);

        // ---------- Botões ----------

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // TODO Fase 1: abrir o FormEquipamento com ShowDialog(); se devolver DialogResult.OK,
            //              juntar form.EquipamentoCriado à lista e chamar MostrarEquipamentos()
            FormEquipamento form = new FormEquipamento();

            if (form.ShowDialog() == DialogResult.OK)
            {
                // Se o utilizador guardou, juntar o novo equipamento à lista
                Equipamentos.Add(form.EquipamentoCriado);

                // Atualizar a listagem no formulário principal
                MostrarEquipamentos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // TODO Fase 1: obter o equipamento selecionado (se não houver, mostrar uma mensagem),
            //              abrir new FormEquipamento(equipamento) e, se devolver OK,
            //              chamar MostrarEquipamentos()
            // 1. Verificar se há algum equipamento selecionado na ListView
            // 2. Verificar se é null (ou seja, se não há nada selecionado)
            if (lvEquipamentos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleciona um equipamento para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int indice = lvEquipamentos.SelectedItems[0].Index;
            equipamento eqSelecionado = Equipamentos[indice];

            FormEquipamento form = new FormEquipamento(eqSelecionado);

            if (form.ShowDialog() == DialogResult.OK)
            {
                MostrarEquipamentos();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            // TODO Fase 1: obter o equipamento selecionado (se não houver, mostrar uma mensagem),
            //              pedir confirmação, retirar da lista e pôr a variável a null
            if (lvEquipamentos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleciona um equipamento.", "Aviso");
                return;
            }

            int indice = lvEquipamentos.SelectedItems[0].Index;
            equipamento eqSelecionado = Equipamentos[indice];

            if (eqSelecionado == null)
            {
                MessageBox.Show("Equipamento inválido.", "Aviso");
                return;
            }

            DialogResult resultado = MessageBox.Show("Tens a certeza que pretendes remover este equipamento?","Confirmar Remoção",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Equipamentos.Remove(eqSelecionado);
                eqSelecionado = null;
                MostrarEquipamentos();
            }
        }

        private void lvEquipamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO Fase 1: mostrar em txtDetalhes os dados do equipamento selecionado
            if (lvEquipamentos.SelectedItems.Count == 0)
            {
                txtDetalhes.Text = "";
                return;
            }

            int indice = lvEquipamentos.SelectedItems[0].Index;
            equipamento eq = Equipamentos[indice];

            txtDetalhes.Text = eq.Marca + "\n" + eq.Modelo + "\n" + eq.Sala;
        }

        // Duplo clique numa linha = Editar
        private void lvEquipamentos_DoubleClick(object sender, EventArgs e)
        {
            btnEditar_Click(sender, e);
        }

        private void btnAlterarResponsavel_Click(object sender, EventArgs e)
        {
            // TODO Fase 2: alterar o responsável de informática com Escola.AlterarResponsavel(...)
        }

        // ---------- Pesquisa e filtros ----------

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // TODO Fase 5: mostrar só os equipamentos devolvidos por gestor.Pesquisar(txtPesquisa.Text)
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
            MostrarEquipamentos();
        }

        private void btnImpressorasCores_Click(object sender, EventArgs e)
        {
            // TODO Fase 7: mostrar só as impressoras a cores (gestor.ObterImpressorasACores())
        }

        private void btnPoucaRam_Click(object sender, EventArgs e)
        {
            // TODO Fase 7: mostrar só os computadores com 4 GB de RAM ou menos
            //              (gestor.ObterComputadoresComPoucaRam(4))
            lvEquipamentos.Items.Clear();
            int contador = 0;

            for (int i = 0; i < Equipamentos.Count; i++)
            {
                equipamento eq = Equipamentos[i];

                // Exemplo de condição (ajusta "Ram" para o nome exato da propriedade quando a criores na classe equipamento)
                // if (eq.Ram <= 4)
                {
                    ListViewItem linha = new ListViewItem("");
                    linha.SubItems.Add("");
                    linha.SubItems.Add(eq.Marca);
                    linha.SubItems.Add(eq.Modelo);
                    linha.SubItems.Add("");
                    linha.SubItems.Add(eq.Sala);
                    linha.SubItems.Add(eq.AnoAquisicao.ToString());
                    linha.SubItems.Add(eq.PrecoCompra.ToString());
                    linha.SubItems.Add("");
                    linha.SubItems.Add("");

                    lvEquipamentos.Items.Add(linha);
                    contador++;
                }
            }

            lblResumo.Text = "Equipamentos na lista: " + contador;
        }

        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO Fase 8: mostrar só os equipamentos do estado escolhido (gestor.Pesquisar(estado))
        }
    }
}
