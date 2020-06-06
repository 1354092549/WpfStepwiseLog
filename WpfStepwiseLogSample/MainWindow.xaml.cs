using QIQI.WpfStepwiseLog;
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

namespace WpfStepwiseLogSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var log = new StepwiseLog();
            MyLogView.DataSource = log;
            for (int i = 0; i < 5; i++)
            {
                var step = new SpecificStepLog
                {
                    Description = $"Step {i} >> Sample",
                    Content = "Current runner version: '1'"
                };
                log.Steps.Add(step);
            }
            log.Steps[3].State = StepState.Success;
            log.Steps[4].State = StepState.Failed;
        }
    }
}
