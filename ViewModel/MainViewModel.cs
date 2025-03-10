using System.Collections.ObjectModel;
using Navigation_Between.Interface;
using Navigation_Between.Model;
using Navigation_Between.Service;
using Navigation_Between.View;

namespace Navigation_Between.ViewModel;

public class MainViewModel {
    public ObservableCollection<User> Users { get; set; }
    public Command<User> SelectUserCommand { get; }

    private readonly INavigation _navigation;
    private readonly IAlertService _alertService;
    private readonly DataService _dataService;

    public MainViewModel(INavigation navigation, DataService dataService, IAlertService alertService) {
        _navigation = navigation;
        _dataService = dataService;
        _alertService = alertService;

        Users = new ObservableCollection<User>(_dataService.GetUsers());
        SelectUserCommand = new Command<User>(OnItemSelected);
    }

    async void OnItemSelected(User user){
        if(user != null)
            await _navigation.PushAsync(new DetailedPage(user));
    }
}