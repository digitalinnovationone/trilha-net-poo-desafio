namespace DesafioPOO.Models
{
    public class Carteira
    {
        protected int Credito { get; set; }
        protected List<string> historico = new();

        public Carteira(int credito) {
            Credito = credito;
        }
        public void Historico() {
            if (historico.Any()) {
                foreach(string acao in historico) {
                    Console.WriteLine(acao);
                }                
            } else {
                Console.WriteLine("Você ainda não realizou nenhuma ação com a sua carteira");
            }
        }
    }
}