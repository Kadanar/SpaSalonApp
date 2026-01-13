using CommunityToolkit.Mvvm.ComponentModel;
using SpaSalon.Application.Interfaces;
using SpaSalon.Domain.Entities;

namespace SpaSalon.Maui.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly IUnitOfWork _uow;

    [ObservableProperty]
    List<SpaProcedureType> procedureTypes = new();

    [ObservableProperty]
    SpaProcedureType? selectedType;

    public MainViewModel(IUnitOfWork uow)
    {
        _uow = uow;
        Load();
    }

    async void Load()
    {
        ProcedureTypes = await _uow.SpaProcedureTypes.GetAllAsync();
    }
}
