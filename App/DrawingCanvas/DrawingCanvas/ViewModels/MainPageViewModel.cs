using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;


namespace DrawingCanvas.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        public AsyncCommand<ObservableCollection<Point>> DrawingCompleteCommand { get; set; }

        private ImageSource _backgroundSource;

        public ImageSource BackgroundImage { get { return _backgroundSource; } set { _backgroundSource = value; RaisePropertyChanged(nameof(BackgroundImage)); } }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            DrawingCompleteCommand = new AsyncCommand<ObservableCollection<Point>>(DrawingCompleteAction);
        }

        private async Task DrawingCompleteAction(ObservableCollection<Point> points)
        {
            await Task.Delay(500);   
        }

    }
}
