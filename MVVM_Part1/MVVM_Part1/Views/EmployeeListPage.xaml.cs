using MVVM_Part1.Models;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_Part1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeeListPage : ContentPage
    {
        private ObservableCollection<Employeelist> _employeeList = new ObservableCollection<Employeelist>();
        public EmployeeListPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            employeelistsListView.ItemsSource = _employeeList;
            
            base.OnAppearing();
        }

        void OnAddEmployeelist(object sender, System.EventArgs e)
        {
            var newEmployeelist = "Employee " + (_employeeList.Count + 1);

            _employeeList.Add(new Employeelist { Title = newEmployeelist });

            this.Title = $"{_employeeList.Count} Employees";
        }

        void OnEmployeelistSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var employeelist = e.SelectedItem as Employeelist;
            employeelist.IsActive = !employeelist.IsActive;

            employeelistsListView.SelectedItem = null;
                        
        }
    }
}
