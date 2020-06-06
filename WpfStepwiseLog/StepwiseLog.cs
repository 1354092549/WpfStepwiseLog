using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace QIQI.WpfStepwiseLog
{
    public class StepwiseLog : INotifyPropertyChanged
    {
#pragma warning disable CS0067
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS0067
        public ObservableCollection<SpecificStepLog> Steps { get; set; } = new ObservableCollection<SpecificStepLog>();
    }
}
