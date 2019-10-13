using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public class ReportItemField : Control
    {

        /// <summary>
        /// 入力欄の幅
        /// </summary>
        public static readonly DependencyProperty WidthProperty =
            DependencyProperty.Register("Width",
                typeof(double), typeof(ReportItemField),
                new FrameworkPropertyMetadata(100.0));
        /// <summary>
        /// 入力値
        /// </summary>
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value",
                typeof(string), typeof(ReportItemField),
                new FrameworkPropertyMetadata(string.Empty));
        /// <summary>
        /// 最大桁数
        /// </summary>
        public static readonly DependencyProperty MaxLengthProperty =
            DependencyProperty.Register("MaxLength",
                typeof(int), typeof(ReportItemField),
                new FrameworkPropertyMetadata(100));

        public double Width
        {
            get { return (double)GetValue(WidthProperty); }
            set { SetValue(WidthProperty, value); }
        }
        public string Value
        {
            get { return (string)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }
        public int MaxLength
        {
            get { return (int)GetValue(MaxLengthProperty); }
            set { SetValue(MaxLengthProperty, value); }
        }

        static ReportItemField()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ReportItemField), new FrameworkPropertyMetadata(typeof(ReportItemField)));
        }

        public void NumberBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // 0-9のみ
            e.Handled = !new Regex("[0-9]").IsMatch(e.Text);
        }
        public void NumberBox_PreviewExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            string text = Clipboard.GetText();

            int result = 0;
            if (int.TryParse(text, out result))
            {
                textbox.Paste();
            }
            else
            {
            }
        }
    }
}
