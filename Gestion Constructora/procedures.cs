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
        public static MySqlConnection conexion = new MySqlConnection("server=localhos; user id=root; database=constructora; password=root");

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
    }
}
