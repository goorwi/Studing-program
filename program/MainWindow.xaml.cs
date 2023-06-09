using System;
using System.Collections.Generic;
using System.IO;
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

namespace program
{
    public enum tabPanel
    {
        start,
        test,
        unit,
        integration,
        prepare,
        unitTesting,
        integrTesting,
        task,
        end
    };
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FileReader frStart = new FileReader(txtIntro, tabPanel.start);
            FileReader frTesting = new FileReader(txtTesting, tabPanel.test);
            FileReader frUnit = new FileReader(txtUnit, tabPanel.unit);
            FileReader frIntegraion = new FileReader(txtIntegration, tabPanel.integration);
            FileReader frPrepare = new FileReader(txtPrepare, tabPanel.prepare);
            FileReader frUnitTesting = new FileReader(txtUnitTesting, tabPanel.unitTesting);
            FileReader frIntegrTesting = new FileReader(txtIntegrTesting, tabPanel.integrTesting);
            FileReader frTask = new FileReader(txtTask, tabPanel.task);
            FileReader frEnd = new FileReader(txtEnd, tabPanel.end);
        }
    }
}
