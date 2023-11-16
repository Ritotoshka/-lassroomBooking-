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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Booking
{

    public partial class BookingEdit : Window
    {
        DB db = new DB();

        public bool p;
        public int id;
        DateTime currentDay = DateTime.Now;

        int id_teacher;

        int check;

        Dictionary<int, CheckBox> dictionary_inventorys = new Dictionary<int, CheckBox>();
        public BookingEdit(int id_teacher)
        {
            InitializeComponent();

            datepicker.SelectedDate = currentDay;
            this.id_teacher = id_teacher;

            DataTable ttable = db.Select($"SELECT * FROM teacher WHERE id = {id_teacher}");
            DataRow trow = ttable.Rows[0];
            txtnameteacher.Content = trow["fname"].ToString() + " " + trow["sname"].ToString() + " " + trow["fathname"].ToString();


            DataTable inventory_table = db.Select($"SELECT * FROM inventory");

            if (inventory_table.Rows.Count > 0)
            {

                for (int i = 0; i < inventory_table.Rows.Count; i++)
                {
                    DataRow inventory_row = inventory_table.Rows[i];
                    CheckBox checkBoxe = new CheckBox();
                    checkBoxe.Name = "inventory_" + inventory_row["id"];
                    checkBoxe.Content = inventory_row["name"].ToString();
                    if (inventory_row["description"].ToString() != "")
                    {
                        checkBoxe.Content += $"({inventory_row["description"].ToString()})";
                    }
                    checkBoxe.FontWeight = FontWeights.Normal;
                    stackpanel_inventory.Children.Add(checkBoxe);

                    dictionary_inventorys.Add((int)inventory_row["id"], checkBoxe);
                }

            }

        }

        private void btnaddEdit_Click(object sender, RoutedEventArgs e)
        {
            DataRow audience_row = db.Select($"select id from audience where number = '{txtlistaudience.SelectedItem}'").Rows[0];
            DataRow lessontype_row = db.Select($"select id from lessontype where name = '{list_lessontype.SelectedItem}'").Rows[0];
            DataRow lesson_row = db.Select($"select id from lesson where name = '{list_lesson.SelectedItem}'").Rows[0];

            int id_audience = (int) audience_row["id"];
            int id_lessontype = (int)lessontype_row["id"]; ;
            int id_lesson = (int)lesson_row["id"]; 

            DateTime? date_booking = datepicker.SelectedDate;

            int hour_start = combohour_start.SelectedIndex;
            int min_start = combomin_start.SelectedIndex;
            int hour_end = combohour_end.SelectedIndex;
            int min_end = combomin_end.SelectedIndex;

            DateTime date = new DateTime(2000, 1, 1, 0, 0, 0);

            DateTime time_start = date.AddHours(hour_start).AddMinutes(min_start);
            DateTime time_end = date.AddHours(hour_end).AddMinutes(min_end);

            //вместо автоинкремента
            int id_booking;
            DataTable table = db.Select($"select id from booking ORDER BY id DESC");
            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                id_booking = Convert.ToInt32(row["id"]) + 1;
            }
            else id_booking = 1;

            bool check = true;


            if (check)
            {
                try
                {
                    db.Select($"insert into booking values ({id_booking}, {id_audience}, {id_teacher}, {id_lessontype}, {id_lesson}, '{date_booking}', '{time_start}', '{time_end}')");

                    System.Windows.MessageBox.Show("Бронирование добавлено!");
                    BookingList bookingList = new BookingList(id_teacher);
                    bookingList.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show("Бронирование не добавлено!" + ex);
                    throw;
                }

            }
        }

        private void txtaddnumberaudience_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DataTable audience_table = db.Select($"select * from audience");

            txtlistaudience.Items.Clear();

            int count_checked = 0;

            foreach (int id_inventory in dictionary_inventorys.Keys)
            {
                if (dictionary_inventorys[id_inventory].IsChecked == true)
                {
                    count_checked++;
                }
            }

            if (count_checked == 0)
            {
                for (int i = 0; i < audience_table.Rows.Count; i++)
                {
                    DataRow audience_row = audience_table.Rows[i];
                    txtlistaudience.Items.Add(audience_row["number"].ToString());
                }
            }

            int count_satisfy = count_checked;

            foreach (DataRow audience_row in audience_table.Rows)
            {
                foreach (int id_inventory in dictionary_inventorys.Keys)
                {
                    if (dictionary_inventorys[id_inventory].IsChecked == true)
                    {
                        DataTable suitable_audiences_table = db.Select($"select * from inventory_audience where id_audience = {audience_row["id"]} and id_inventory = {id_inventory}");
                        if (suitable_audiences_table.Rows.Count != 0)
                        {
                            count_satisfy--;
                        }

                    }
                }
                if (count_satisfy == 0)
                {
                    txtlistaudience.Items.Add(audience_row["number"].ToString());
                    count_satisfy = count_checked;
                }
                else
                {
                    count_satisfy = count_checked;
                }
            }

        }

        private void txtaddnumberaudience_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (txtlistaudience.SelectedItem == null)
            {
                btnaddEdit.IsEnabled = false;
            }
            else
            {
                btnaddEdit.IsEnabled = true;
            }
        }

        private void Button_back_Click(object sender, RoutedEventArgs e)
        {
            
            BookingList bookingsList = new BookingList(id_teacher);
            bookingsList.Show();
            this.Close();
        }

        private void list_lessontype_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DataTable lessontype_table = db.Select($"select * from lessontype order by name;");

            list_lessontype.Items.Clear();

            if (lessontype_table.Rows.Count != 0)
            {
                foreach (DataRow lessontype_row in lessontype_table.Rows)
                {
                    list_lessontype.Items.Add(lessontype_row["name"].ToString());
                }
            }
        }

        private void list_lesson_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DataTable lesson_table = new DataTable();
            if (chkbox_alllesson.IsChecked == true)
            {
                lesson_table = db.Select($"select * from lesson order by name;");

            }
            else
            {
                lesson_table = db.Select($"select * from lesson where id in (select id_lesson from teacher_lesson where id_teacher = {id_teacher});");
            }
            list_lesson.Items.Clear();

            if (lesson_table.Rows.Count != 0)
            {
                foreach (DataRow lesson_row in lesson_table.Rows)
                {
                    list_lesson.Items.Add(lesson_row["name"].ToString());
                }

            }
        }
    }
}
