namespace Navigation_Between.Interface;
// Tworzenie interfejsu serwisu Alert nie jest wymagane, ale jest dobrą praktyką w kontekście architektury aplikacji
public interface IAlertService {
    Task ShowAlert(string title, string message, string button);
    Task<string> ShowPrompt(string title, string message, string accept, string cancel, string placeholder);
    Task<string> ShowAction(string title, string cancel, string destruction, string[] options);
}