using System;
using System.Data;
using Aula02RH.Models;
using Aula02RH.Models.Enuns;

namespace Aula02RH
{
    class Program
    {
        static void Main(string[] args)
        {   
            /*
            Funcionario func = new Funcionario();

            func.Id = 10;
            func.Nome = "Neymar";
            func.Cpf = "12345678910";
            func.DataAdmissao = DateTime.Parse("01/01/2000");
            func.Salario = 10000.00M;
            func.TipoFuncionario = Models.Enuns.TipoFuncionarioEnum.CLT;

            string mensagem = func.ExibirPeriododeExperiencia();
            Console.WriteLine("=====================================================================");
            Console.WriteLine(mensagem);
            Console.WriteLine("=====================================================================");
            */

            Funcionario func = new Funcionario();

            Console.WriteLine("Digite o Id do funcionário: ");
            func.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do funcionário: ");
            func.Nome = Console.ReadLine();

            Console.WriteLine("DIgite o CPF: ");
            func.Cpf = Console.ReadLine();

            Console.WriteLine("Digite a data de admissão: ");
            func.DataAdmissao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Salário: ");
            func.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Escolha o tipo de Funcionário (1 - CLT / 2 - Aprendiz): ");
            int opcao = int.Parse(Console.ReadLine());

            // Operador ternário - interpretação: Se a condição de parentesess for verdadeira,
            // escolhe o que está depois da "?", Caso contrário, escolhe o que está depois dos ":"

            func.TipoFuncionario = (opcao == 1) ? TipoFuncionarioEnum.CLT : TipoFuncionarioEnum.Aprendiz;

            func.ReajustarSalario();
            decimal valorDescontoVT = func.CalcularDescontoVT(6);

            Console.WriteLine("================================");
            Console.WriteLine($"O salário reajustado é {func.Salario}.\n");
            Console.WriteLine($"O desconto do VT é {valorDescontoVT}.\n");
            Console.WriteLine("================================");



        }
    }
}
