using Navigation_Between.Interface;
using Navigation_Between.Service;
using Navigation_Between.ViewModel;

namespace Navigation_Between.View;

public partial class MainPage : ContentPage {
	public MainPage() {
		InitializeComponent();
		BindingContext = new MainViewModel(Navigation, new DataService(), new AlertService());
	}
}

