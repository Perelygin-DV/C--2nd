using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace base_of_data
{
	class Department: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		string name;
		        public string Name
        {
            get => this.name;
            set
            {
                this.name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Name)));

            }
        }

		public ObservableCollection<Worker> workers { get; set; } = new ObservableCollection<Worker>();

	}
}
