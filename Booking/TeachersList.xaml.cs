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

    public partial class TeachersList : Window
    {
        int id_teacher;
        DB db = new DB();
        public TeachersList( int id_teacher)
        {
            InitializeComponent();
            this.id_teacher = id_teacher;
            UpdateList();
        }
        private void UpdateList()
        {
            listteacher.Items.Clear();

            DataTable table = db.Select("SELECT * FROM [dbo].[teacher]");

            for (int i = 0; i < table.Rows.Count; i++)
            {
                String pos = " ";

                DataRow row = table.Rows[i];

                txtfname.Text = row["fname"].ToString();
                txtsname.Text = row["sname"].ToString();
                txtfathname.Text = row["fathname"].ToString();


                DataTable post_table = db.Select($"select * from teacher_position where id_teacher = {row["id"]}");
                for (int j = 0; j < post_table.Rows.Count; j++)
                {
                    DataRow post_row = post_table.Rows[j];
                    DataTable pos_table = db.Select($"select * from position where id = {post_row["id_position"]}");
                    DataRow pos_row = pos_table.Rows[0];
                    pos += pos_row["name"].ToString() + " ";
                }

                listteacher.Items.Add(new Teacher { Id = (int)row["id"], Fname = row["fname"].ToString(), Sname = row["sname"].ToString(), Fathname = row["fathname"].ToString(), Position = pos });
            }
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            EditLists editLists = new EditLists(id_teacher);
            editLists.Show();
            this.Close();
        }
        private void listteacher_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Teacher fteacher = (Teacher)listteacher.SelectedItem;
            txtposition.Text = "";
            if (fteacher != null)
            {

                DataTable table = db.Select($"SELECT * FROM [dbo].[teacher] WHERE id = {fteacher.Id}");


                if (table.Rows.Count > 0)
                {
                    DataRow row = table.Rows[0];
                    txtfname.Text = row["fname"].ToString();
                    txtsname.Text = row["sname"].ToString();
                    txtfathname.Text = row["fathname"].ToString();


                    DataTable post_table = db.Select($"select * from teacher_position where id_teacher = {row["id"]}");
                    for (int i = 0; i < post_table.Rows.Count; i++)
                    {
                        DataRow post_row = post_table.Rows[i];
                        DataTable pos_table = db.Select($"select * from position where id = {post_row["id_position"]}");
                        DataRow pos_row = pos_table.Rows[0];
                        txtposition.Text += pos_row["name"].ToString() + " ";
                    }

                    
                    txttel.Text = row["tel"].ToString();
                    txtemail.Text = row["email"].ToString();
                    

                    if (row["image"].ToString() != String.Empty)
                    {
                        var uriSource = new Uri($"{row["image"]}");
                        imageteacher.Source = new BitmapImage(uriSource);
                    }
                    else
                    {
                        var uriSource = new Uri("/iconteacher2.png", UriKind.Relative);
                        imageteacher.Source = new BitmapImage(uriSource);
                    }
                }
            }
           
        }

        private void btnaddteacher_Click(object sender, RoutedEventArgs e)
        {
            TeacherEdit addteacher = new TeacherEdit(id_teacher, false);
            addteacher.Show();
            this.Close();
        }

        private void btnchange_Click(object sender, RoutedEventArgs e)
        {
            Teacher fteacher = (Teacher)listteacher.SelectedItem;
            if (fteacher != null)
            {
                TeacherEdit addteacher = new TeacherEdit(id_teacher, true, fteacher.Id);
                addteacher.Show();
                this.Close();
            }
            else
            {
                System.Windows.MessageBox.Show("Вы не выбрали преподавателя!");
            }
            
        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            Teacher fteacher = (Teacher)listteacher.SelectedItem;

            if (fteacher != null)
            {
                string message = $"Вы действительно хотите удалить {fteacher.Fname} {fteacher.Sname} {fteacher.Fathname}?";

                DialogResult resualt = System.Windows.Forms.MessageBox.Show(message, "Выход", MessageBoxButtons.YesNo);
                if (resualt == System.Windows.Forms.DialogResult.Yes)
                {
                    db.Select($"DELETE FROM [dbo].[teacher] WHERE id = {fteacher.Id}");
                    UpdateList();
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Вы не выбрали преподавателя!");
            }

        }
    }
}
