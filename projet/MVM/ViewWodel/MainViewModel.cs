using projet.Core;

namespace projet.MVM.ViewWodel
{
    public class MainViewModel: ObservableObject
    {
        
        public RelayCommand HomeViewComand { get; set; }
        public RelayCommand CityViewComand { get; set; }
        
        public HomeModelView HomeModelVm { get; set; }
        public CityModelView CityModelVm { get; set; }
        
        
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value; 
                
                OnPropertyChanged();
            }
        }
       

        public MainViewModel()
        {
            HomeModelVm = new HomeModelView();
            CityModelVm = new CityModelView();

            _currentView = HomeModelVm;

            HomeViewComand = new RelayCommand(o => { CurrentView = HomeModelVm; });
            CityViewComand = new RelayCommand(o => { CurrentView = CityModelVm; });
        }
    }
}