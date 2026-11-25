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

        public static bool TextoValido(string texto)
        {
            if (texto == null)
            {
                return false;
            }

            if (texto.Trim().Length < 2)
            {
                return false;
            }

            return true;
        }

        public static bool AnoValido(int ano)
        {
            if (ano < ANO_MINIMO_AQUISICAO || ano > DateTime.Today.Year)
            {
                return false;
            }

            return true;
        }

        public static bool PrecoValido(decimal preco)
        {
            if (preco <= 0)
            {
                return false;
            }

            return true;
        }

        public Equipamento(string _marca, string _modelo, string _sala, int _anoAquisicao, decimal _precoCompra)
        {
            id = proximoId;
            proximoId++;

            marca = _marca;
            modelo = _modelo;
            sala = _sala;
            anoAquisicao = _anoAquisicao;
            AlterarPrecoCompra(_precoCompra);
        }

        public int ObterId()
        {
            return id;
        }

        public decimal ObterPrecoCompra()
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

        public string ObterSala()
        {
            return sala;
        }

        public bool AlterarSala(string novaSala)
        {
            if (novaSala == null || novaSala.Trim().Length < 2)
            {
                return false;
            }
            sala = novaSala.Trim().ToUpper();
            return true;
        }

        public int ObterAnoAquisicao()
        {
            return anoAquisicao;
        }

        public bool AlterarAnoAquisicao(int novoAno)
        {
            if (novoAno < ANO_MINIMO_AQUISICAO || novoAno > DateTime.Today.Year)
            {
                return false;
            }
            anoAquisicao = novoAno;
            return true;
        }

        public string ObterDescricao()
        {
            return "Marca: " + marca + "\nModelo: " + modelo + "\nSala: " + sala + "\nAno de Aquisição: " + anoAquisicao + "\nPreço de Compra: " + precoCompra;
        }
    }
}
