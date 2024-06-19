using _253504_Patrebka.UI.ViewModels;

namespace _253504_Patrebka.UI.Pages;

public partial class AddAdvertisement : ContentPage
{
	public AddAdvertisement(AddAdvertisementViewModel addAdvertisementViewModel)
	{
		InitializeComponent();

		BindingContext = addAdvertisementViewModel;
	}
}