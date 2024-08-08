using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Aula02RH.Models.Enuns;

namespace Aula02RH.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public string Cpf { get; set; } = string.Empty;
        public DateTime DataAdmissão { get; set; }
        public int Salario { get; set; }
        public TipoFuncionarioEnum TipoFuncionario { get; set; }

        public void ReajustarSalario()
        {
            Salario = Salario + (Salario * 10 / 100);
        }

        public string ExibirTempodeExperiencia()
        {
            string PeriodoExperiencia =
            string.Format("Periodo de experiecia foi de {0} até {1}", DataAdmissão, DataAdmissão.AddMonths(3));
            return PeriodoExperiencia;
        }

        public decimal CalcularDesconto(decimal percentual)
        {
            decimal desconto = this.Salario * percentual / 100;
            return desconto;
        }

        private int ContarCaracteres(string dado)
        {
            return dado.Length;
        }

        public bool ValidarCpf()
        {
            if (ContarCaracteres(Cpf) == 11)

                return true;

            else
                return false;
        }



    }



}
