using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Common
{
    /// <summary>
    /// UserControl1.xaml の相互作用ロジック
    /// </summary>
    public partial class ReportItem : UserControl
    {
        public ReportItem()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty labelContent = DependencyProperty.Register("LabelContent", typeof(string), typeof(ReportItem), new FrameworkPropertyMetadata("label"));
        public static readonly DependencyProperty textContent = DependencyProperty.Register("TextContent", typeof(string), typeof(ReportItem), new FrameworkPropertyMetadata("content"));
        public static readonly DependencyProperty textBoxWidth = DependencyProperty.Register("TextBoxWidth", typeof(string), typeof(ReportItem), new FrameworkPropertyMetadata("100"));

        public string LabelContent
        {
            get { return (string)GetValue(labelContent); }
            set { SetValue(labelContent, value); }
        }

        public string TextContent
        {
            get { return (string)GetValue(textContent); }
            set { SetValue(textContent, value); }
        }

        public string TextBoxWidth
        {
            get { return (string)GetValue(textBoxWidth); }
            set { SetValue(textBoxWidth, value); }
        }
    }
}
