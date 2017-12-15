using MVVM_Part1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_Part1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeeDetails : ContentPage
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        public EmployeeDetails(Employeelist emp)
        {
            InitializeComponent();
            BindingContext = emp;
        }
    }
}
