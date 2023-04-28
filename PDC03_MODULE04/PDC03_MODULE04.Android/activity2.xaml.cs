using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collection.ObjectModel;

namespace PDC03_MODULE04.Droid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity2 : ContentPage
    {
        public activity2()
        {
            InitializeComponent();
            EmployeeView.ItemSource = employees;

            employees.Add(new Employee { DisplayName = "Juan Dela Cruz", Position = "President" });
            employees.Add(new Employee { DisplayName = "John Doe", Position = "Vice President" });
            employees.Add(new Employee { DisplayName = "Peter Dela Cruz", Position = "Director" });
            employees.Add(new Employee { DisplayName = "Mark Dela Cruz", Position = "Supervisor" });
        }

        InitializeComponent()

        private void Add_item(object sender, EventArgs  e)
        {

        }

        private void Edit_item(object sender, EventArgs e)
        {

        }

        private void Delete_item(object sender, EventArgs e)
        {

        }

    }
}