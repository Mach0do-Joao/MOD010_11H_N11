using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.Modelo
{
    // Classe static: não se criam objetos desta classe; tudo pertence à própria classe.
    public static class Escola
    {
        public const string NOME = "Escola Secundária Emídio Navarro";

        private static string responsavelInformatica = "Por definir";

        public static string ObterResponsavel()
        {
            return responsavelInformatica;
        }

        // Devolve false (e não altera) se o nome tiver menos de 2 caracteres
        public static bool AlterarResponsavel(string nome)
        {
            if (nome == null || nome.Trim().Length < 2)
            {
                return false;
            }
            responsavelInformatica = nome.Trim();
            return true;
        }
    }
}