using System;
using System.Globalization;
using System.Collections.Generic;

namespace ListaFuncionarios
{
    class Funcionario
    {
        //Declaração de Atributos da Classe - Dados do Funcionário
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        //Construtor da Classe - Dados do Funcionário
        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        //Função - Aumentar Salário
        public void AumentarSalario(double porcentagem)
        {
            Salario += (porcentagem * Salario) / 100.0; 
        }

        //ToString - Dados do Funcionário
        public override string ToString()
        {
            return Id + ", " + Nome + ", R$ " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
