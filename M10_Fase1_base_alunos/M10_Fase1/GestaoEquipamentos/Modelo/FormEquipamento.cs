using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoEquipamentos.Modelo;
using System.Windows.Forms;

namespace GestaoEquipamentos.Interface
{
    public class FormEquipamento : Form
    {
        public Equipamento EquipamentoCriado;
        private Equipamento equipamentoEmEdicao;

        public FormEquipamento()
        {
            InitializeComponent();
            Text = "Adicionar equipamento";
            equipamentoEmEdicao = null;
        }
    }
}