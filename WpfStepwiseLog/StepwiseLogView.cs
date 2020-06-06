using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QIQI.WpfStepwiseLog
{
    public class StepwiseLogView : Control
    {
        public DataTemplate ItemTemplate
        {
            get { return (DataTemplate)GetValue(ItemTemplateProperty); }
            set { SetValue(ItemTemplateProperty, value); }
        }

        public static readonly DependencyProperty ItemTemplateProperty =
            DependencyProperty.Register("ItemTemplate", typeof(DataTemplate), typeof(StepwiseLogView), new PropertyMetadata(null));


        public StepwiseLog DataSource
        {
            get { return (StepwiseLog)GetValue(DataSourceProperty); }
            set { SetValue(DataSourceProperty, value); }
        }

        public static readonly DependencyProperty DataSourceProperty =
            DependencyProperty.Register("DataSource", typeof(StepwiseLog), typeof(StepwiseLogView), new PropertyMetadata(null));

        static StepwiseLogView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StepwiseLogView), new FrameworkPropertyMetadata(typeof(StepwiseLogView)));
        }


    }
}
