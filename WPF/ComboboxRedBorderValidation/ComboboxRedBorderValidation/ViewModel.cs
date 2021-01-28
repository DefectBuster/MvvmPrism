using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ComboboxRedBorderValidation
{
    public class ViewModel : ViewModelBase
    {
        public ViewModel()
        {
            MyClassCollection = new ObservableCollection<MyClass>() {
                new MyClass() { Name="Peter",FullName="John"} ,
                new MyClass() { Name="Steve",FullName="Jobs"} ,
                new MyClass() { Name="Sam",FullName="Enclave"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Vincent",FullName="John"}
            };
            SelectedASPTemplates = new ObservableCollection<MyClass>();

            AddCommand = new DelegateCommand((param) => AddNewItem(), (param) => CanAdd());
            InitCommand = new DelegateCommand((param) =>
            {
                MyClassCollection = new ObservableCollection<MyClass>() {
                new MyClass() { Name="Peter",FullName="John"} ,
                new MyClass() { Name="Steve",FullName="Jobs"} ,
                new MyClass() { Name="Sam",FullName="Enclave"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Tom",FullName="Cruise"} ,
                new MyClass() { Name="Vincent",FullName="John"}
            };

            }, (param) =>
             {
                 return true;

             });
        }

        private bool CanAdd()
        {
            return true;
        }

        private void AddNewItem()
        {

        }

        private MyClass enteredNewItem;

        public MyClass EnteredNewItem
        {
            get { return enteredNewItem; }
            set { enteredNewItem = value; this.OnPropertyChanged(); }
        }

        private string toolTipText;

        public string ToolTipText
        {
            get { return toolTipText; }
            set { toolTipText = value; this.OnPropertyChanged(); }
        }



        private MyClass newClass = new MyClass();

        public MyClass NewClass
        {
            get { return newClass; }
            set
            {
                newClass = value;

                this.OnPropertyChanged();
            }
        }



        private ObservableCollection<MyClass> myClassCollection;

        public ObservableCollection<MyClass> MyClassCollection
        {
            get { return myClassCollection; }
            set { myClassCollection = value; this.OnPropertyChanged(); }
        }

        private MyClass selectedASPTemplate;

        public MyClass SelctedASPTemplate
        {
            get { return selectedASPTemplate; }
            set
            {
                selectedASPTemplate = value;
                this.OnPropertyChanged();
                throw new Exception("There's something wrong");
            }
        }


        private ObservableCollection<MyClass> selectedASPTemplates;

        public ObservableCollection<MyClass> SelectedASPTemplates
        {
            get { return selectedASPTemplates; }
            set
            {
                selectedASPTemplates = value;

                if (value.Count() > 2)
                {
                    throw new Exception("There's something wrong");
                }
                this.OnPropertyChanged();
            }

        }

        public ICommand AddCommand { get; set; }
        public ICommand InitCommand { get; set; }

        private MyClass selectedItem;

        public MyClass SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value; this.OnPropertyChanged(); }
        }
    }
}
