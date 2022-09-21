namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            if (Suite.Capacidade>=hospedes.Count())
            {
                Hospedes = hospedes;
            }
            else
            {   
                System.Console.WriteLine("A capacidade da suite não conporta a quantidade de hospedes.");
            } 
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
             int qtd = Hospedes.Count(); 
            return qtd;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados>=10)
            {
                valor = valor /100 * 90;
            }
            return valor;
        }
    }
}