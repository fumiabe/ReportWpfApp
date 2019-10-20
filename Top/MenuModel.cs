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
        public DataTable ConsuptionTable = new DataTable("Consuption");

        public MenuModel(List<FuelData> fuelDatas)
        {

            ConsuptionTable.Columns.Add(new DataColumn("Use", typeof(string)));

            IEnumerable<string> fuels = fuelDatas.Select(x => x.FuelName);

            foreach(string val in fuels)
            {
                ConsuptionTable.Columns.Add(new DataColumn(val, typeof(int)));
            }

            // サンプルデータ追加
            DataRow newRowItem;
            foreach (FuelData data in fuelDatas)
            {
                newRowItem = ConsuptionTable.NewRow();
                newRowItem["Use"] = data.Use;

                newRowItem["test_id"] = "";
                ConsuptionTable.Rows.Add(newRowItem);
            }


        }

    }
}
