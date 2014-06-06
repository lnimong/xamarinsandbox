using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using App.WP8.Resources;
using App.Common.ModelMVC;
using System.Windows.Input;
using Microsoft.Phone.Tasks;

namespace App.WP8.ViewModels
{
    public class CallViewModel : INotifyPropertyChanged
    {
        private CallModelMVC callmodel;

        public CallViewModel()
        {
            this.callmodel = new CallModelMVC();

            PhoneCallTask phoneCallTask = new PhoneCallTask();

            phoneCallTask.PhoneNumber = this.callmodel.PhoneNumber;
            phoneCallTask.DisplayName = this.callmodel.PhoneNumber;

            phoneCallTask.Show();
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