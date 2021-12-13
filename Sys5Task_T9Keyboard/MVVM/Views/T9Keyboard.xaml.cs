using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using Sys5Task_T9Keyboard.MVVM.ViewModels;

namespace Sys5Task_T9Keyboard.MVVM.Views
{
    /// <summary>
    /// Interaction logic for T9Keyboard.xaml
    /// </summary>
    public partial class T9Keyboard : Window
    {
        public T9Keyboard()
        {
            InitializeComponent();

            var vm = new ViewModel() {T9Keyboard = this};
            this.DataContext = vm;
        }
    }
}
