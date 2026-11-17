using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.Modelo
{
    public class Equipamento
    {
        private static int proximoId = 1;
        private readonly int id;    
        public string marca;
        public string modelo;
        public string sala;
        public int anoAquisicao;
        public decimal precoCompra;

        public Equipamento(string _Marca, string _Modelo, string _Sala, int _AnoAquisicao, decimal _PrecoCompra)
        {

            id = proximoId;
            proximoId = proximoId + 1;

            marca = _Marca;
            modelo = _Modelo;
            sala = _Sala;
            anoAquisicao = _AnoAquisicao;
            precoCompra = _PrecoCompra;
        }

        public int ObterId()
        {
            return id;
        }

        public string ObterDescricao()
        {
            return "Marca: " + marca + "\nModelo: " + modelo + "\nSala: " + sala + "\nAno de Aquisição: " + anoAquisicao +"\nPreço de Compra: " + precoCompra;
        }
    }
}
