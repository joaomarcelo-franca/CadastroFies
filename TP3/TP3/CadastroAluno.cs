using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class CadastroAluno
    {
        private static int matricula = 0;
        public static void Cadastrar(Aluno aluno, BancoDeAlunos bancodealunos)
        {
            string data;
            string[] nascimento;
            aluno.Matricula = matricula;
            matricula++;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Area de Cadrastamento");
            Console.ResetColor();
            Console.Write("Informe seu nome: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Informe seu curso: ");
            aluno.Curso = Console.ReadLine();
            Console.Write("Informe sua renda familiar: ");
            aluno.RendaFamiliar = double.Parse(Console.ReadLine());
            Console.Write("Informe sua Data de Nascimento dd/mm/yyyy: ");
            data = Console.ReadLine();
            nascimento = data.Split("/");
            aluno.DataDeNascimento = new DateTime(int.Parse(nascimento[2]), int.Parse(nascimento[1]), int.Parse(nascimento[0]));
            aluno.Idade = aluno.CalcularIdade(aluno.DataDeNascimento);
            bancodealunos.AdicionarAluno(aluno);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{aluno.Nome} cadrastado com sucesso com matricula {aluno.Matricula}");
            Console.WriteLine();
            Console.WriteLine("Aperte alguma tecla para prosseguir");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        } 
    }
}
