namespace _1
{
    public partial class App : Application
    {
        public static FlyoutPage FlyoutPage { get; set; } //propiedad estatica que nos deja asignar y obtener un valor para el señor flyoutpage(esto se hizo para que este señor sea de acseso publico y cuando entre a cualquier pagina siga regresandome a la pricipal) 
        public App()
        {
            InitializeComponent();

            MainPage = new Inicial();//inicializamos nuestra app en la pestaña inicio
        }
    }
}
