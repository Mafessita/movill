using _1.Models;

namespace _1;

public partial class General : ContentPage
{
	public MenuModels Model { get; set; }
	
    public General(MenuModels model)
    {
        InitializeComponent();
		this.Model = model;
		this.BindingContext = this; //tu fuente de datos va a ser tu mismo
    }
}