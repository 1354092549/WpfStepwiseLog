using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Documents;

namespace QIQI.WpfStepwiseLog
{
    public enum StepState
    {
        Processing,
        Success,
        Failed
    }
    public class SpecificStepLog : INotifyPropertyChanged
    {
#pragma warning disable CS0067
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS0067
        public StepState State { get; set; }
        public string Description { get; set; }
        public object Content { get; set; }
    }
}
