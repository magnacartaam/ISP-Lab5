using _253504_Patrebka.UI.ViewModels;

namespace _253504_Patrebka.UI.Pages;

public partial class AdvertisementDetails : ContentPage
{
	public AdvertisementDetails(AdvertisementDetailsViewModel advertisementDetailsViewModel)
	{
		InitializeComponent();

		BindingContext = advertisementDetailsViewModel;
	}
}