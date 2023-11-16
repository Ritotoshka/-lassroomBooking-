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

    public partial class EditLists : Window
    {
        DB db = new DB();
        int id_teacher;
        public EditLists(int id_teacher)
        {
            InitializeComponent();
            this.id_teacher = id_teacher;
            DataTable ttable = db.Select($"SELECT * FROM teacher WHERE id = {id_teacher}");
            DataRow trow = ttable.Rows[0];
            txtnameadmin.Content = trow["fname"].ToString() + " " + trow["sname"].ToString() + " " + trow["fathname"].ToString();
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu(id_teacher);
            adminMenu.Show();
            this.Close();
        }

        private void btn_teachers_Click(object sender, RoutedEventArgs e)
        {
            TeachersList teachersList = new TeachersList(id_teacher);
            teachersList.Show();
            this.Close();
        }

        private void btn_audience_Click(object sender, RoutedEventArgs e)
        {
            AudienceList audienceList = new AudienceList(id_teacher);
            audienceList.Show();
            this.Close();
        }
    }
}
