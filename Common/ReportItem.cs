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
    /// レポート項目
    /// </summary>
    public class ReportItem : Control
    {
        /// <summary>
        ///  項目名
        /// </summary>
        public static readonly DependencyProperty ItemNameProperty = 
            DependencyProperty.Register("ItemName", 
                typeof(string), typeof(ReportItem), 
                new FrameworkPropertyMetadata("item"));
        /// <summary>
        ///  項目見出し
        /// </summary>
        public static readonly DependencyProperty ItemTitleProperty =
            DependencyProperty.Register("ItemTitle",
                typeof(string), typeof(ReportItem),
                new FrameworkPropertyMetadata("label"));
        /// <summary>
        /// 項目種別
        /// </summary>
        public static readonly DependencyProperty ItemDataTypeProperty =
            DependencyProperty.Register("ItemDataType",
                typeof(DataType), typeof(ReportItem),
                new FrameworkPropertyMetadata(DataType.TextBox));
        /// <summary>
        /// 入力欄の幅
        /// </summary>
        public static readonly DependencyProperty FieldWidthProperty =
            DependencyProperty.Register("FieldWidth",
                typeof(double), typeof(ReportItem),
                new FrameworkPropertyMetadata(100.0));
        /// <summary>
        /// 入力値
        /// </summary>
        public static readonly DependencyProperty FieldValueProperty =
            DependencyProperty.Register("FieldValue",
                typeof(string), typeof(ReportItem),
                new FrameworkPropertyMetadata(string.Empty));
        /// <summary>
        /// 最大桁数
        /// </summary>
        public static readonly DependencyProperty MaxLengthProperty =
            DependencyProperty.Register("MaxLength",
                typeof(int), typeof(ReportItem),
                new FrameworkPropertyMetadata(100));

        public string ItemName
        {
            get { return (string)GetValue(ItemNameProperty); }
            set { SetValue(ItemNameProperty, value); }
        }
        public string ItemTitle
        {
            get { return (string)GetValue(ItemTitleProperty); }
            set { SetValue(ItemTitleProperty, value); }
        }
        public DataType ItemDataType
        {
            get { return (DataType)GetValue(ItemDataTypeProperty); }
            set { SetValue(ItemDataTypeProperty, value); }
        }
        public double FieldWidth
        {
            get { return (double)GetValue(FieldWidthProperty); }
            set { SetValue(FieldWidthProperty, value); }
        }
        public string FieldValue
        {
            get { return (string)GetValue(FieldValueProperty); }
            set { SetValue(FieldValueProperty, value); }
        }
        public int MaxLength
        {
            get { return (int)GetValue(MaxLengthProperty); }
            set { SetValue(MaxLengthProperty, value); }
        }

        /// <summary>
        /// 項目種別
        /// </summary>
        public enum DataType
        {
            TextBox,
            NumberBox,
            TextArea,
            Date,
            Time,
            Position
        }


        static ReportItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ReportItem), new FrameworkPropertyMetadata(typeof(ReportItem)));
        }

        //private static void ValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        //{
        //    ((object)d).UpdateState(true);
        //}


    }
}
