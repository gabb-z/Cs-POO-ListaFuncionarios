using System;
using System.Globalization;
using System.Collections.Generic;

namespace ListaFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de Dados - Quantidade de Funcionários
            Console.Write("Quantos funcionários deseja cadastrar: ");
            int N = int.Parse(Console.ReadLine());

            //Declaração de Lista - Dados do Funcionário
            List<Funcionario> listaFuncionario = new List<Funcionario>();

            //Condição - Entrada de Dados do Funcionário
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"\nEmpregado #{i}:");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listaFuncionario.Add(new Funcionario(id, nome, salario));
            }

            //Entrada de Dados - Aumentar Salário
            Console.Write("\nDigite o ID do funcionário que deseja aumentar o salário: ");
            int buscarId = int.Parse(Console.ReadLine());
            Funcionario func = listaFuncionario.Find(x => x.Id == buscarId);

            //Condição - Buscar ID
            if (func != null)
            {
                Console.Write("\nDigite a porcentagem que deseja alterar o salário do funcionário: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.AumentarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("\nID inválido!");
            }

            //Saída de Dados do Funcionário
            Console.WriteLine("\nLista de funcionário(s) atualizada: \n");
            foreach (Funcionario obj in listaFuncionario)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
