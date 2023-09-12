using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class BancoDeAlunos
    {
        public List<Aluno> alunosCadastrados = new List<Aluno>();
        
        public void AdicionarAluno(Aluno aluno)
        {
            alunosCadastrados.Add(aluno);
        }
        
        public static void verFila(BancoDeAlunos banco)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Area de Fila");
            Console.ResetColor();
            if (banco.alunosCadastrados.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nenhum Aluno Cadastrado");
                Console.ResetColor();
                
            } else
            {
                foreach (var aluno in banco.alunosCadastrados)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Nome: {aluno.Nome}");
                    Console.WriteLine($"Curso: {aluno.Curso}");
                    Console.WriteLine($"Renda Familiar: {aluno.RendaFamiliar}");
                    Console.WriteLine($"Data de Nascimento: {aluno.DataDeNascimento}");
                    Console.WriteLine($"Matrícula: {aluno.Matricula}");
                    Console.WriteLine($"Idade: {aluno.Idade}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Aperte alguma tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }
        public static void verificarMatricula(BancoDeAlunos banco)
        {
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("Area de verificar inscricao por matricula");
            Console.ResetColor();
            Console.Write("Digite a matricula do aluno: ");
            int matriculaEntrada = int.Parse(Console.ReadLine());
            Aluno alunoMatricula = banco.alunosCadastrados.Find(aluno => aluno.Matricula == matriculaEntrada);
            if (alunoMatricula == null)
            {
                Console.WriteLine("Nenhum aluno encontrado com essa matricula");
            } else
            {
                Console.WriteLine("Aluno encontrado");
                Console.WriteLine();
                Console.WriteLine($"Nome: {alunoMatricula.Nome}");
                Console.WriteLine($"Curso: {alunoMatricula.Curso}");
                Console.WriteLine($"Renda Familiar: {alunoMatricula.RendaFamiliar}");
                Console.WriteLine($"Data de Nascimento: {alunoMatricula.DataDeNascimento}");
                Console.WriteLine($"Matrícula: {alunoMatricula.Matricula}");
                Console.WriteLine($"Idade: {alunoMatricula.Idade}");
                Console.WriteLine();
            }
            Console.WriteLine("Aperte alguma tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
