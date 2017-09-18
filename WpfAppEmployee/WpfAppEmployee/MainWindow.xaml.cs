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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppEmployee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        private void ViewInfoButton_Click(object sender, RoutedEventArgs e)
        {
            switch (ListEmployee.SelectedIndex)
            {
                case 0:
                    
                  
                    infoLabel.Content = "Jenifer Emplloyee ID: 0001";
                    break;
                case 1:
                    
                    infoLabel.Content = "Ali Emplloyee ID: 0002";
                    break;
                case 2:
                    
                    infoLabel.Content = "Alex Emplloyee ID: 0003";
                    break;
                case 3:
                    
                    infoLabel.Content = "Jack Emplloyee ID: 0004";
                    break;
                case 4:
                    
                    infoLabel.Content = "Hana Emplloyee ID: 0005";
                    break;
                default:
                    
                    infoLabel.Content = "";
                    break;


            }
        }

    }
}

