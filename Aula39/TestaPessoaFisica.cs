namespace Aula_38_08_02_21
{
    public class TestaPessoaFisica
    {
        static void Main(string[] args)
        {
            Fisica f1 = new Fisica();
            f1.dtNascimento = "01/01/2000";
            f1.CPF = "12345678-90";

            System.Console.WriteLine("Dados da Pessoa Fisica");
            System.Console.WriteLine("-------------------------");
            System.Console.WriteLine("Nome: " + f1.Nome);
            System.Console.WriteLine("Data de Nascimento: " + f1.dtNascimento);
            System.Console.WriteLine("CPF: " + f1.CPF);
            f1.Comer("Fisica");
        }
    }
}