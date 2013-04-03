using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace PopSnapAndSlide.Navigation
{
    public class NavigationStateCommand : ICommand
    {
        private MainViewModel mainViewModel;
        private MainViewModel.NavigationState navigationState;

        public NavigationStateCommand(MainViewModel mainViewModel, MainViewModel.NavigationState navigationState)
        {
            // TODO: Complete member initialization
            this.mainViewModel = mainViewModel;
            this.navigationState = navigationState;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
        public void Execute(object parameter)
        {
            mainViewModel.Navigation = navigationState;
        }
    }
}
