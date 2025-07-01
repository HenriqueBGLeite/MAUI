using AppMAUIGallery.Views.Lists.Models;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace AppMAUIGallery.Views.Lists;

public partial class CollectionViewPage : ContentPage
{
    ObservableCollection<Movie> movies = new ObservableCollection<Movie>();
    int countMovies = 0;

    public CollectionViewPage()
	{
		InitializeComponent();

        AddTenMovies();

        CollectionViewControl.ItemsSource = MovieList.GetGroupList();
    }

    private void RefreshView_Refreshing(object sender, EventArgs e)
    {
        _ = RefreshAsync(sender);
    }

    private async Task RefreshAsync(object sender)
    {
        ((RefreshView)sender).IsRefreshing = true;

        await Task.Delay(3000);
        CollectionViewControl.ItemsSource = MovieList.GetList();

        ((RefreshView)sender).IsRefreshing = false;
    }

    private void AddTenMovies()
    {
        for (int i = 0; i < 10; i++)
        {
            Movie movie = new Movie()
            {
                Id = countMovies++,
                Name = $"Movie {countMovies}",
                Description = $"Description {countMovies}",
                LaunchYear = 2025,
                Duration = new TimeSpan(2,0,0)
            };

            movies.Add(movie);
        }
    }

    private void CollectionViewControl_Scrolled(object sender, ItemsViewScrolledEventArgs e)
    {
        LblScrollStatus.Text = $"Posicionamento: {e.VerticalOffset} - Espaçamento: {e.VerticalDelta}";

        if (sender is CollectionView cv)
        {
            var LastVisibleItem = e.LastVisibleItemIndex; //17

            var RemainingItemsThreshold = cv.RemainingItemsThreshold; //3

            if (cv.ItemsSource is null)
                return;

            var TotalItem = ((IEnumerable<object>)cv.ItemsSource).Count();

            if (LastVisibleItem > (TotalItem - RemainingItemsThreshold))
            {
                AddTenMovies();
            }
        }
    }

    private void CollectionViewControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        StringBuilder sb = new StringBuilder();

        foreach(Movie movie in e.CurrentSelection)
        {
            sb.Append(movie.Name + " - ");
        }

        LblSelectedMovies.Text = sb.ToString();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var group = (List<GroupMovie>)CollectionViewControl.ItemsSource;
        var item = group[1][3];


        CollectionViewControl.ScrollTo(item, position: ScrollToPosition.Start);
    }
}