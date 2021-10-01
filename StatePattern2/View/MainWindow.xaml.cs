using System;
using System.Media;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using StatePattern2.ViewModel;

namespace StatePattern2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Thickness LeftSide = new Thickness(-39, 0, 0, 0); 
        SolidColorBrush Off = new SolidColorBrush(Color.FromRgb(197, 14, 46));
        public AppViewModel ViewModel { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new AppViewModel();
            ViewModel.Dot = Dot;
            ViewModel.Back = Back;

            this.DataContext = ViewModel;

            Dot.Fill = Off;
            Dot.Margin = LeftSide;
        }
       

        private void pathtextbox_DragEnter(object sender, DragEventArgs e)
        {
            var files = e.Data.GetData(DataFormats.FileDrop, true) as string[];
            pathtextbox.Text = files[0];
            ViewModel.Path = files[0];
           
        }

        




    }
}
