using System.Collections.ObjectModel;
using Navigation_Between.Model;

namespace Navigation_Between.Service;

// Serwis, który przechowuje dane, dzięki którym możemy przerzucać dane między oknami
public class DataService {
    // Lista użytkowników
    private ObservableCollection<User> users;

    public DataService() {
        users = new () {
            new () { Id = 1, Name = "Kristiano", Description = "Someone" },
            new () { Id = 2, Name = "Marian", Description = "Polak jakich mało" },
            new () { Id = 3, Name = "Blanka", Description = "bejbe" }
        };
    }    

    // Dodawanie czy usuwanie elementów do listy w ObservableCollection NIE WYMAGA INotifyPropertyChanged,
    // Stosujemy to w momencie, kiedy modyfikujemy wlaściwość naszego elementu, np.: Imie osoby o ID nr. 1
    public ObservableCollection<User> GetUsers() => users;

    public void AddUser(User user) {
        users.Add(user);
    }

    public void RemoveUser(User user) {
        users.Remove(user);
    }
}