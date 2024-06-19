using _253504_Patrebka.UI.ViewModels;

namespace _253504_Patrebka.UI.Pages;

public partial class EditAdvertisement : ContentPage
{
	public EditAdvertisement(EditAdvertisementViewModel editAdvertisementViewModel)
	{
		InitializeComponent();

		BindingContext = editAdvertisementViewModel;
	}
}