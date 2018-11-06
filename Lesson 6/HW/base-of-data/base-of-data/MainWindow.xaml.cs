using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace base_of_data
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		

		public MainWindow()
		{


			InitializeComponent();
			//1.Создание коллекциии департаментов, каждая илемент которой содержит имя департамента и коллекцию работников.
			ObservableCollection<Department> departments = new ObservableCollection<Department>();
			departments.Add(new Department { Name = "Developing", workers = new ObservableCollection<Worker> { new Worker { FirstName = "IvIvIv", Age = 24, LastName = "Developing", Salary = 1000 }, new Worker { FirstName = "IvIvIv", Age = 24, LastName = "Developing", Salary = 1000 }, new Worker { FirstName = "IvIvIv", Age = 24, LastName = "Developing", Salary = 1000 } } });
			departments.Add(new Department { Name = "Accountant", workers = new ObservableCollection<Worker> { new Worker { FirstName = "IvIvIv", Age = 24, LastName = "Developing", Salary = 1000 }, new Worker { FirstName = "IvIvIv", Age = 24, LastName = "Developing", Salary = 1000 }, new Worker { FirstName = "IvIvIv", Age = 24, LastName = "Developing", Salary = 1000 } } });
			departments.Add(new Department { Name = "Developing", workers = new ObservableCollection<Worker> { new Worker { FirstName = "IvIvIv", Age = 24, LastName = "Developing", Salary = 1000 }, new Worker { FirstName = "IvIvIv", Age = 24, LastName = "Developing", Salary = 1000 }, new Worker { FirstName = "IvIvIv", Age = 24, LastName = "Developing", Salary = 1000 } } });

			//2. в главном окне программы создал combobox, в котором отображаются департаменты (получилось). По замыслу, при выборе департамента показывается список работников департамента

			ListDep.ItemsSource = departments;
			ListDep.DisplayMemberPath = "Name";


			//3. Показ списка работников (ObservableCollection <Worker> workers в классе Department), в частности Фамилия, Имя, Возраст, Зарплата  выбранного департамента (Listview). Здесь привязку осуществить не удалось. 
			LVWork.ItemsSource = departments;			
		}

		private void ListDep_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			ComboBox ListDep = (ComboBox)sender;
			Bindr.Text = ListDep.SelectedValue.ToString();

		}
	}
}
