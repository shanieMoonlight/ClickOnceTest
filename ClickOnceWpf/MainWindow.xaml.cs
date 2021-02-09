using ClickOnceHelper;
using System.Windows;

namespace ClickOnceWpf
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      public MainWindow()
      {
         InitializeComponent();
         HelperClass.DoSomething(7);
      }
   }
}
