using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.Modelo
{
    public class Equipamento
    {
        public string marca;
        public string modelo;
        public string sala;
        public int anoAquisicao;
        public decimal precoCompra;

        public Equipamento(string _Marca, string _Modelo, string _Sala, int _AnoAquisicao, decimal _PrecoCompra)
        {
            marca = _Marca;
            modelo = _Modelo;
            sala = _Sala;
            anoAquisicao = _AnoAquisicao;
            precoCompra = _PrecoCompra;
        }

        public string ObterDescricao()
        {
            return "Marca: " + marca + "\nModelo: " + modelo + "\nSala: " + sala + "\nAno de Aquisição: " + anoAquisicao +"\nPreço de Compra: " + precoCompra;
        }
    }
}
