using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using App.WP8.Resources;
using App.Common.ModelMVC;
using System.Windows.Input;
using Microsoft.Phone.Tasks;

namespace App.WP8.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            InitMenu();
            
            this.rentmodel = new CategoryListModelMVC ();

            var vm = new CategoryListModelMVC();

            this.RentItems = new ObservableCollection<CategoryModelMVC>(vm.Categories);

            var vmCars = new CarListModelMVC();

            this.CarsItems = new ObservableCollection<CarModelMVC>(vmCars.Cars);
        }

        private void InitMenu()
        {
            this.menumodel = new MainMenuModelMVC();

            this.MenuItems = new ObservableCollection<ItemViewModel>();

            var about = new ItemViewModel(menumodel.AboutUs);
            about.RequireNavigation += (uri) => Goto(uri);
           MenuItems.Add(about);

            var call = new ItemViewModel(menumodel.CallUs);
            call.RequireNavigation += (uri) =>
            {
                var callmodel = new CallModelMVC();

                PhoneCallTask phoneCallTask = new PhoneCallTask();

                phoneCallTask.PhoneNumber = callmodel.PhoneNumber;
                phoneCallTask.DisplayName = callmodel.PhoneNumber;

                phoneCallTask.Show();
            };
            MenuItems.Add(call);

            var mail = new ItemViewModel(menumodel.MailUs);
            mail.RequireNavigation += (uri) => Goto(uri);
            MenuItems.Add(mail);
        }

        public ICommand RentClick
        {
            get
            {
                return new RelayCommand<CategoryModelMVC>(c => this.Goto(c.RentPage));
            }
        }

        public ICommand CarClick
        {
            get
            {
                return new RelayCommand<CarModelMVC>(c => this.Goto(c.BuyPage));
            }
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<ItemViewModel> MenuItems { get; private set; }
        public ObservableCollection<CategoryModelMVC> RentItems { get; private set; }
        public ObservableCollection<CarModelMVC> CarsItems { get; private set; }

        private string _sampleProperty = "Sample Runtime Property Value";
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding
        /// </summary>
        /// <returns></returns>
        public string SampleProperty
        {
            get
            {
                return _sampleProperty;
            }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        /// <summary>
        /// Sample property that returns a localized string
        /// </summary>
        public string LocalizedSampleProperty
        {
            get
            {
                return AppResources.SampleProperty;
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            this.IsDataLoaded = true;
        }


        public event Action<string> Goto;
        public event PropertyChangedEventHandler PropertyChanged;
        private MainMenuModelMVC menumodel;
        private CategoryListModelMVC rentmodel;
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