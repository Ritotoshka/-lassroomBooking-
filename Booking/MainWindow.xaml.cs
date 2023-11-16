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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Booking
{
    
    public partial class MainWindow : Window
    {
        DB db = new DB();
        public MainWindow()
        {
            

            InitializeComponent();
            panel_error.Visibility = Visibility.Collapsed;//скрыть сроку ошибки

            //TeachersList adminMenu = new TeachersList();
            //adminMenu.Show();
            //this.Close();
            DataTable history_table = db.Select($"select * from acchistory");
            if(history_table.Rows.Count > 0)
            {
                DataRow history_row = history_table.Rows[0];
                DataTable acc_table = db.Select($"select * from acc where id = {history_row["id_acc"]}");
                DataRow acc_row = acc_table.Rows[0];
                txt_login.Text = $"{acc_row["login"].ToString()}";
                txt_password.Password = $"{acc_row["password"].ToString()}";
                if(acc_row["id_accounttype"].ToString() == "2")
                {
                    rb_teacher.IsChecked = true;
                }
                else
                {
                    rb_admin.IsChecked = true;
                }
            }
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_out_Click(object sender, RoutedEventArgs e)
        {
            DialogResult resualt = System.Windows.Forms.MessageBox.Show("Вы действительно хотите выйти из приложения?", "Выход", MessageBoxButtons.YesNo);
            if (resualt == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }         
        }

        private void btn_in_Click(object sender, RoutedEventArgs e)
        {
            lb_message.Content = "";

            string login = txt_login.Text;
            string password = txt_password.Password;

            


            if (login != String.Empty && password != String.Empty)
            {
                if ((bool)rb_admin.IsChecked)
                {
                    
                    DataTable table = db.Select($"SELECT * FROM acc WHERE login = '{login}' AND password = '{password}' AND id_accounttype = 1;");
                    
                    if (table.Rows.Count > 0)
                    {
                        if (chk_remember.IsChecked == true)
                        {
                            DataRow acc_row = table.Rows[0];
                            db.Select($"insert into acchistory values (2, {acc_row["id"]})");
                        }
                        DataRow row = table.Rows[0];
                        AdminMenu adminMenu = new AdminMenu((int)row["id_teacher"]);
                        adminMenu.Show();
                        this.Close();
                    }
                    else
                    {
                        panel_error.Visibility = Visibility.Visible;
                        txt_password.Password = "";
                        lb_message.Content = "Неправльно введён логин или пароль!";
                    }

                    

                }
                if ((bool)rb_teacher.IsChecked)
                {
                    DataTable table = db.Select($"SELECT * FROM acc WHERE (login = '{login}' AND password = '{password}') AND id_accounttype = 2;");
                    
                    if (table.Rows.Count > 0)
                    {
                        if (chk_remember.IsChecked == true)
                        {
                            DataRow acc_row = table.Rows[0];
                            db.Select($"insert into acchistory values (2, {acc_row["id"]})");
                        }
                        DataRow row = table.Rows[0];
                        BookingList bookingList = new BookingList((int)row["id_teacher"]);
                        bookingList.Show();
                        this.Close();
                    }
                    else
                    {
                        panel_error.Visibility = Visibility.Visible;
                        txt_password.Password = "";
                        lb_message.Content = "Неправльно введён логин или пароль!";
                    }
                }
                else
                {
                    panel_error.Visibility = Visibility.Visible;
                    txt_password.Password = "";
                    lb_message.Content = "Неправльно введён логин или пароль!";
                }
            }
            else
            {
                panel_error.Visibility = Visibility.Visible;
                lb_message.Content = "Неправльно введён логин или пароль!";
            }

        }
    }
}
