using TP3;

class Program
{
    public static void Main(string[] args)
    {
        bool verificador = true;
        BancoDeAlunos bancodealunos = new BancoDeAlunos();
        do
        {
            Aluno aluno = new Aluno();
            try
            {
                Console.WriteLine("Sistema de Cadastro para o Fies");
                Console.WriteLine("[1] - Cadastro");
                Console.WriteLine("[2] - Verificar Fila");
                Console.WriteLine("[3] - Verificar Inscricao pela matricula");
                Console.WriteLine("[0] - Sair");
                Console.Write("Digite sua opcao: ");
                int opcao = int.Parse(Console.ReadLine());
                    switch (opcao)
                    {
                        case 1:
                            CadastroAluno.Cadastrar(aluno, bancodealunos);
                            break;
                        case 2:
                            BancoDeAlunos.verFila(bancodealunos);
                            break;
                        case 3:
                            BancoDeAlunos.verificarMatricula(bancodealunos);  
                            break;
                        case 0:
                            Console.WriteLine("Obrigado por utilizar o programa");
                            verificador = false; 
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Digite novamente");
                            break;
                    }
            }
            catch (FormatException ex)
            {
                Console.Clear();
                Console.WriteLine("Error");
                Console.WriteLine("Digite novamente");
                Console.ReadKey();
                Console.Clear();
            }
            finally
            {
                
            }
        } while (verificador);
    }
}