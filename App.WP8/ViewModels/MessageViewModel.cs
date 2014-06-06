using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using App.WP8.Resources;
using App.Common.ModelMVC;
using System.Windows.Input;

namespace App.WP8.ViewModels
{
    public class MessageViewModel : INotifyPropertyChanged
    {
        private MailModelMVC mailModel;

        public MessageViewModel()
        {
            this.mailModel = new MailModelMVC(null);
        }

        public MailModelMVC MailModel
        {
            get
            {
                return this.mailModel;
            }
            set
            {
                this.mailModel = value;
                this.NotifyPropertyChanged("MailModel");
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