using _253504_Patrebka.UI.ViewModels;

namespace _253504_Patrebka.UI.Pages;

public partial class AddCar : ContentPage
{
	public AddCar(AddCarViewModel addCarViewModel)
	{
		InitializeComponent();

		BindingContext = addCarViewModel;
	}
}