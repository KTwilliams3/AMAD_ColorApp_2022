namespace ColorApp;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void MagentaClicked(object sender, EventArgs e)
	{
		cPage.Background = Color.Parse("Magenta");

	}

	private void OrangeClicked(object sender, EventArgs e)
	{
        cPage.Background = Color.Parse("Orange");

    }

	private void ResetClicked(object sender, EventArgs e)
	{
        cPage.Background = Color.Parse("Black");

    }
}

