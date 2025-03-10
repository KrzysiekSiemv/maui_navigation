using Navigation_Between.Model;

namespace Navigation_Between.View;

public partial class DetailedPage : ContentPage {
    public DetailedPage(User user) {
        InitializeComponent();
        // Binding z poziomu kodu
        BindingContext = user;
    }
}