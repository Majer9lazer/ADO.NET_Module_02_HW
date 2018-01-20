using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ADO.NET_Module_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _connectionOleDb = "";
        public MainWindow()
        {
            InitializeComponent();
            _connectionOleDb = ConfigurationManager.ConnectionStrings["OleDbConnection"].ConnectionString;
            ErrorOrSuccesTextBlock.Text = "Чтобы удалить запись - заполните только первое поле";
            // разкоменьтте всё чтобы создать таблицы для необходимости
            #region Для создания таблиц разблокируйте , но сначала просмотрите не были ли они созданы ранее




            //using (OleDbConnection conn = new OleDbConnection(_connectionOleDb))
            //{
            //    try
            //    {
            //        //conn.Open();
            //        //OleDbCommand cmd = new OleDbCommand();
            //        //cmd.CommandText = "CREATE TABLE TablesModel (intModelID int NOT NULL," +
            //        //                  "strName string(100)," +
            //        //                  "intManufacturerID int NOT NULL," +
            //        //                  "intSMCSFamilyID int NOT NULL," +
            //        //                  "strImage string(100))";
            //        //cmd.Connection = conn;
            //        //cmd.ExecuteNonQuery();
            //        //cmd.CommandText = null;//cmd.CommandText.Remove(0, cmd.CommandText.Length);
            //        //cmd.CommandText =
            //        //    "CREATE TABLE TablesManufacturer (intManufacturerID int NOT NULL," +
            //        //    "strName string(100))";
            //        //cmd.ExecuteNonQuery();

            //        //cmd.CommandText = null;// cmd.CommandText.Remove(0, cmd.CommandText.Length);
            //        //cmd.CommandText = "CREATE TABLE TablesStopReason (intStopReason int NOT NULL," +
            //        //                  "strReason string(100)," +
            //        //                  "bitDowntime int," +
            //        //"bitUnscheduled int," +
            //        //"bitPMStoppages int," +
            //        //"bitScheduledRepairsAndOther int," +
            //        //"intLocationId int NOT NULL)";
            //        //cmd.ExecuteNonQuery();


            //    }
            //    catch (Exception ex)
            //    {
            //        ErrorOrSuccesTextBlock.Text += ex.Message + "\n";
            //    }
            //}
            #endregion
        }





        private void TablesModel_OnSelected(object sender, RoutedEventArgs e)
        {

            Label1.Visibility = Visibility.Visible;
            Label2.Visibility = Visibility.Visible;
            Label3.Visibility = Visibility.Visible;
            Label4.Visibility = Visibility.Visible;
            Label5.Visibility = Visibility.Visible;
            Label6.Visibility = Visibility.Hidden;
            Label7.Visibility = Visibility.Hidden;
            Label1.Content = "inModelId";
            Label2.Content = "strName";
            Label3.Content = "intManufacturerID";
            Label4.Content = "intSMCSFamilyID";
            Label5.Content = "strImage";
            Label6.Content = null;
            Label7.Content = null;
            TextBox1.Visibility = Visibility.Visible;
            TextBox2.Visibility = Visibility.Visible;
            TextBox3.Visibility = Visibility.Visible;
            TextBox4.Visibility = Visibility.Visible;
            TextBox5.Visibility = Visibility.Visible;
            TextBox6.Visibility = Visibility.Hidden;
            TextBox7.Visibility = Visibility.Hidden;
            SetData.Visibility = Visibility.Visible;
            DeleteButton.Visibility = Visibility.Visible;

        }

        private void SetData_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (ComboBoxItem comboboxItem in TablesCombobox.Items)
                {
                    if (comboboxItem.IsSelected)
                    {
                        if (comboboxItem.Name == "TablesModel")
                        {
                            using (OleDbConnection con = new OleDbConnection(_connectionOleDb))
                            {
                                con.Open();
                                OleDbCommand cmd = new OleDbCommand();

                                //OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from TablesModel",con);
                                //DataSet ds= new DataSet();
                                //adapter.Fill(ds,"TablesModel");
                                //var a = ds.Tables[0].Columns[0];

                                cmd.CommandText =
                                    "insert into TablesModel(intModelID, strName, intManufacturerID, intSMCSFamilyID, strImage) values" +
                                    "(" +

                                    TextBox1.Text + ",'" +
                                    TextBox2.Text + "'," +
                                    TextBox3.Text + "," +
                                    TextBox4.Text + ",'" +
                                    TextBox5.Text + "'" +
                                    ")";
                                cmd.Connection = con;
                                cmd.ExecuteNonQuery();
                                TextBox1.Text = null;
                                TextBox2.Text = null;
                                TextBox3.Text = null;
                                TextBox4.Text = null;
                                TextBox5.Text = null;
                                TextBox6.Text = null;
                                TextBox7.Text = null;
                                ErrorOrSuccesTextBlock.Text = "Данные Были успешно внесены!";
                            }
                        }
                        else if (comboboxItem.Name == "TablesManufacturer")
                        {
                            using (OleDbConnection con = new OleDbConnection(_connectionOleDb))
                            {
                                con.Open();
                                OleDbCommand cmd = new OleDbCommand();

                                //OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from TablesModel",con);
                                //DataSet ds= new DataSet();
                                //adapter.Fill(ds,"TablesModel");
                                //var a = ds.Tables[0].Columns[0];

                                cmd.CommandText = "insert into TablesManufacturer(intManufacturerID, strName) values" +
                                                  "(" +

                                                  TextBox1.Text + ",'" +
                                                  TextBox2.Text + "'" +
                                                  ")";
                                cmd.Connection = con;
                                cmd.ExecuteNonQuery();
                                TextBox1.Text = null;
                                TextBox2.Text = null;
                                TextBox3.Text = null;
                                TextBox4.Text = null;
                                TextBox5.Text = null;
                                TextBox6.Text = null;
                                TextBox7.Text = null;
                                ErrorOrSuccesTextBlock.Text = "Данные Были успешно внесены!";
                            }
                        }
                        else if (comboboxItem.Name == "TablesStopReason")
                        {
                            using (OleDbConnection con = new OleDbConnection(_connectionOleDb))
                            {
                                con.Open();
                                OleDbCommand cmd = new OleDbCommand();

                                //OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from TablesModel",con);
                                //DataSet ds= new DataSet();
                                //adapter.Fill(ds,"TablesModel");
                                //var a = ds.Tables[0].Columns[0];

                                cmd.CommandText =
                                    "insert into TablesStopReason(intStopReason ,strReason ,bitDowntime,bitUnscheduled,bitPMStoppages ,bitScheduledRepairsAndOther ,intLocationId) values" +
                                    "(" +
                                    TextBox1.Text + ",'" +
                                    TextBox2.Text + "'," +
                                    TextBox3.Text + "," +
                                    TextBox4.Text + "," +
                                    TextBox5.Text + "," +
                                    TextBox6.Text + "," +
                                    TextBox7.Text +
                                    ")";
                                cmd.Connection = con;
                                cmd.ExecuteNonQuery();
                                TextBox1.Text = null;
                                TextBox2.Text = null;
                                TextBox3.Text = null;
                                TextBox4.Text = null;
                                TextBox5.Text = null;
                                TextBox6.Text = null;
                                TextBox7.Text = null;
                                ErrorOrSuccesTextBlock.Text = "Данные Были успешно внесены!";
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                ErrorOrSuccesTextBlock.Text = ex.Message;
            }
        }

        private void TablesManufacturer_OnSelected(object sender, RoutedEventArgs e)
        {
            Label1.Visibility = Visibility.Visible;
            Label2.Visibility = Visibility.Visible;
            Label3.Visibility = Visibility.Hidden;
            Label4.Visibility = Visibility.Hidden;
            Label5.Visibility = Visibility.Hidden;
            Label6.Visibility = Visibility.Hidden;
            Label7.Visibility = Visibility.Hidden;
            Label1.Content = "intManufacturerID";
            Label2.Content = "strName";
            Label3.Content = null;
            Label4.Content = null;
            Label5.Content = null;
            Label6.Content = null;
            Label7.Content = null;
            TextBox1.Visibility = Visibility.Visible;
            TextBox2.Visibility = Visibility.Visible;
            TextBox3.Visibility = Visibility.Hidden;
            TextBox4.Visibility = Visibility.Hidden;
            TextBox5.Visibility = Visibility.Hidden;
            TextBox6.Visibility = Visibility.Hidden;
            TextBox7.Visibility = Visibility.Hidden;
            SetData.Visibility = Visibility.Visible;
        }

        private void TablesStopReason_OnSelected(object sender, RoutedEventArgs e)
        {
            Label1.Visibility = Visibility.Visible;
            Label2.Visibility = Visibility.Visible;
            Label3.Visibility = Visibility.Visible;
            Label4.Visibility = Visibility.Visible;
            Label5.Visibility = Visibility.Visible;
            Label6.Visibility = Visibility.Visible;
            Label7.Visibility = Visibility.Visible;
            Label1.Content = "intStopReason";
            Label2.Content = "strReason ";
            Label3.Content = "bitDowntime";
            Label4.Content = "bitUnscheduled ";
            Label5.Content = "bitPMStoppages ";
            Label6.Content = "bitScheduledRepair";
            Label7.Content = "intLocationId";
            TextBox1.Visibility = Visibility.Visible;
            TextBox2.Visibility = Visibility.Visible;
            TextBox3.Visibility = Visibility.Visible;
            TextBox4.Visibility = Visibility.Visible;
            TextBox5.Visibility = Visibility.Visible;
            TextBox6.Visibility = Visibility.Visible;
            TextBox7.Visibility = Visibility.Visible;
            SetData.Visibility = Visibility.Visible;

        }

        private void ConnectToAccess_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void ListBoxItem_OnSelected(object sender, RoutedEventArgs e)
        {
            if (Label1 != null)
            {
                Label1.Visibility = Visibility.Hidden;
                Label2.Visibility = Visibility.Hidden;
                Label3.Visibility = Visibility.Hidden;
                Label4.Visibility = Visibility.Hidden;
                Label5.Visibility = Visibility.Hidden;
                Label6.Visibility = Visibility.Hidden;
                Label7.Visibility = Visibility.Hidden;
                Label1.Content = null;
                Label2.Content = null;
                Label3.Content = null;
                Label4.Content = null;
                Label5.Content = null;
                Label6.Content = null;
                Label7.Content = null;
                TextBox1.Visibility = Visibility.Hidden;
                TextBox2.Visibility = Visibility.Hidden;
                TextBox3.Visibility = Visibility.Hidden;
                TextBox4.Visibility = Visibility.Hidden;
                TextBox5.Visibility = Visibility.Hidden;
                TextBox6.Visibility = Visibility.Hidden;
                TextBox7.Visibility = Visibility.Hidden;
                SetData.Visibility = Visibility.Hidden;
            }
        }

        private void DeleteButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (ComboBoxItem comboboxItem in TablesCombobox.Items)
                {
                    if (comboboxItem.IsSelected)
                    {
                        if (comboboxItem.Name == "TablesModel")
                        {
                            using (OleDbConnection con = new OleDbConnection(_connectionOleDb))
                            {
                                con.Open();
                                OleDbCommand cmd = new OleDbCommand();

                                //OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from TablesModel",con);
                                //DataSet ds= new DataSet();
                                //adapter.Fill(ds,"TablesModel");
                                //var a = ds.Tables[0].Columns[0];

                                cmd.CommandText =
                                    "DELETE FROM TablesModel WHERE intModelId = " +
                                    TextBox1.Text;
                                cmd.Connection = con;
                                cmd.ExecuteNonQuery();
                                TextBox1.Text = null;
                                TextBox2.Text = null;
                                TextBox3.Text = null;
                                TextBox4.Text = null;
                                TextBox5.Text = null;
                                TextBox6.Text = null;
                                TextBox7.Text = null;
                                ErrorOrSuccesTextBlock.Text = "Данные Были успешно внесены! Или Удалены)";
                            }
                        }
                        else if (comboboxItem.Name == "TablesManufacturer")
                        {
                            using (OleDbConnection con = new OleDbConnection(_connectionOleDb))
                            {
                                con.Open();
                                OleDbCommand cmd = new OleDbCommand();

                                //OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from TablesModel",con);
                                //DataSet ds= new DataSet();
                                //adapter.Fill(ds,"TablesModel");
                                //var a = ds.Tables[0].Columns[0];

                                cmd.CommandText = "insert into TablesManufacturer(intManufacturerID, strName) values" +
                                                  "(" +

                                                  TextBox1.Text + ",'" +
                                                  TextBox2.Text + "'" +
                                                  ")";
                                cmd.Connection = con;
                                cmd.ExecuteNonQuery();
                                TextBox1.Text = null;
                                TextBox2.Text = null;
                                TextBox3.Text = null;
                                TextBox4.Text = null;
                                TextBox5.Text = null;
                                TextBox6.Text = null;
                                TextBox7.Text = null;
                                ErrorOrSuccesTextBlock.Text = "Данные Были успешно внесены!";
                            }
                        }
                        else if (comboboxItem.Name == "TablesStopReason")
                        {
                            using (OleDbConnection con = new OleDbConnection(_connectionOleDb))
                            {
                                con.Open();
                                OleDbCommand cmd = new OleDbCommand();

                                //OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from TablesModel",con);
                                //DataSet ds= new DataSet();
                                //adapter.Fill(ds,"TablesModel");
                                //var a = ds.Tables[0].Columns[0];

                                cmd.CommandText =
                                    "insert into TablesStopReason(intStopReason ,strReason ,bitDowntime,bitUnscheduled,bitPMStoppages ,bitScheduledRepairsAndOther ,intLocationId) values" +
                                    "(" +
                                    TextBox1.Text + ",'" +
                                    TextBox2.Text + "'," +
                                    TextBox3.Text + "," +
                                    TextBox4.Text + "," +
                                    TextBox5.Text + "," +
                                    TextBox6.Text + "," +
                                    TextBox7.Text +
                                    ")";
                                cmd.Connection = con;
                                cmd.ExecuteNonQuery();
                                TextBox1.Text = null;
                                TextBox2.Text = null;
                                TextBox3.Text = null;
                                TextBox4.Text = null;
                                TextBox5.Text = null;
                                TextBox6.Text = null;
                                TextBox7.Text = null;
                                ErrorOrSuccesTextBlock.Text = "Данные Были успешно внесены!";
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                ErrorOrSuccesTextBlock.Text = ex.Message;
            }
        }
    }
}
