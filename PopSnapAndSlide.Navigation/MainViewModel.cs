using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PopSnapAndSlide.Navigation
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public enum NavigationState
        {
            Red,
            Blue
        }

        private NavigationState _navigation;

        public NavigationState Navigation
        {
            get { return _navigation; }
            set { _navigation = value; FirePropertyChanged("Navigation"); }
        }

        public ICommand RedButton
        {
            get
            {
                return new NavigationStateCommand(this, NavigationState.Red);
            }
        }

        public ICommand BlueButton
        {
            get
            {
                return new NavigationStateCommand(this, NavigationState.Blue);
            }
        }

        private void FirePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
