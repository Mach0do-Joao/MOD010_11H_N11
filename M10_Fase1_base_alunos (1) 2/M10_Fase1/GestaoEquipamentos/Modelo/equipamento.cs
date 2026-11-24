//fiquei no passo 13

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.Modelo
{
    public class Equipamento
    {
        public const int ANO_MINIMO_AQUISICAO = 2000;
        private static int proximoId = 1;
        private readonly int id;    
        public string marca;
        public string modelo;
        public string sala;
        public int anoAquisicao;
        public decimal precoCompra;

        public Equipamento(string _marca, string _modelo, string _sala, int _anoAquisicao, decimal _precoCompra)
        {

            // Cada equipamento recebe o número seguinte
            id = proximoId;
            proximoId++;

            marca = _marca;
            modelo = _modelo;
            sala = _sala;
            anoAquisicao = _anoAquisicao;
            AlterarPrecoCompra(precoCompra);
        }

        public int ObterId()
        {
            return id;
        }
                
        public decimal ObterPrecoCompra()
        {
            return precoCompra;
        }

        public decimal ObterPreco_Compra()
        {
            return precoCompra;
        }

        public bool AlterarPrecoCompra(decimal novoPreco)
        {
            if (novoPreco <= 0)
            {
                return false;
            }

            precoCompra = novoPreco;
            return true;
        }

        public string ObterDescricao()
        {
            return "Marca: " + marca + "\nModelo: " + modelo + "\nSala: " + sala + "\nAno de Aquisição: " + anoAquisicao +"\nPreço de Compra: " + precoCompra;
        }
    }
}
