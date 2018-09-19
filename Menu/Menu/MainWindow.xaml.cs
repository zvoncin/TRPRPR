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

namespace Menu
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            //////
            // Создание привязки
            CommandBinding bind = new CommandBinding(ApplicationCommands.New);

            // Присоединение обработчика событий
            bind.Executed += NewCommand_Executed;

            // Регистрация привязки
            this.CommandBindings.Add(bind);
            //////

            KeyGesture CloseCmdKeyGesture = new KeyGesture(
    Key.L, ModifierKeys.Alt);

            KeyBinding CloseKeyBinding = new KeyBinding(
                ApplicationCommands.Close, CloseCmdKeyGesture);

            this.InputBindings.Add(CloseKeyBinding);
        }

        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Команда запущена из " + e.Source.ToString());
        }


        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
