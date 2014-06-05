using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using App.WP8.Resources;
using App.Common.ModelMVC;
using System.Windows.Input;

namespace App.WP8.ViewModels
{
    public class BuyViewModel : INotifyPropertyChanged
    {
        private BuyModelMVC buymodel;

        public BuyViewModel(string carId)
        {
            this.buymodel = new BuyModelMVC(carId, null);
        }

        public BuyModelMVC BuyModel
        {
            get
            {
                return this.buymodel;
            }
            set
            {
                this.buymodel = value;
                this.NotifyPropertyChanged("BuyModel");
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