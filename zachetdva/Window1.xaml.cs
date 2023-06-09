using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace zachetdva
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {

            Popup popup = new Popup();
            popup.Placement = PlacementMode.Relative;
            popup.PlacementTarget = sender as UIElement;
            popup.AllowsTransparency = true;
            popup.PopupAnimation = PopupAnimation.Fade;


            StackPanel panel = new StackPanel();
            panel.Background = new SolidColorBrush(Colors.White);


            panel.Children.Add(new TextBlock() { Text = "Markel" });
            panel.Children.Add(new TextBlock() { Text = "18" });
            panel.Children.Add(new TextBlock() { Text = "KAI" });


            popup.Child = panel;


            popup.IsOpen = true;
        }
    }
}
