using Autodesk.Revit.UI;
using System.Windows;

namespace RevitAPISheetAndViews
{
    public partial class MainView : Window
    {
        public MainView(ExternalCommandData commandData)
        {
            InitializeComponent();
            MainViewViewModel vm = new MainViewViewModel(commandData);
            vm.CloseRequest += (s, e) => this.Close();
            DataContext = vm;
        }
    }
}
