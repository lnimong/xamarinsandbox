using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;

namespace App.WP8.ViewModels
{
    public class GoCommand : ICommand
    {
        public GoCommand(Action gotopage)
        {
            this.gotopage = gotopage;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
        private Action gotopage;

        public void Execute(object parameter)
        {
            gotopage();
        }
    }

    public class ItemViewModel : INotifyPropertyChanged
    {
        private string _lineOne;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string LineOne
        {
            get
            {
                return _lineOne;
            }
            set
            {
                if (value != _lineOne)
                {
                    _lineOne = value;
                    NotifyPropertyChanged("LineOne");
                }
            }
        }

        private string _lineTwo;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string LineTwo
        {
            get
            {
                return _lineTwo;
            }
            set
            {
                if (value != _lineTwo)
                {
                    _lineTwo = value;
                    NotifyPropertyChanged("LineTwo");
                }
            }
        }

        private string _lineThree;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string LineThree
        {
            get
            {
                return _lineThree;
            }
            set
            {
                if (value != _lineThree)
                {
                    _lineThree = value;
                    NotifyPropertyChanged("LineThree");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private Common.ModelMVC.MenuLinkModelMVC menuLinkModelMVC;

        public ICommand Go
        {
            get
            {
                return goCommand;
            }
            set
            {
                if (value != goCommand)
                {
                    goCommand = value;
                    NotifyPropertyChanged("Go");
                }
            }
        }

        public ItemViewModel(Common.ModelMVC.MenuLinkModelMVC model)
        {
            // TODO: Complete member initialization
            this.menuLinkModelMVC = model;
            this.LineOne = model.Label;
            goCommand = new GoCommand(() => RequireNavigation(model.Page));
        }

        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        public event Action<string> RequireNavigation;
        private ICommand goCommand;
    }
}