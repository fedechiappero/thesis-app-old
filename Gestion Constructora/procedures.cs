using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace Gestion_Constructora
{
    class procedures
    {
        private static string con = "server=localhost; user id=root; database=constructora; password=root";
        public static MySqlConnection conexion = new MySqlConnection(con);
        public static MySqlConnection conexion2 = new MySqlConnection(con);

        public static CultureInfo culture = new CultureInfo("en-US");

        public void inicializarFormulario(Form frm, string titulo, FormStartPosition posicion, bool redimensionable)
        {
            frm.Text = titulo;
            frm.StartPosition = posicion; 
            if (!redimensionable)
            {
                frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
            //this property prevent user click on button to detach form from full screen
            //but not when title bar is double clicked, and the window cover the taskbar (kinda ugly)
            //frm.MaximizeBox = false;
        }

        public void inicializarGrid(DataGridView grid)
        {
            grid.Rows.Clear();
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

        public static string stringToCurrencyMySQL(string importe)
        {
            decimal valor = decimal.Parse(importe, NumberStyles.Currency, culture);
            return Convert.ToString(valor, culture);
        }

        public static string stringToCurrencyTextbox(string importe)
        {
            decimal valor = Convert.ToDecimal(importe, culture);
            return valor.ToString("C", culture);
        }
    }
}
