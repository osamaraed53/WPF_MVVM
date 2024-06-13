using System;

namespace MVVMProject.MVVM;

public interface INavigationService
{
    ViewModelBase CurrentViewModel { get; }
    void NavigateTo<T>() where T : ViewModelBase;
}

public class NavigationService : ViewModelBase, INavigationService
{

    private readonly Func<Type, ViewModelBase> _viewModelFactory;
    private ViewModelBase _currentViewModel;


    public NavigationService(Func<Type, ViewModelBase> viewModelFactory)
    {
        _viewModelFactory = viewModelFactory;
    }

    public ViewModelBase CurrentViewModel
    {
        get => _currentViewModel;
        private set
        {
            _currentViewModel = value;
            OnPropertyChanged();
        }
    }

    public void NavigateTo<TViewModel>() where TViewModel : ViewModelBase
    {
        ViewModelBase viewModel = _viewModelFactory.Invoke(typeof(TViewModel));
        CurrentViewModel = viewModel;
    }
}
