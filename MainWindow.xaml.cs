using Syncfusion.Windows.Controls.Cells;
using Syncfusion.Windows.Controls.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GridControl_Border
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            this.DataContext = new Dictionary<RowColumnIndex, object>();
            InitializeGridControl();
        }

        Random r = new Random();
        private void InitializeGridControl()
        {
            CreateTable();
            grid.Model.RowCount = table.Rows.Count;
            grid.Model.ColumnCount = table.Columns.Count;
            //Event subscription for QueryCellInfo.
            grid.QueryCellInfo += Grid_QueryCellInfo;
        }
        DataTable table = new DataTable();
        string[] name1 = new string[] { "John", "Peter", "Smith", "Jay", "Krish", "Mike" };
        string[] country = new string[] { "UK", "USA", "Pune", "India", "China", "England" };
        string[] city = new string[] { "Graz", "Resende", "Bruxelles", "Aires", "Rio de janeiro", "Campinas" };
        string[] scountry = new string[] { "Brazil", "Belgium", "Austria", "Argentina", "France", "Beiging" };

        DataTable CreateTable()
        {
            table.Columns.Add("Name");
            table.Columns.Add("Id");
            table.Columns.Add("Date");
            table.Columns.Add("Country");
            table.Columns.Add("Ship City");
            table.Columns.Add("Ship Country");
            table.Columns.Add("Freight");
            table.Columns.Add("Postal code");
            table.Columns.Add("Salary");
            table.Columns.Add("PF");
            table.Columns.Add("EMI");

            for (int l = 0; l < 100; l++)
            {
                DataRow dr = table.NewRow();
                dr[0] = name1[r.Next(0, 5)];
                dr[1] = "E" + r.Next(30);
                dr[2] = new DateTime(2012, 5, 23);
                dr[3] = country[r.Next(0, 5)];
                dr[4] = city[r.Next(0, 5)];
                dr[5] = scountry[r.Next(0, 5)];
                dr[6] = "12,789";
                dr[7] = r.Next(10 + (r.Next(600000, 600100)));
                dr[8] = r.Next(14000, 20000);
                dr[9] = r.Next(r.Next(2000, 4000));
                dr[10] = r.Next(300, 1000);

                table.Rows.Add(dr);
            }
            return table;
        }
        private void Grid_QueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
        {
            if (e.Cell.RowIndex > 0 && e.Cell.ColumnIndex > 0)
            {
                //To update data into grid cells.
                e.Style.CellValue = table.Rows[e.Cell.RowIndex - 1][e.Cell.ColumnIndex - 1];
            }
        }
    }
}
