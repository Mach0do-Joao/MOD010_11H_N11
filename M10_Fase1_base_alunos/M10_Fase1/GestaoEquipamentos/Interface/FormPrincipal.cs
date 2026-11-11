using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GestaoEquipamentos.Modelo;
// TODO Fase 1: depois de criar a classe Equipamento na pasta Modelo, acrescentar:
//              using GestaoEquipamentos.Modelo;

namespace GestaoEquipamentos.Interface
{
    public partial class FormPrincipal : Form
    {
        List<Equipamento> equipamentos = new List<Equipamento>();
        // TODO Fase 1: criar o campo List<Equipamento> equipamentos (já com new)

        public FormPrincipal()
        {
            InitializeComponent();

            equipamentos.Add(new Equipamento("HP", "ProDesk", "B12", 2020, 650));
            equipamentos.Add(new Equipamento("Dell", "OptiPlex", "C2", 2021, 700));
            equipamentos.Add(new Equipamento("Lenovo", "ThinkCentre", "B1", 2022, 800));
            equipamentos.Add(new Equipamento("Asus", "ExpertCenter", "B2", 2023, 900));
            equipamentos.Add(new Equipamento("Acer", "Veriton", "Laboratório 1", 2021, 750));

            MostrarEquipamentos();
        }
           
            // TODO Fase 1: no fim do construtor, chamar MostrarEquipamentos()

        public void MostrarEquipamentos()
        {
            lvEquipamentos.Items.Clear();

            for (int i = 0; i < equipamentos.Count; i++)
            {
                ListViewItem linha = new ListViewItem(""); // Id

                linha.SubItems.Add(""); // Tipo
                linha.SubItems.Add(equipamentos[i].Marca); // Marca
                linha.SubItems.Add(equipamentos[i].Modelo); // Modelo
                linha.SubItems.Add(""); // Nº de série
                linha.SubItems.Add(equipamentos[i].Sala); // Sala
                linha.SubItems.Add(equipamentos[i].AnoAquisicao.ToString()); // Ano
                linha.SubItems.Add(equipamentos[i].PrecoCompra.ToString()); // Preço
                linha.SubItems.Add(""); // Estado
                linha.SubItems.Add(""); // Valor atual

                lvEquipamentos.Items.Add(linha);
            }
        lblResumo.Text = "Equipamentos na lista: " + equipamentos.Count;
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
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // TODO Fase 1: obter o equipamento selecionado (se não houver, mostrar uma mensagem),
            //              abrir new FormEquipamento(equipamento) e, se devolver OK,
            //              chamar MostrarEquipamentos()
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            // TODO Fase 1: obter o equipamento selecionado (se não houver, mostrar uma mensagem),
            //              pedir confirmação, retirar da lista e pôr a variável a null
        }

        private void lvEquipamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO Fase 1: mostrar em txtDetalhes os dados do equipamento selecionado
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
        }

        private void btnImpressorasCores_Click(object sender, EventArgs e)
        {
            // TODO Fase 7: mostrar só as impressoras a cores (gestor.ObterImpressorasACores())
        }

        private void btnPoucaRam_Click(object sender, EventArgs e)
        {
            // TODO Fase 7: mostrar só os computadores com 4 GB de RAM ou menos
            //              (gestor.ObterComputadoresComPoucaRam(4))
        }

        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO Fase 8: mostrar só os equipamentos do estado escolhido (gestor.Pesquisar(estado))
        }
    }
}
