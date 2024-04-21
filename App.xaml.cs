namespace EVegaT2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new Vistas.IniGrid()); //Cambio la pagina de ejecucion
        }
    }
}
