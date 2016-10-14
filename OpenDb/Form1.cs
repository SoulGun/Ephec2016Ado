using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenDb
{
    public partial class Form1 : Form
    {
        BindingSource bindingSource1 = new BindingSource();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();



        public Form1()
        {
            InitializeComponent();
            rechargeButton.Text = "recharges";
            submitButton.Text = "submit";
            rechargeButton.Click += new System.EventHandler(rechargeButton_click);
            submitButton.Click += new System.EventHandler(submitButton_click);
            MyConfig();
        }


        public void MyConfig()
        {
            CreateEtuPanel.Hide();
            OperationChoicePanel.Hide();
            panelDelete.Hide();
            panelUpdate.Hide();
            panelSelectAll.Hide();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(
                  "Integrated Security=SSPI;Initial Catalog=Sgbd2016"))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM ETUDIANT", connection);

                    SqlDataReader reader = command.ExecuteReader();

                    // while there is another record present
                    while (reader.Read())
                    {
                        retourData.Text =
                            // write the data on to the screen
                        (String.Format("{0} \t | {1} \t | {2} \t | {3}",
                            // call the objects from their index
                        reader[0], reader[1], reader[2], reader[3]));
                    }
                }
                catch (SqlException ex)
                {
                    string myerror;
                    switch (ex.Number)
                    {
                        case 18456:
                            myerror = "mauvais user";
                            break;
                        case 4060:
                            myerror = "mauvais db";
                            break;
                        default:
                            myerror = ex.Message;
                            break;

                    }

                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection
           ("Data Source=arpa ;Initial Catalog =" + baseDeDonnées.Text + ";User ID=" + userTextBox.Text +
                ";Password=" + textBoxPassword.Text))
            {
                try
                {
                    connection.Open();
                    OperationChoicePanel.Show();
                    panelConnection.Hide();
                    MessageBox.Show("you're now connected to   " + connection.Database + "   choose your operation ,please");


                }
                catch (SqlException ex)
                {
                    string myerror;
                    switch (ex.Number)
                    {
                        case 18456:
                            myerror = "mauvais user";
                            break;
                        case 4060:
                            myerror = "mauvaise db";
                            break;
                        default:
                            myerror = ex.Message;
                            break;

                    }
                    MessageBox.Show("une erreur est survenue détails: " + myerror);

                }
                finally
                {

                    connection.Close();
                }
            }
        }

        public bool DeleteArticle(string nomEtu)
        {
            using (SqlConnection connection = new SqlConnection(
                  "Integrated Security=SSPI;Initial Catalog=Sgbd2016"))
            {
                bool result = false;

                //Create the SQL Query for deleting an article
                string sqlQuery = String.Format("delete from Etudiant where ETU_nom ={0}", nomEtu);

                //Create and open a connection to SQL Server 

                connection.Open();

                //Create a Command object
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                // Execute the command
                command.ExecuteNonQuery();


                return result;
            }
        }
        //autre methode à creer appel à la storedprocedure  with id to delete
        //autre methode à creer appel à la storedprocedure  upadte
        private void CheckBoxDelete_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("delete by id", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    panelEtuDeleteByName.Hide();
                    panelDelete.Show();
                }
                else if (dialogResult == DialogResult.No)
                {
                    panelEtuDeleteID.Hide();
                    panelDelete.Show();
                    //do something else
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                CheckBoxDelete.Dispose();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection
          ("Data Source=arpa ;Initial Catalog =" + baseDeDonnées.Text + ";User ID=" + userTextBox.Text +
               ";Password=" + textBoxPassword.Text))
            {
                try
                {
                    connection.Open();




                    SqlCommand command = new SqlCommand("EtuDeleteBYName", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    if (nameToDeleteTextbox.Text != null) command.Parameters.Add(new SqlParameter("@nom", nameToDeleteTextbox.Text));


                    int i = command.ExecuteNonQuery();
                    MessageBox.Show("vous avez effacé " + i + "enregistrement(s) à la DB");

                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                    panelDelete.Hide();
                }

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection
          ("Data Source=arpa ;Initial Catalog =" + baseDeDonnées.Text + ";User ID=" + userTextBox.Text +
               ";Password=" + textBoxPassword.Text))
            {
                try
                {
                    connection.Open();
                    CreateEtuPanel.Show();
                    panel_InsertButton.Show();
                    SqlCommand command = new SqlCommand("Etu_Create", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@nom", SqlDbType.NVarChar, 50, "nom"));
                    command.Parameters.Add(new SqlParameter("@prenom", SqlDbType.NVarChar, 50, "penom"));
                    command.Parameters.Add(new SqlParameter("@matricule", SqlDbType.NVarChar, 50, "matricule"));
                    if (textBoxNom.Text != null) command.Parameters[0].Value = textBoxNom.Text;
                    if (textBoxPrenom.Text != null) command.Parameters[1].Value = textBoxPrenom.Text;
                    if (textBoxMatricule.Text != null) command.Parameters[2].Value = textBoxMatricule.Text;
                    int i = command.ExecuteNonQuery();
                    MessageBox.Show("vous avez ajouté " + i + "enregistrement(s) à la DB");

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    CreateEtuPanel.Hide();
                    connection.Close();
                }

            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                CreateEtuPanel.Show();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection
      ("Data Source=arpa ;Initial Catalog =" + baseDeDonnées.Text + ";User ID=" + userTextBox.Text +
           ";Password=" + textBoxPassword.Text))
            {
                try
                {
                    connection.Open();




                    SqlCommand command = new SqlCommand("EtuDeleteById", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    if (nameToDeleteTextbox.Text != null) command.Parameters.Add(new SqlParameter("@id", idToDelete.Text));


                    int i = command.ExecuteNonQuery();
                    MessageBox.Show("vous avez effacé " + i + "enregistrement(s) à la DB");

                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    panelDelete.Hide();
                    connection.Close();
                }

            }
        }

        private void CheckBoxUpdate_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("update by id", "update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                panelUpdateByName.Hide();
                panelUpdate.Show();
                CreateEtuPanel.Show();
                panel_InsertButton.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                panelUpdateById.Hide();
                panelUpdate.Show();
                CreateEtuPanel.Show();
                panel_InsertButton.Hide();
            }

        }

        private void buttonIdUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection
              ("Data Source=arpa ;Initial Catalog =" + baseDeDonnées.Text + ";User ID=" + userTextBox.Text +
               ";Password=" + textBoxPassword.Text))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("UpdateByID", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    if (textBoxIdUpdate.Text != null) command.Parameters.Add(new SqlParameter("@id", textBoxIdUpdate.Text));
                    if (textBoxNom.Text != null) command.Parameters.Add(new SqlParameter("@nom", textBoxNom.Text));
                    if (textBoxPrenom.Text != null) command.Parameters.Add(new SqlParameter("@prenom", textBoxPrenom.Text));
                    if (textBoxMatricule.Text != null) command.Parameters.Add(new SqlParameter("@matricule", textBoxMatricule.Text));

                    int i = command.ExecuteNonQuery();
                    MessageBox.Show("vous avez modifié " + i + "enregistrement(s) à la DB");

                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    panelUpdate.Hide();
                    connection.Close();
                }

            }
        }


        private void buttonVueUpdate_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection
                ("Data Source=arpa ;Initial Catalog =" + baseDeDonnées.Text + ";User ID=" + userTextBox.Text +
                 ";Password=" + textBoxPassword.Text))
            {
                try
                {
                    connection.Open();

                    string sqlQuery = String.Format("SELECT * FROM ETUDIANT where ETU_ID={0}", textBoxIdUpdate.Text);
                    SqlCommand command1 = new SqlCommand(sqlQuery, connection);

                    SqlDataReader reader = command1.ExecuteReader();

                    // while there is another record present
                    while (reader.Read())
                    {
                        retourData.Text =
                            // write the data on to the screen
                        (String.Format("{0} \t | {1} \t | {2} \t | {3}",
                            // call the objects from their index
                        reader[0], reader[1], reader[2], reader[3]));
                    }
                    reader.Close();
                    panelSelectAll.Hide();
                    connection.Close();
                }


                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            }
        }


        private void checkBoxRead_CheckedChanged(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection
                ("Data Source=arpa ;Initial Catalog =" + baseDeDonnées.Text + ";User ID=" + userTextBox.Text +
                 ";Password=" + textBoxPassword.Text))
            {
                try
                {
                    connection.Open();


                    SqlCommand command1 = new SqlCommand("ETU_SelectAll", connection);
                    command1.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command1.ExecuteReader();
                    panelSelectAll.Show();
                    listBoxEtudiants.Items.Clear();
                    // while there is another record present
                    while (reader.Read())
                    {
                        listBoxEtudiants.Items.Add
                            // write the data on to the screen
                         (String.Format("{0} \t | {1} \t | {2} ",
                            // call the objects from their index
                         reader[0], reader[1], reader[2]));
                    }

                    reader.Close();
                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void buttonNameUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection
          ("Data Source=arpa ;Initial Catalog =" + baseDeDonnées.Text + ";User ID=" + userTextBox.Text +
           ";Password=" + textBoxPassword.Text))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("UpdateBYName", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    if (textBoxNom.Text != null) command.Parameters.Add(new SqlParameter("@nom", textBoxNom.Text));
                    if (textBoxPrenom.Text != null) command.Parameters.Add(new SqlParameter("@prenom", textBoxPrenom.Text));
                    if (textBoxMatricule.Text != null) command.Parameters.Add(new SqlParameter("@matricule", textBoxMatricule.Text));

                    int i = command.ExecuteNonQuery();
                    MessageBox.Show("vous avez modifié " + i + "enregistrement(s) à la DB");

                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    panelUpdate.Hide();
                    connection.Close();
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection
                ("Data Source=arpa ;Initial Catalog =" + baseDeDonnées.Text + ";User ID=" + userTextBox.Text +
                 ";Password=" + textBoxPassword.Text))
                try
                {



                    connection.Open();

                    SqlCommand command1 = new SqlCommand("Etu_SelectByName", connection);
                    command1.CommandType = CommandType.StoredProcedure;
                    if (textBoxNameUpdate.Text != null) command1.Parameters.Add(new SqlParameter("@nom", textBoxNameUpdate.Text));

                    SqlDataReader reader = command1.ExecuteReader();

                    // while there is another record present
                    while (reader.Read())
                    {
                        retourData.Text =
                            // write the data on to the screen
                        (String.Format("{0} \t | {1} \t | {2} \t | {3}",
                            // call the objects from their index
                        reader[0], reader[1], reader[2], reader[3]));
                    }
                    reader.Close();
                    panelSelectAll.Hide();

                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }


        }
        private void submitButton_click(object sender, EventArgs e)
        { 

            dataAdapter.Update((DataTable)bindingSource1.DataSource);

        }



        private void rechargeButton_click(object sender, EventArgs e)
        {
            GetData(dataAdapter.SelectCommand.CommandText);



        }
        public void GetData(string slctCommand)
        {

            using (SqlConnection myconnection = new SqlConnection("Data Source=arpa ;Initial Catalog =Sgbd2016 ;User ID=monUser;Password=monUser"))
            {
                try
                {
                    dataAdapter = new SqlDataAdapter(slctCommand, myconnection);
                    SqlCommandBuilder commandbuilder = new SqlCommandBuilder(dataAdapter);
                    DataTable table = new DataTable();
                   dataAdapter.Fill(table);

                    bindingSource1.DataSource = table;
                    dataGridView.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCells);

                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    myconnection.Close();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {            dataGridView.DataSource = bindingSource1;

            GetData("select * from Etudiant as E inner join Voiture as v on E.ETU_MATRICULE=v.proprio");
        }




    }
}
