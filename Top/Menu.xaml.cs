using Microsoft.Windows.Controls;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace Top
{
    /// <summary>
    /// Menu.xaml の相互作用ロジック
    /// </summary>
    public partial class Menu : Page
    {

        private List<Fuel> Fuels = new List<Fuel>() {
            new Fuel { FuelName = "AAA", FuelUnit = "MT" },
            new Fuel { FuelName = "BBB", FuelUnit = "MT" },
            new Fuel { FuelName = "CCC", FuelUnit = "MT" }};

        private List<string> Uses = new List<string>() { "MAIN ENGINE", "BOILER", "OTHER" };

        List<FuelData> fuelDatas = new List<FuelData>();


        public Menu()
        {
            InitializeComponent();

            fuelDatas.Add(new FuelData { Use = "MAIN ENGINE", FuelName = "AAA", FuelValue = 100.1 });
            fuelDatas.Add(new FuelData { Use = "MAIN ENGINE", FuelName = "BBB", FuelValue = 100.2 });
            fuelDatas.Add(new FuelData { Use = "MAIN ENGINE", FuelName = "CCC", FuelValue = 100.3 });

            fuelDatas.Add(new FuelData { Use = "BOILER", FuelName = "AAA", FuelValue = 200.1 });
            fuelDatas.Add(new FuelData { Use = "BOILER", FuelName = "CCC", FuelValue = 200.3 });


            try
            {
                InitTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Title, MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var model = new MenuModel(fuelDatas);
            FuellDataGrid.DataContext = model._consuptionTable;

            //this.DataContext = model;

        }

        // メンバ関数
        /// <summary>
        /// テーブルの初期化
        /// </summary>
        private void InitTables()
        {
            //// 水平スクロールバー
            //FuellDataGrid.HorizontalScrollBarVisibility = ScrollBarVisibility.Visible;
            //// 垂直スクロールバー
            //FuellDataGrid.VerticalScrollBarVisibility = ScrollBarVisibility.Visible;

            // 用途カラムを追加
            FuellDataGrid.Columns.Add(new DataGridTextColumn()
            {
                Header = " ",
                IsReadOnly = false,
                FontSize = 12,
                Binding = new Binding("Use")
            });

            // 燃料カラムを追加
            foreach (Fuel fuel in Fuels)
            {
                FuellDataGrid.Columns.Add(new DataGridTextColumn() {
                    Header = string.Format("{0} ({1})", fuel.FuelName, fuel.FuelUnit),
                    IsReadOnly = false,
                    FontSize = 12,
                    Width = 100,
                    Binding = new Binding(fuel.FuelName) });

                // 集計行を追加
                TextBlock tb = new TextBlock() {
                    Width = 100,
                    Text = "total"

                };
                TotalRow.Children.Add(tb);


            }





            //FuellDataGrid.Columns.Add(new DataGridTextColumn() { Header = "test_id", IsReadOnly = false, FontSize = 12, Binding = new Binding("test_id") });
            //FuellDataGrid.Columns.Add(new DataGridTextColumn() { Header = "test_string", IsReadOnly = false, FontSize = 12, Binding = new Binding("test_string") });

            //m_dt = new DataTable("DataGridTest");

            //m_dt.Columns.Add(new DataColumn("test_id", typeof(int)));// 数値
            //m_dt.Columns.Add(new DataColumn("test_string", typeof(string)));// 文字列

            //// サンプルデータ追加
            //DataRow newRowItem;
            //for (int i = 0; i < 100; i++)
            //{
            //    newRowItem = m_dt.NewRow();
            //    newRowItem["test_string"] = "test" + i.ToString();
            //    newRowItem["test_id"] = i.ToString();
            //    m_dt.Rows.Add(newRowItem);
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var navigationWindow = (NavigationWindow)Application.Current.MainWindow;
            var uri = new Uri("/Report1;component/Form.xaml", UriKind.Relative);
            navigationWindow.Navigate(uri);
        }

        private void getPage(string uriStr)
        {
            var navigationWindow = (NavigationWindow)Application.Current.MainWindow;
            var uri = new Uri(uriStr, UriKind.Relative);
            navigationWindow.Navigate(uri);
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            getPage("/Report1;component/ReportEntryPage.xaml");
        }
    }
}
