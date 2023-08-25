using CollectionViewDemos.Models;
using CollectionViewDemos.ViewModels;

namespace CollectionViewDemos.Views
{
    public partial class VerticalListPage : ContentPage
    {
        public VerticalListPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }

        private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var model = e.CurrentSelection.FirstOrDefault() as Monkey;
            await DisplayAlert("Monkey Selected", model.Details[0], "OK");
        }
    }
}
