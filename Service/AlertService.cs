using System.Net.WebSockets;
using Navigation_Between.Interface;

namespace Navigation_Between.Service;
public class AlertService : IAlertService {
    public async Task ShowAlert(string title, string message, string button){
        // Application.Current.MainPage jest już przestarzale, dlatego stosujemy teraz..:
        var currentPage = Application.Current?.Windows.FirstOrDefault()?.Page;
        if(currentPage != null)
            await currentPage.DisplayAlert(title, message, button);
    }

    // Typ okna, które pozwala na pobranie od użytkownika danych z inputa
    public async Task<string> ShowPrompt(string title, string message, string accept, string cancel, string placeholder) {
        var currentPage = Application.Current?.Windows.FirstOrDefault()?.Page;
        return currentPage != null ? await currentPage.DisplayPromptAsync(title, message, accept, cancel, placeholder) : "error";  
    }

    // Typ okna, w którym dajemy wybory od użytkownika
    public async Task<string> ShowAction(string title, string cancel, string destruction, string[] options){
        var currentPage = Application.Current?.Windows.FirstOrDefault()?.Page;
        return currentPage != null ? await currentPage.DisplayActionSheet(title, cancel, destruction, options) : "error";
    }
}