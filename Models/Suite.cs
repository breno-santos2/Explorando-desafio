namespace DesafioProjetoHospedagem.Models
{
    // Construtor padrão
    public class Suite
    {
        public Suite() { }

        // Construtor que recebe tipo de suíte, capacidade e valor da diária
        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        // Propriedade que representa o tipo da suíte
        public string TipoSuite { get; set; }
        // Propriedade que representa a capacidade máxima da suíte
        public int Capacidade { get; set; }
        // Propriedade que representa o valor da diária da suíte
        public decimal ValorDiaria { get; set; }
    }
}