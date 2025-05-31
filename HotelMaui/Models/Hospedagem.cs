namespace HotelMaui.Models
{
    public class Hospedagem
    {
        public Quarto QuartoSelecionado { get; set; } 
        public int qtdAdultos { get; set; }
        public int qtdCriancas { get; set; }
        public DateTime dtcheckIn { get; set; }
        public DateTime dtcheckOut { get; set; }
        public int Estadia
        {
            get => dtcheckOut.Subtract(dtcheckIn).Days;
        }
        public double valTotal
        {
            get
            {
                double valAdultos = qtdAdultos * QuartoSelecionado.ValorAdulto;
                double valCriancas = (qtdCriancas + QuartoSelecionado.ValorCrianca) * Estadia;
                double total = valAdultos + valCriancas;
                return total;
            }
        }
    }
}
