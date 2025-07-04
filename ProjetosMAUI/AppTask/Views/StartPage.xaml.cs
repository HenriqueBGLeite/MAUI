using AppTask.Models;
using AppTask.Repositories;

namespace AppTask.Views;

public partial class StartPage : ContentPage
{
    private ITaskModelRepository _repository;
    private IList<TaskModel> _tasks;
	public StartPage()
	{
		InitializeComponent();

        _repository = new TaskModelRepository();
        LoadData();
    }

    public void LoadData()
    {
        _tasks = _repository.GetAll();
        CollectionViewTasks.ItemsSource = _tasks;

        LblEmptyText.IsVisible = _tasks.Count <= 0;
    }

    private void OnButtonClickedToAdd(object sender, EventArgs e)
    {
		Navigation.PushModalAsync(new AddEditTaskPage());
    }

    private void OnBorderClickedToFocusEntry(object sender, TappedEventArgs e)
    {
        EntrySearch.Focus();
    }

    private async void OnImageClickedToDelete(object sender, TappedEventArgs e)
    {
        var task = (TaskModel)e.Parameter;

        var confirm = await DisplayAlert("Confirme a exclus�o!", 
                    $"Tem certeza de que deseja excluir essa tarefa: {task.Name}?", 
                    "Sim", 
                    "N�o");

        if (confirm)
        {
            _repository.Delete(task);

            LoadData();
        }
    }

    private void OnCheckBoxClickedToComplete(object sender, TappedEventArgs e)
    {
        var task = (TaskModel)e.Parameter;
        var checkbox = ((CheckBox)sender);

        if (DeviceInfo.Platform != DevicePlatform.WinUI)
            checkbox.IsChecked = !checkbox.IsChecked;

        task.IsCompleted = checkbox.IsChecked;        
        _repository.Update(task);
    }

    private void OnTapToEdit(object sender, TappedEventArgs e)
    {
        int idTask = (int)e.Parameter;
        Navigation.PushModalAsync(new AddEditTaskPage(_repository.GetById(idTask)));
    }

    private void OnTextChanged_FilterList(object sender, TextChangedEventArgs e)
    {
        var word = e.NewTextValue;

        CollectionViewTasks.ItemsSource =_tasks.Where(a => a.Name.ToLower().Contains(word.ToLower())).ToList();
    }
}