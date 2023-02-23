namespace Notes;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		// Register routing for notes pages 
        Routing.RegisterRoute(nameof(Views.NotePage), typeof(Views.NotePage));

    }
}

