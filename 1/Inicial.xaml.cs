namespace _1;

public partial class Inicial : FlyoutPage //se pone tipo flyout paga que sea cree un menu desplegable
{
	public Inicial()
	{
		InitializeComponent();

		Detail = new NavigationPage( new Detalle()); //se indica quien va a ser la pagina que va a ser detalle y quien es el maestro
		                                              // para poder navegar(entrar a los botones) que se hace en detalles ya que es la que nos muestra la informacion, para ello se pone navigatopage
		Flyout = new Maestro(); //se asigna 
		App.FlyoutPage = this; //se toma del app la propiedad y se le asigna el valor de esta pagina  
	}
}