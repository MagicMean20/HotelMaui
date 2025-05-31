using HotelMaui.Models;

namespace HotelMaui
{
    public partial class App : Application
    {
        public List<Quarto> listaQuartos = new List<Quarto>
        {
            new Quarto(){Descricao="Suíte Super Luxo",ValorAdulto=110.0,ValorCrianca=55.0},
            new Quarto(){Descricao="Suíte Luxo",ValorAdulto=80.0,ValorCrianca=45.0},
            new Quarto(){Descricao="Suíte Single",ValorAdulto=50,ValorCrianca=25},
            new Quarto(){Descricao="Suíte Crise",ValorAdulto=25,ValorCrianca=12.5}
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratarHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 600;
            window.Height = 650;
            return window;
        }
    }
}
