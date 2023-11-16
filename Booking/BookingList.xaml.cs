using MySql.Data.MySqlClient;
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
    public partial class BookingList : Window
    {
        DB db = new DB();
        int id_teacher;
        public BookingList(int id_teacher)
        {
            InitializeComponent();    

            this.id_teacher = id_teacher;
            UpdateList();
        }
        private void UpdateList()
        {
            listbooking.Items.Clear();
            
            DataTable ttable = db.Select($"SELECT * FROM teacher WHERE id = {id_teacher}");
            DataRow trow = ttable.Rows[0];
            txtnameteacher.Content = trow["fname"].ToString() + " " + trow["sname"].ToString() + " " + trow["fathname"].ToString();

            DataTable table = db.Select($"SELECT * FROM booking WHERE id_teacher = {id_teacher} ORDER BY date_booking DESC, time_start, time_end, id_audience");

                   
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];

                DataTable table2 = db.Select($"SELECT * FROM audience WHERE id = {row["id_audience"]}");

                if (table2.Rows.Count > 0)
                {
                    DataRow row2 = table2.Rows[0];
                    DateTime date = (DateTime)row["date_booking"];
                    listbooking.Items.Add(new Abooking { Id = (int)row["id"], Date_booking = date.ToShortDateString(), Audience = row2["number"].ToString(), Time_start = row["time_start"].ToString(), Time_end = row["time_end"].ToString() });
                }                 
            }
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.DialogResult resualt = System.Windows.Forms.MessageBox.Show("Вы действительно хотите выйти из аккаунта?", "Выход", MessageBoxButtons.YesNo);
            if (resualt == System.Windows.Forms.DialogResult.Yes)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
        }

        private void btnaddteacher_Click(object sender, RoutedEventArgs e)
        {
            BookingEdit bookingEdit = new BookingEdit(id_teacher);
            bookingEdit.Show();
            this.Close();
        }


        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            Abooking fbooking = (Abooking)listbooking.SelectedItem;

            if (fbooking != null)
            {
                string message = $"Вы действительно хотите удалить бронь на {fbooking.Date_booking}?";

                DialogResult resualt = System.Windows.Forms.MessageBox.Show(message, "Удаление", MessageBoxButtons.YesNo);
                if (resualt == System.Windows.Forms.DialogResult.Yes)
                {
                    db.Select($"DELETE FROM booking WHERE id = {fbooking.Id}");
                    UpdateList();
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Вы не выбрали бронь!");
            }
        }

        private void listbooking_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Abooking fbooking = (Abooking)listbooking.SelectedItem;
            if (fbooking != null)
            {

                DataTable table = db.Select($"SELECT * FROM booking WHERE id = {fbooking.Id}");

                if (table.Rows.Count > 0)
                {
                    DataRow booking_row = table.Rows[0];
                    
                    DataTable table2 = db.Select($"SELECT * FROM audience WHERE id = {booking_row["id_audience"]}");

                    DataRow row2 = table2.Rows[0];

                    DataTable ftable = db.Select($"select number from floor where id = {row2["id_floor"]}");
                    DataRow frow = ftable.Rows[0];

                    txtnumber.Text = row2["number"].ToString();
                    txtfloor.Text = frow["number"].ToString();

                    DateTime date = (DateTime)booking_row["date_booking"];
                    txtdate.Text = date.ToShortDateString();
                    txttime.Text = booking_row["time_start"].ToString() + " - " + booking_row["time_end"].ToString();

                    DataTable lesson_table = db.Select($"select * from lesson where id = {booking_row["id_lesson"]}");
                    DataRow lesson_row = lesson_table.Rows[0];

                    txtlesson.Text = lesson_row["name"].ToString();

                    DataTable lessontype_table = db.Select($"select * from lessontype where id = {booking_row["id_lessontype"]}");
                    DataRow lessontype_row = lessontype_table.Rows[0];

                    txtlessontype.Text = lessontype_row["name"].ToString();
                }
            }
        }
    }
}
