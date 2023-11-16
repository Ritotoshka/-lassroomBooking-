using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
    
    public partial class TeacherEdit : Window
    {
        int id_teacher;
        public bool p;
        public int id;
        DB db = new DB();
        public TeacherEdit(int id_teacher, bool p)
        {
            InitializeComponent();
            this.id_teacher = id_teacher;
            this.p = p;
            if (!p)
            {
                btnaddEdit.Content = "Добавить";
            }
            if (p)
            {
                btnaddEdit.Content = "Сохранить";
            }
        }

        public TeacherEdit(int id_teacher, bool p, int id) : this(id_teacher, p)
        {
            InitializeComponent();
            this.id = id;
                                
            DataTable table = db.Select($"SELECT * FROM teacher WHERE id = {this.id}");
            
            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                txtaddfname.Text = row["fname"].ToString();
                txtaddsname.Text = row["sname"].ToString();
                txtaddfathname.Text = row["fathname"].ToString();

                DataTable post_table = db.Select($"select * from teacher_position where id_teacher = {row["id"]}");
                for(int i = 0; i < post_table.Rows.Count; i++)
                {
                    DataRow post_row = post_table.Rows[i];
                    DataTable pos_table = db.Select($"select * from position where id = {post_row["id_position"]}");
                    DataRow pos_row = pos_table.Rows[i];
                    txtaddposition.Text += pos_row["name"].ToString() + " ";
                }                
                
                
                txtaddtel.Text = row["tel"].ToString();
                txtaddemail.Text = row["email"].ToString();
                
                txtaddimage.Text = row["image"].ToString();

                
                if (row["image"].ToString() != String.Empty)
                {
                    var uriSource = new Uri($"{row["image"]}"); //
                    imgaddimage.Source = new BitmapImage(uriSource);
                }             
                else
                {
                    var uriSource = new Uri("/iconteacher2.png", UriKind.Relative);
                    imgaddimage.Source = new BitmapImage(uriSource);
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult resualt = System.Windows.Forms.MessageBox.Show("Отменить изменения?", "Выход", MessageBoxButtons.YesNo);
            if (resualt == System.Windows.Forms.DialogResult.Yes)
            {
                TeachersList teachersList = new TeachersList(id_teacher);
                teachersList.Show();
                this.Close();
            }
        }

        private void btnaddEdit_Click(object sender, RoutedEventArgs e)
        {

            string addfname = txtaddfname.Text;
            string addsname = txtaddsname.Text;
            string addfathname = txtaddfathname.Text;
            string addposition = txtaddposition.Text;
            string addtel = txtaddtel.Text;
            string addemail = txtaddemail.Text;
            string addgroup = txtaddemail.Text;

            string addimage = txtaddimage.Text;

            //вместо автоинкремента
            int au_id;
            DataTable table = db.Select($"select id from teacher ORDER BY id DESC");
            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                au_id = Convert.ToInt32(row["id"]) + 1;
            }
            else au_id = 1;


            if (!p)
            {
                try
                {
                    db.Select($"insert into teacher values ({au_id}, '{addfname}',  '{addsname}',  '{addfathname}',  '{addtel}', '{addemail}',  '{addimage}');");
                    System.Windows.MessageBox.Show("Преподаватель добавлен!");
                    TeachersList teachersList = new TeachersList(id_teacher);
                    teachersList.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                     System.Windows.MessageBox.Show("Не получилось добавить преподавателя!");
                }            

            }
            if (p)
            {

                try
                {
                    db.Select($"update teacher set fname = '{addfname}',  sname = '{addsname}', fathname = '{addfathname}',  tel = '{addtel}', email = '{addemail}',  image = '{addimage}' where id = {this.id};");
                    System.Windows.MessageBox.Show("Изменения сохранены!");
                    TeachersList teachersList = new TeachersList(id_teacher);
                    teachersList.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show("Изменения не сохранены!");
                }                                       
            }
        }

        private void txtaddfname_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtaddfname.Text == "" || txtaddsname.Text == "" || txtaddfathname.Text == "" )
            {
                btnaddEdit.IsEnabled = false;
            }
            else
            {
                btnaddEdit.IsEnabled = true;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "img";
            dlg.DefaultExt = ".jpg";
            dlg.Filter = "Картинки(*.JPG;*.PNG;*.GIF)|*.JPG;*.PNG;*.GIF";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                string filename = dlg.FileName;               
                txtaddimage.Text = filename;
            }
        }

        private void txtaddimage_TextChanged(object sender, TextChangedEventArgs e)
        {
            string path = txtaddimage.Text;
            var uriSource = new Uri("/iconteacher2.png", UriKind.Relative);
            if (txtaddimage.Text != "")
            {
                try
                {
                    uriSource = new Uri($"{path}");
                    imgaddimage.Source = new BitmapImage(uriSource);
                }
                catch
                {                  
                    System.Windows.MessageBox.Show("Неверный путь", "Путь не найден");
                    txtaddimage.Text = "";
                }
            }
            else
            {              
                imgaddimage.Source = new BitmapImage(uriSource);
            }         

        }
    }
}
