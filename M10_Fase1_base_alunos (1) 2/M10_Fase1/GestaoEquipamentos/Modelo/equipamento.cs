using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.Modelo
{
    public class equipamento
    {
        public string Marca;
        public string Modelo;
        public string Sala;
        public int AnoAquisicao;
        public decimal PrecoCompra;

        public equipamento(string _marca, string _modelo, string _sala, int _anoAquisicao, decimal _precoCompra)
        {
            Marca = _marca;
            Modelo = _modelo;
            Sala = _sala;
            AnoAquisicao = _anoAquisicao;
            PrecoCompra = _precoCompra;
        }

        public string ObterDescricao()
        {
            return "Marca: " + Marca + "\nModelo: " + Modelo + "\nSala: " + Sala + "\nAno de Aquisição: " + AnoAquisicao +"\nPreço de Compra: " + PrecoCompra;
        }
    }
}
