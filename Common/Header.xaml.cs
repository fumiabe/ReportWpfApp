using System.Windows;
using System.Windows.Controls;

namespace Common
{
    /// <summary>
    /// Header.xaml の相互作用ロジック
    /// </summary>
    public partial class Header : UserControl
    {
        public Header()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty title = DependencyProperty.Register("Title", typeof(string), typeof(Header), new FrameworkPropertyMetadata("title"));

        public string Title
        {
            get { return (string)GetValue(title); }
            set { SetValue(title, value); }
        }
    }
}
