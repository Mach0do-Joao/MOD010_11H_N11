using GestaoEquipamentos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.Logica
{
    // Equipamentos para testar a aplicação sem ter de os escrever à mão
    public static class DadosExemplo
    {
        public static void Carregar(List<Equipamento> lista)
        {
            lista.Add(new Equipamento("HP", "EliteDesk 800 G8", "B10", 2021, 780));
            lista.Add(new Equipamento("Asus", "ExpertCenter D5", "B02", 2023, 690));
            lista.Add(new Equipamento("Canon", "i-SENSYS MF657Cdw", "Sala de Professores", 2022, 420));
            lista.Add(new Equipamento("BenQ", "MW560", "B12", 2020, 540));
            lista.Add(new Equipamento("APC", "Smart-UPS 1500VA", "B02", 2021, 310));
            lista.Add(new Equipamento("Samsung", "ProXpress M3820DW", "Biblioteca", 2020, 230));
        }
    }
}