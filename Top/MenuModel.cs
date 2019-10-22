using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Top
{
    public class MenuModel
    {
        // データテーブル
        public DataTable _consuptionTable = new DataTable();

        public MenuModel(List<FuelData> fuelDatas)
        {

            _consuptionTable.Columns.Add(new DataColumn("Use", typeof(string)));

            // 燃料一覧を取得
            IEnumerable<string> fuels = fuelDatas.Select(fuelData => fuelData.FuelName).Distinct();
            foreach(string val in fuels)
            {
                _consuptionTable.Columns.Add(new DataColumn(val, typeof(double)));
            }

            // 用途ごとの行を作成
            IEnumerable<string> uses = fuelDatas.Select(fuelData => fuelData.Use).Distinct();
            foreach (string val in uses)
            {
                DataRow newRowItem = _consuptionTable.NewRow();

                IEnumerable<FuelData> datas = fuelDatas.Where(fuelData => fuelData.Use == val);

                newRowItem["Use"] = val;
                foreach (FuelData data in datas)
                {
                    newRowItem[data.FuelName] = data.FuelValue;
                }
                _consuptionTable.Rows.Add(newRowItem);

            }

        }

    }
}
