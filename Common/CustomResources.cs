using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Common
{
    public partial class CustomResources : ResourceDictionary
    {
        /// <summary>
        /// 数値のみ入力
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void NumberBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // 0-9のみ
            e.Handled = !new Regex("[0-9]").IsMatch(e.Text);
        }
        /// <summary>
        /// ペーストを許可しない
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void NumberBox_PreviewExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            //TextBox textbox = (TextBox)sender;
            //string text = Clipboard.GetText();

            //int result = 0;
            //if (int.TryParse(text, out result))
            //{
            //    textbox.Paste();
            //}
            //else
            //{
            //}

            if (e.Command == ApplicationCommands.Paste)
            {
                e.Handled = true;
            }
        }

        
    }
}