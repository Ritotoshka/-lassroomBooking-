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

    public partial class AudienceList : Window
    {
        int id_teacher;
        DB db = new DB();
        string inventorys;
        public AudienceList(int id_teacher)
        {
            InitializeComponent();
            
            this.id_teacher = id_teacher;
            UpdateList();
        }
        private void UpdateList()
        {
            listaudience.Items.Clear();

            DataTable table = db.Select("SELECT * FROM audience order by number");
            

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow audience_row = table.Rows[i];
                DataTable inventory_audience_table = db.Select($"select id_inventory from inventory_audience where id_audience = {audience_row["id"]}");


                inventorys = "";
                for (int j = 0; j < inventory_audience_table.Rows.Count; j++)
                {
                    DataRow inventory_audience_row = inventory_audience_table.Rows[j];
                    DataTable inventory_table = db.Select($"select name from inventory where id = {inventory_audience_row["id_inventory"]}");
                    DataRow inventory_row = inventory_table.Rows[0];
                    inventorys+=inventory_row["name"] + " ";
                }                    
                
                listaudience.Items.Add(new Audience { Id = (int)audience_row["id"], Number = audience_row["number"].ToString(), Peculiarities = inventorys});
            }
            
        }
        private void btnaddaudience_Click(object sender, RoutedEventArgs e)
        {
            AudienceEdit addaudience = new AudienceEdit(id_teacher, false);
            addaudience.Show();
            this.Close();
        }

        private void btnchange_Click(object sender, RoutedEventArgs e)
        {
            Audience faudience = (Audience)listaudience.SelectedItem;
            if (faudience != null)
            {
                AudienceEdit addudience= new AudienceEdit(id_teacher, true, faudience.Id);
                addudience.Show();
                this.Close();
            }
            else
            {
                System.Windows.MessageBox.Show("Вы не выбрали аудиторию!");
            }
        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            Audience faudience = (Audience)listaudience.SelectedItem;


            if(faudience != null)
            {
                string message = $"Вы действительно хотите удалить {faudience.Number} аудиторию?";

                            DialogResult resualt = System.Windows.Forms.MessageBox.Show(message, "Удаление", MessageBoxButtons.YesNo);
                            if (resualt == System.Windows.Forms.DialogResult.Yes)
                            {
                                db.Select($"delete from inventory_audience where id_audience = {faudience.Id}");
                                db.Select($"DELETE FROM audience WHERE id = {faudience.Id}");

                                UpdateList();
                            }
            }
            else
            {
                System.Windows.MessageBox.Show("Вы не выбрали аудиторию!");
            }
            
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            EditLists editLists = new EditLists(id_teacher);
            editLists.Show();
            this.Close();
        }

        private void listaudience_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Audience faudinece = (Audience)listaudience.SelectedItem;
            if (faudinece != null)
            {
                DataTable table = db.Select($"SELECT * FROM audience WHERE id = {faudinece.Id}");
                               
                if (table.Rows.Count > 0)
                {
                    DataRow row = table.Rows[0];
                    txtnumber.Text = row["number"].ToString();
                    txtfloor.Text = row["id_floor"].ToString();

                    DataTable inventory_audience_table = db.Select($"select id_inventory from inventory_audience where id_audience = {row["id"]}");


                    inventorys = "";
                    for (int j = 0; j < inventory_audience_table.Rows.Count; j++)
                    {
                        DataRow inventory_audience_row = inventory_audience_table.Rows[j];
                        DataTable inventory_table = db.Select($"select name from inventory where id = {inventory_audience_row["id_inventory"]}");
                        DataRow inventory_row = inventory_table.Rows[0];
                        inventorys += inventory_row["name"] + " ";
                    }

                    txtinventory.Text = inventorys;
                }

            }
        }
    }
}
