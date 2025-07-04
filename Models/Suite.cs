namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite(string tipodeSuite, int capacidade, int valorDiaria)
        {
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}