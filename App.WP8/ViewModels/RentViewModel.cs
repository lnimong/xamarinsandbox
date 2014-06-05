using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using App.WP8.Resources;
using App.Common.ModelMVC;
using System.Windows.Input;

namespace App.WP8.ViewModels
{
    public class RentViewModel : INotifyPropertyChanged
    {
        private RentModelMVC rentmodel;

        public RentViewModel(string categoryId)
        {
            this.rentmodel = new RentModelMVC(categoryId, null);
        }

        public RentModelMVC RentModel
        {
            get
            {
                return this.rentmodel;
            }
            set
            {
                this.rentmodel = value;
                this.NotifyPropertyChanged("RentModel");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}