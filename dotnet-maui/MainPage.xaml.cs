namespace dotnet_maui;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
	{
		InitializeComponent();
	}

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count += 1;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    private async void OnNewPageClicked(object sender, EventArgs e)
    {
        // 同じウィンドウ内で画面遷移
        await Shell.Current.GoToAsync("//PhonewordTranslator");
    }
}

