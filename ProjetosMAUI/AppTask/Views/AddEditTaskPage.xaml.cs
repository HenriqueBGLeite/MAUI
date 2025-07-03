using AppTask.Models;
using AppTask.Repositories;
using System.Text;

namespace AppTask.Views;

public partial class AddEditTaskPage : ContentPage
{
    private ITaskModelRepository _repository;
    private TaskModel _task;
    private int idTask;

    public AddEditTaskPage()
	{
		InitializeComponent();

        _repository = new TaskModelRepository();
        _task = new TaskModel();

        BindableLayout.SetItemsSource(BindableLayout_Steps, _task.SubTasks);
    }

    public AddEditTaskPage(TaskModel task)
    {
        _repository = new TaskModelRepository();

        InitializeComponent();
        _task = task;
        FillFields();

        BindableLayout.SetItemsSource(BindableLayout_Steps, _task.SubTasks);
    }

    private void FillFields()
    {
        EntryTaskName.Text = _task.Name;
        EditorTaskDescription.Text = _task.Description;
        DatePickerTaskDate.Date = _task.PrevisionDate;
    }

    private void CloseModal(object sender, EventArgs e)
    {
		Navigation.PopModalAsync();
    }

    private void SaveData(object sender, EventArgs e)
    {
        //Obter
        GetDataFromForm();
        //Validar
        bool valid = ValidateData();
        if (valid)
        {
            //Salvar
            SaveInDatabase();
            //Fechar a tela
            Navigation.PopModalAsync();
            //Atualizar listagem da tela anterior
            UpdateListInStartPage();
        }
    }

    private void UpdateListInStartPage()
    {
        var navPage = (NavigationPage)App.Current.MainPage;
        var startPage = (StartPage)navPage.CurrentPage;
        startPage.LoadData();
    }

    private void SaveInDatabase()
    {
        if (_task.Id == 0)
            _repository.Add(_task);
        else
            _repository.Update(_task);
    }

    private bool ValidateData()
    {
        bool validResult = true;
        LblTaskNameRequired.IsVisible = false;
        LblTaskDescriptionRequired.IsVisible = false;

        if (string.IsNullOrWhiteSpace(_task.Name))
        {
            LblTaskNameRequired.IsVisible = true;
            validResult = false;
        }

        if(string.IsNullOrWhiteSpace(_task.Description))
        {
            LblTaskDescriptionRequired.IsVisible = true;
            validResult = false;
        }

        return validResult;
    }

    private void GetDataFromForm()
    {
        _task.Name = EntryTaskName.Text;
        _task.Description = EditorTaskDescription.Text;
        _task.PrevisionDate = DatePickerTaskDate.Date;
        _task.PrevisionDate = _task.PrevisionDate.AddHours(23);
        _task.PrevisionDate = _task.PrevisionDate.AddMinutes(59);
        _task.PrevisionDate = _task.PrevisionDate.AddSeconds(59);

        _task.Created = DateTime.Now;
        _task.IsCompleted = false;
    }

    private async void AddStep(object sender, EventArgs e)
    {
        var stepName = await DisplayPromptAsync("Etapa (Subtarefa)", "Digite o nome da etapa (subtarefa)", "Adicionar", "Cancelar");

        if (!string.IsNullOrWhiteSpace(stepName))
        {
            _task.SubTasks.Add(new SubTaskModel { Name = stepName, IsCompleted = false });
        }
    }

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);

        DatePickerTaskDate.WidthRequest = width - 35;
    }

    private void OnTapToDelete(object sender, TappedEventArgs e)
    {
        _task.SubTasks.Remove((SubTaskModel)e.Parameter);
    }
}