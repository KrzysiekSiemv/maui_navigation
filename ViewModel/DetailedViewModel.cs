using System.Windows.Input;
using Navigation_Between.Model;

namespace Navigation_Between.ViewModel;

public class DetailedViewModel
{
    public User SelectedUser { get; }

    public ICommand EditDescriptionCommand { get; }
    public ICommand EditEmailCommand { get; }

    public DetailedViewModel(User user)
    {
        SelectedUser = user;

        EditDescriptionCommand = new Command(async () => await EditDescription());
        EditEmailCommand = new Command(async () => await EditEmail());
    }

    private async Task EditDescription()
    {
        string result = await Shell.Current.DisplayPromptAsync(
            "Edytuj opis",
            "Podaj nowy opis:",
            "OK",
            "Anuluj",
            SelectedUser.Description
        );

        if (!string.IsNullOrWhiteSpace(result)){
            SelectedUser.Description = result;
        }
    }

    private async Task EditEmail()
    {
        string result = await Shell.Current.DisplayPromptAsync(
            "Edytuj e-mail",
            "Podaj nowy adres e-mail:",
            "OK",
            "Anuluj",
            SelectedUser.Email
        );

        if (!string.IsNullOrWhiteSpace(result))
        {
            SelectedUser.Email = result;
        }
    }
}
