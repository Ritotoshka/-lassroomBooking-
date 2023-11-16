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
      public partial class AudienceEdit : Window
    {
        int id_teacher;
        public bool p;
        public int id;
        DB db = new DB();
        Dictionary<int, System.Windows.Controls.CheckBox> dictionary_inventorys = new Dictionary<int, System.Windows.Controls.CheckBox>();
        public AudienceEdit(int id_teacher, bool p)
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

            DataTable inventory_table = db.Select($"SELECT * FROM inventory");

            if (inventory_table.Rows.Count > 0)
            {

                for (int i = 0; i < inventory_table.Rows.Count; i++)
                {
                    DataRow inventory_row = inventory_table.Rows[i];
                    System.Windows.Controls.CheckBox checkBoxe = new System.Windows.Controls.CheckBox();
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

        public AudienceEdit(int id_teacher, bool p, int id) : this(id_teacher, p)
        {
            InitializeComponent();
            this.id = id;

            DataTable table = db.Select($"SELECT * FROM audience WHERE id = {this.id}");
            DataRow row = table.Rows[0];

            txtaddnumber.Text = row["number"].ToString();

            DataTable inv_aud_table = db.Select($"select * from inventory_audience where id_audience = {id}");

            for (int i = 0; i < inv_aud_table.Rows.Count; i++)
            {
                DataRow inv_aud = inv_aud_table.Rows[i];
                foreach (int id_inventory in dictionary_inventorys.Keys)
                {
                    if (id_inventory == (int)inv_aud["id_inventory"])
                    {
                        dictionary_inventorys[id_inventory].IsChecked = true;
                    }
                }
            }

            list_floor.Text = row["id_floor"].ToString();
            
        }

        private void btnaddEdit_Click(object sender, RoutedEventArgs e)
        {
            DB db = new DB();


            //вместо автоинкремента
            int au_id;
            DataTable table = db.Select($"select id from audience ORDER BY id DESC");
            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                au_id = Convert.ToInt32(row["id"]) + 1;
            }
            else au_id = 1;

            DataTable floor_table = db.Select($"select * from floor where number = '{list_floor.SelectedItem.ToString()}'");
            DataRow floor_row = floor_table.Rows[0];
            int id_floor = (int)floor_row["id"];

            
            int count_checked = 0;

            foreach (int id_inventory in dictionary_inventorys.Keys)
            {
                if (dictionary_inventorys[id_inventory].IsChecked == true)
                {
                    count_checked++;
                }
            }

            
            if (!p)
            {

                try
                {
                    

                    int id_audience;
                    DataTable audience_table = db.Select($"select id from audience ORDER BY id DESC");
                    if (audience_table.Rows.Count > 0)
                    {
                        DataRow audience_row = audience_table.Rows[0];
                        id_audience = Convert.ToInt32(audience_row["id"]) + 1;
                    }
                    else id_audience = 1;


                    db.Select($"insert into audience values ({id_audience}, '{txtaddnumber.Text}',  {id_floor});");


                    foreach (int id_inventory in dictionary_inventorys.Keys)
                    {
                        if (dictionary_inventorys[id_inventory].IsChecked == true)
                        {
                            //вместо автоинкремента
                            int id_inventory_audience;
                            DataTable inventory_audience_table = db.Select($"select id from inventory_audience ORDER BY id DESC");
                            if (inventory_audience_table.Rows.Count > 0)
                            {
                                DataRow inventory_audience_table_row = inventory_audience_table.Rows[0];
                                id_inventory_audience = Convert.ToInt32(inventory_audience_table_row["id"]) + 1;
                            }
                            else id_inventory_audience = 1;
                            int number = 1;
                            db.Select($"insert into inventory_audience values ({id_inventory_audience}, {id_audience}, {id_inventory}, {number});");


                        }                        
                    }

                    System.Windows.MessageBox.Show("Аудитория добавлена!");
                    AudienceList audienceList = new AudienceList(id_teacher);
                    audienceList.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show("Изменения не сохранены!");
                }

            }
            if (p)
            {
                

                try
                {

                    if (count_checked == 0)
                    {
                        db.Select($"delete from inventory_audience where id_audience = {id}");
                    }

                    foreach (int id_inventory in dictionary_inventorys.Keys)
                    {
                        if (dictionary_inventorys[id_inventory].IsChecked == true)
                        {
                            //вместо автоинкремента
                            int id_inventory_audience;
                            DataTable inventory_audience_table = db.Select($"select id from inventory_audience ORDER BY id DESC");
                            if (inventory_audience_table.Rows.Count > 0)
                            {
                                DataRow inventory_audience_table_row = inventory_audience_table.Rows[0];
                                id_inventory_audience = Convert.ToInt32(inventory_audience_table_row["id"]) + 1;
                            }
                            else id_inventory_audience = 1;
                            int number = 1;
                            db.Select($"insert into inventory_audience values ({id_inventory_audience}, {id}, {id_inventory}, {number});");

                            
                        }
                        else
                        {
                            db.Select($"delete from inventory_audience where id_audience = {id} and id_inventory = {id_inventory}");
                        }
                    }

                    db.Select($"update audience set number = '{txtaddnumber.Text}', id_floor = {id_floor} where id = {id};");
                    
                    System.Windows.MessageBox.Show("Изменения сохранены!");
                    AudienceList audienceList = new AudienceList(id_teacher);
                    audienceList.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show("Изменения не сохранены!" + ex);
                }
         
                
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult resualt = System.Windows.Forms.MessageBox.Show("Отменить изменения?", "Выход", MessageBoxButtons.YesNo);
            if (resualt == System.Windows.Forms.DialogResult.Yes)
            {
                AudienceList audienceList = new AudienceList(id_teacher);
                audienceList.Show();
                this.Close();
            }
        }

        private void txtaddnumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            if (txtaddnumber.Text == "")
            {
                btnaddEdit.IsEnabled = false;
            }
            else
            {
                btnaddEdit.IsEnabled = true;
            }
        }

        private void list_floor_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DataTable floor_table = db.Select($"select number from floor;");

            list_floor.Items.Clear();

            if (floor_table.Rows.Count != 0)
            {
                foreach (DataRow floor_row in floor_table.Rows)
                {
                    list_floor.Items.Add(floor_row["number"].ToString());
                }
            }
        }
    }
}
