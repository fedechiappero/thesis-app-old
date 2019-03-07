using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestion_Constructora
{
    class procedures
    {
        private static string con = "server=localhost; user id=root; database=constructora; password=root";
        public static MySqlConnection conexion = new MySqlConnection(con);
        public static MySqlConnection conexion2 = new MySqlConnection(con);

        //public static string conexion = "server=localhost; user id=root; database=constructora; password=root";

        public void initilizeForm(Form login, string title, FormStartPosition position, bool resizable)
        {
            login.Text = title;
            login.StartPosition = position;
            if (!resizable)
            {
                login.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }

        public void initializeGrid(DataGridView grid)
        {
            grid.Rows.Clear();
            //grid.Refresh();
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ReadOnly = true;
            grid.MultiSelect = false;
            grid.ScrollBars = ScrollBars.Vertical;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public static string dateToMySQL(DateTimePicker dtp)
        {
            return Convert.ToString(dtp.Value.Year) + "-" + Convert.ToString(dtp.Value.Month) + "-" + Convert.ToString(dtp.Value.Day);
        }
    }
}
