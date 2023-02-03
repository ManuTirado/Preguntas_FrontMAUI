using Microsoft.AspNetCore.SignalR.Client;

namespace FrontMaui;

public partial class App : Application
{
    public static HubConnection _connection;

	public App()
	{
        /*
		InitializeComponent();
        _connection = new HubConnectionBuilder()
                .WithUrl(clsConexionSignarR.obtenerConexionChat() + "chatHub")
                .Build();


        _connection.On<Mensaje>("ReceiveMessage", (message) => RecibirMensaje(message));
        MainPage = new AppShell();
        */
	}
}
