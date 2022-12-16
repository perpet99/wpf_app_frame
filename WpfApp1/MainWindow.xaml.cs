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
using WpfApp1.Views;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            button1_click(null, null);
        }

        void ChangeBtnColor(Button btn, Brush brush)
        {
            button1_btn.Background = Brushes.Gray;
            button2_btn.Background = Brushes.Gray;
            button3_btn.Background = Brushes.Gray;
           
            btn.Background = brush;
        }

        private void button1_click(object sender, RoutedEventArgs e)
        {
            ChangeView(new button1view());
            ChangeBtnColor(button1_btn, Brushes.Blue);
        }

        private void button2_click(object sender, RoutedEventArgs e)
        {
            ChangeView(new button2view());
            ChangeBtnColor(button2_btn, Brushes.Blue);
        }
        private void button3_click(object sender, RoutedEventArgs e)
        {
            ChangeView(new button2view());
            ChangeBtnColor(button3_btn, Brushes.Blue); ;
        }
        void ChangeView(UIElement view)
        {
            if (centerPanel.Children.Count == 0)
            {
                centerPanel.Children.Add(view);
                return;
            }

            if (centerPanel.Children[0] != view)
            {
                centerPanel.Children.Clear();
                centerPanel.Children.Add(view);
            }
        }

    }
}
