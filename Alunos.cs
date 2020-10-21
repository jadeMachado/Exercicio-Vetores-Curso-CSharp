namespace Vetores
{
    public class Alunos
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int NumeroQuarto { get; set; }

        public Alunos()
        {

        }

        public Alunos(string nome, string email, int numeroQuarto)
        {
            Nome = nome;
            Email = email;
            NumeroQuarto = numeroQuarto;
        }

        public override string ToString()
        {
            return NumeroQuarto
            + ": "
            + Nome
            + ", "
            + Email;
        }
    }
}