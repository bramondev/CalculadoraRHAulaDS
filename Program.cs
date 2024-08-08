using System;
using Aula02RH.Models;
using Aula02RH.Models.Enuns;

namespace Aula02RH
{
    public class Program
    {
        static int Main(string[] args)
        {
           /* Funcionario fuc = new Funcionario();

            fuc.Id = 1;
            fuc.Nome = "Ramon";
            fuc.Cpf = "12345678910";
            fuc.DataAdmissão = DateTime.Parse("01/01/2000");
            fuc.Salario = 1000000;
            fuc.TipoFuncionario = TipoFuncionarioEnum.Clt; 

            string mensagem = fuc.ExibirTempodeExperiencia();
            Console.WriteLine("==============================");
            Console.WriteLine(mensagem);
            Console.WriteLine("=============================="); */

            Funcionario func = new Funcionario();

            Console.WriteLine("Escreva seu nome:");
            func.Nome = Console.ReadLine();
            
            Console.WriteLine("digite o id do funcionario:");
            func.Id = int.Parse (Console.ReadLine());
            
            Console.WriteLine("Escreva seu nome:");
            func.Cpf = Console.ReadLine();
            
            Console.WriteLine("Escreva seu nome:");
            func.DataAdmissão = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine("Escreva seu nome:");
            func.Salario = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Escreva seu nome:");
            func.Nome = Console.ReadLine();

            Console.WriteLine("Tipo de contrato");
            int opcao = int.Parse ( Console.ReadLine());

            func.TipoFuncionario = (opcao = 1 ) ? TipoFuncionarioEnum.Clt : TipoFuncionarioEnum.Aprendiz;

            func.ReajustarSalario();
            decimal ValordescontoVT = func.CalcularDesconto(6);

            Console.WriteLine(" =========================");
            Console.WriteLine($" o Salario reajustado é {func.Salario}./n");
            Console.WriteLine($" Desconto do Vt é {ValordescontoVT}. /n");
            Console.WriteLine(" =========================");

           
            


        }
    }

}