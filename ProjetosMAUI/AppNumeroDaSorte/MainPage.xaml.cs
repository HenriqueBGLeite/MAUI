namespace AppNumeroDaSorte;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnGenerateLuckNumber(object sender, EventArgs e)
	{
		NameApp.IsVisible = false;
		ContainerLuckNumbers.IsVisible = true;

		var set = GenerateLuckNumbers();

		LuckNumber01.Text = set.ElementAt(0).ToString();
        LuckNumber02.Text = set.ElementAt(1).ToString();
        LuckNumber03.Text = set.ElementAt(2).ToString();
        LuckNumber04.Text = set.ElementAt(3).ToString();
        LuckNumber05.Text = set.ElementAt(4).ToString();
        LuckNumber06.Text = set.ElementAt(5).ToString();
    }

    private SortedSet<int> GenerateLuckNumbers()
	{
		var set = new SortedSet<int>();
		while(set.Count < 6)
		{
			var random = new Random();
			var luckNumber = random.Next(1, 60);

            set.Add(luckNumber);
		}

		return set;

    }
}