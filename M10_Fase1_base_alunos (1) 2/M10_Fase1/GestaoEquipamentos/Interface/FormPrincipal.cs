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
        List<Equipamento> equipamentos = new List<Equipamento>(); 

        public FormPrincipal() // construtor do form principal  
        {
            InitializeComponent();

            // Computadores de Aluno e Professor
            equipamentos.Add(new Equipamento("HP", "ProDesk", "B12", 2020, 650));
            equipamentos.Add(new Equipamento("Lenovo", "ProDesk", "B02", 2019, 500));
            equipamentos.Add(new Equipamento("HP", "ProDesk", "C02", 2024, 750));
            equipamentos.Add(new Equipamento("HP", "ProDesk", "C09", 2020, 550));

            // Projeção e Interatividade
            equipamentos.Add(new Equipamento("Epson", "EB-685W", "PROJ-01", 2019, 1200));

            // Impressão
            equipamentos.Add(new Equipamento("APC", "Back-UPS 1400VA", "UPS-01", 2021, 160));

            // mostar equipamentos
            MostrarEquipamentos();
            // TODO Fase 1: no fim do construtor, chamar MostrarEquipamentos()
        }

        private void MostrarEquipamentos() // mostrar os objetos na lista view
        {
            lvEquipamentos.Items.Clear(); // limpar a list view

            //for (int i = 0; i < equipamentos.Count; i++)
              foreach (Equipamento equipamento in equipamentos)  //for se precisar do indice
                                                                 // foreach se não precisar do indice
                                                                //count ( len do python 
              {
                lvEquipamentos.Items.Add(CriarLinha (equipamento));

                //Equipamento eq = equipamentos[i];

                /*ListViewItem linha = new ListViewItem("");

                linha.SubItems.Add("");                     // ID
                linha.SubItems.Add(equipamento.marca);                  // Marca
                linha.SubItems.Add(equipamento.modelo);              // Modelo
                linha.SubItems.Add("");                     // N.º de série
                linha.SubItems.Add(equipamento.sala);                // Sala
                linha.SubItems.Add(equipamento.anoAquisicao.ToString()); // Ano
                linha.SubItems.Add(equipamento.precoCompra.ToString());  // Preço
                linha.SubItems.Add("");                     // Estado
                linha.SubItems.Add("");                     // Valor atual

                lvEquipamentos.Items.Add(linha);*/
                txtDetalhes.Text = "";
                AtualizarResumo();
              }
            
            //lblResumo.Text = "Equipamentos na lista:" + equipamentos.Count;
        }

        private ListViewItem CriarLinha(Equipamento equipamento)
        {
            ListViewItem linha = new ListViewItem("");          // Id (Fase 2)
            linha.SubItems.Add("");                             // Tipo (Fase 6)
            linha.SubItems.Add(equipamento.marca);
            linha.SubItems.Add(equipamento.modelo);
            linha.SubItems.Add("");                             // N.º de série (Fase 3)
            linha.SubItems.Add(equipamento.sala);
            linha.SubItems.Add(equipamento.anoAquisicao.ToString());
            linha.SubItems.Add(equipamento.precoCompra.ToString("0.00") + " €");
            linha.SubItems.Add("");                             // Estado (Fase 8)
            linha.SubItems.Add("");                             // Valor atual (Fase 6)
            return linha;
        }

        // TODO Fase 1: criar o método MostrarEquipamentos(), que limpa a ListView
        //              (lvEquipamentos.Items.Clear()) e junta uma linha por equipamento.
        //              Ordem das colunas: Id, Tipo, Marca, Modelo, N.º de série, Sala, Ano,
        //              Preço, Estado, Valor atual. Por agora, Id, Tipo, N.º de série, Estado
        //              e Valor atual ficam vazias ("").
        //              Dica:  ListViewItem linha = new ListViewItem("");
        //                     linha.SubItems.Add("");  linha.SubItems.Add(equipamento.Marca); ...
        //                     lvEquipamentos.Items.Add(linha);
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

        // ---------- Botões ----------

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // TODO Fase 1: abrir o FormEquipamento com ShowDialog(); se devolver DialogResult.OK,
            //              juntar form.EquipamentoCriado à lista e chamar MostrarEquipamentos()
            FormEquipamento form = new FormEquipamento();
            if (form.ShowDialog() == DialogResult.OK)
            {
                equipamentos.Add(form.EquipamentoCriado);
                MostrarEquipamentos();
            }
            // Se o utilizador guardou, juntar o novo equipamento à lista
            // Não é preciso "guardar na lista": o formulário alterou o próprio objeto,
            // e a lista aponta para esse mesmo objeto (é a mesma referência).
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // TODO Fase 1: obter o equipamento selecionado (se não houver, mostrar uma mensagem),
            //              abrir new FormEquipamento(equipamento) e, se devolver OK,
            //              chamar MostrarEquipamentos()
            // 1. Verificar se há algum equipamento selecionado na ListView
            // 2. Verificar se é null (ou seja, se não há nada selecionado)
            Equipamento equipamento = ObterEquipamentoSelecionado();
            if (equipamento == null)
            {
                MessageBox.Show("Selecione primeiro um equipamento na lista.", "Editar",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FormEquipamento form = new FormEquipamento(equipamento);
            if (form.ShowDialog() == DialogResult.OK)
            {
                MostrarEquipamentos();
            }
        }
            //privete Equipamento ObterEquipamentoSelecionado()

        private void btnRemover_Click(object sender, EventArgs e)
        {
            // TODO Fase 1: obter o equipamento selecionado (se não houver, mostrar uma mensagem),
            //              pedir confirmação, retirar da lista e pôr a variável a null
            Equipamento equipamento = ObterEquipamentoSelecionado();
            if (equipamento == null)
            {
                MessageBox.Show("Selecione primeiro um equipamento na lista.", "Editar",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult resposta = MessageBox.Show("Remover o equipamento " + equipamento.marca + " " + equipamento.modelo + "?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
            equipamentos.Remove(equipamento);
            equipamento = null;
            MostrarEquipamentos();
            }
        }
        private void lvEquipamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO Fase 1: mostrar em txtDetalhes os dados do equipamento selecionado
            Equipamento eq = null;
            if (lvEquipamentos.SelectedItems.Count == 0)
            {
                txtDetalhes.Text = "";
                return;
            }

            int indice = lvEquipamentos.SelectedItems[0].Index;
            eq = equipamentos[indice];
            txtDetalhes.Text = eq.marca + "\n" + eq.modelo + "\n" + eq.sala;
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

            for (int i = 0; i < equipamentos.Count; i++)
            {
                Equipamento eq = equipamentos[i];

                // Exemplo de condição (ajusta "Ram" para o nome exato da propriedade quando a criores na classe equipamento)
                // if (eq.Ram <= 4)
                {
                    ListViewItem linha = new ListViewItem("");
                    linha.SubItems.Add("");  // ID
                    linha.SubItems.Add(eq.marca);  // Marca
                    linha.SubItems.Add(eq.modelo);  // Modelo
                    linha.SubItems.Add("");  // N.º de série
                    linha.SubItems.Add(eq.sala);  // Sala
                    linha.SubItems.Add(eq.anoAquisicao.ToString());  // Ano
                    //linha.SubItems.Add(eq.precoCompra.ToString());
                    linha.SubItems.Add(eq.ObterPrecoCompra().ToString());  // Preço
                    linha.SubItems.Add("");  //Estado
                    linha.SubItems.Add("");  //Valor atual
     
                    lvEquipamentos.Items.Add(linha);
                }
               
                //lblResumo.Text = "Equipamentos na lista: " + contador;
            }    

            lblResumo.Text = "Equipamentos na lista: " + contador;
        }

        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO Fase 8: mostrar só os equipamentos do estado escolhido (gestor.Pesquisar(estado))
        }
    }
}
