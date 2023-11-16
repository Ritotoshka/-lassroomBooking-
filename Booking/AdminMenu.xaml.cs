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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Booking
{

    public partial class AdminMenu : Window
    {
        DB db = new DB();
        int id_teacher;
        public AdminMenu(int id_teacher)
        {
            InitializeComponent();
            this.id_teacher = id_teacher;

            DataTable ttable = db.Select($"SELECT * FROM teacher WHERE id = {id_teacher}");
            DataRow trow = ttable.Rows[0];
            txtnameadmin.Content = trow["fname"].ToString() + " " + trow["sname"].ToString() + " " + trow["fathname"].ToString();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult resualt = System.Windows.Forms.MessageBox.Show("Вы действительно хотите выйти из аккаунта?", "Выход", MessageBoxButtons.YesNo);
            if (resualt == System.Windows.Forms.DialogResult.Yes)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }       
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EditLists editLists = new EditLists(id_teacher);
            editLists.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AdminBookingList abookingList = new AdminBookingList(id_teacher);
            abookingList.Show();
            this.Close();
        }
    }
}
