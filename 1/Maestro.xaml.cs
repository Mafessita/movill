namespace _1;
using _1.Models;
using System.Collections.ObjectModel;

public partial class Maestro : ContentPage
{
    public ObservableCollection<MenuModels> MenuModels { get; set; } //listado de elementos que vana a ser parte del menu 
	public Maestro()
	{
		InitializeComponent();

        MenuModels = new ObservableCollection<MenuModels>();

        MenuModels.Add(new MenuModels
        {
            Nombre = "Antes del �xito",
            Actualizacion = "20/07/24",
            Imagen = "uno.jpg"
        });
        MenuModels.Add(new MenuModels
        {
            Nombre = "Antes del �xito",
            Actualizacion = "20/07/24",
            Imagen = "uno.jpg"
        });
        MenuModels.Add(new MenuModels
        {
            Nombre = "Antes del �xito",
            Actualizacion = "20/07/24",
            Imagen = "uno.jpg"
        });
        MenuModels.Add(new MenuModels
        {
            Nombre = "Antes del �xito",
            Actualizacion = "20/07/24",
            Imagen = "uno.jpg"
        });
        MenuModels.Add(new MenuModels
        {
            Nombre = "Antes del �xito",
            Actualizacion = "20/07/24",
            Imagen = "uno.jpg"
        });
        MenuModels.Add(new MenuModels
        {
            Nombre = "Antes del �xito",
            Actualizacion = "20/07/24",
            Imagen = "uno.jpg"
        });
        collection.ItemsSource = MenuModels;

    }
	//private void nose(object sender, EventArgs e)
    //{
    //    NavigationtoPage(new Nose()); //esto me lleva a l metodo que ya esta creado y hace el proceso que tiene el metodo navigationtopage
    //}
	private void NavigationtoPage(ContentPage page) // se crea un metodo que como parametro se va a recibir un contentpage que se llama page
	{
        App.FlyoutPage.Detail.Navigation.PushAsync(page);
        //cuando se dice app es para dirigirse a la pagina app.xaml
        //flyoutPage es para indicarme la propiedad que esta en el app
        //detail es para dirigirme a la pagina que quiero navegar
        //navigation es solo la funcion que dice navegar
        //para navegar hay dos formas en este caso se utilizo pushasync empuja y pos asia atras, y en el push las empieza a apilar
        App.FlyoutPage.IsPresented = false; //esto es para que se cierre el menu

    }

    private void collection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        MenuModels? itemSelected = (MenuModels)e.CurrentSelection.FirstOrDefault()!;
        NavigationtoPage(new General(itemSelected));
    }
}