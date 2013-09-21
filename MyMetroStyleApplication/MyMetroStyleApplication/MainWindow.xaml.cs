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
using MetroStyleControls;
using CommonControls;

namespace MyMetroStyleApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();            
            //CommonControls.WatermarkTextBox wtb = new WatermarkTextBox();            
            //wtb.Watermark = "type here";
            //(LogicalTreeHelper.GetChildren(this).Cast<DockPanel>().First() as DockPanel).Children.Add(wtb);
            //this.AddChild(new Login());
        }
    }
}
