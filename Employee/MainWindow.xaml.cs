using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Windows.Threading;


namespace Employee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private ObservableCollection<Employees> ShowEmployeeData()
        {
            ObservableCollection<Employees> oEmp = new ObservableCollection<Employees>();
           EmployeeInfoService.EmployeeInfoClient client = new EmployeeInfoService.EmployeeInfoClient();
           int count = 1;
            EmployeeInfoService.EmployeeData[] data = (EmployeeInfoService.EmployeeData[])client.getEmployees();
            foreach (var Employee in data)
            {
                Dispatcher.Invoke(new Action(() =>
                {
                    myProgressbar.Value = (count / data.Length) * 100;

                }), DispatcherPriority.DataBind, null);
               
                Employees emp = new Employees();
                emp.EmployeeID = Employee.Employee_ID;
                emp.EmployeeFirstName = Employee.FirstName;
                emp.EmployeeLastName = Employee.LastName;
                oEmp.Add(emp);
                count++;


            }
            return oEmp;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            lvEmployee.ItemsSource = null;
            myProgressbar.Value = 0;
            lvEmployee.Items.Clear();

            lvEmployee.ItemsSource = ShowEmployeeData();
        }

        
    }
    public class Employees
    {
        public int EmployeeID { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
    }

}
