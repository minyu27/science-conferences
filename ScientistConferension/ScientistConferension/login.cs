using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientistConferension
{
    public partial class login : Form
    {
        private SQLiteConnection connection;

        public login()
        {
            InitializeComponent();
            string connectionString = "Data Source=UserLogin.db;";
            connection = new SQLiteConnection($"Data Source=UserLogin.db;"); // Используйте поле класса
            connection.Open();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Users (Login TEXT, Password TEXT);";
                    cmd.ExecuteNonQuery();

                    // Вставляем значения User и 123 в первую строку
                    cmd.CommandText = "INSERT INTO Users (Login, Password) VALUES ('user', '123');";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Admins (Login TEXT, Password TEXT);";
                    cmd.ExecuteNonQuery();

                    // Вставляем значения User и 123 в первую строку
                    cmd.CommandText = "INSERT INTO Admins (Login, Password) VALUES ('admin', '123');";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnLog_Click_1(object sender, EventArgs e)
        {
            if (tbUser.Text != null || tbPass.Text != null)
            {
                string username = tbUser.Text;
                string password = tbPass.Text;

                //bool isAdmin = IsAdminUser(username, password);

                if (CheckCredentialsInTable(username, password))
                {
                    Scientist scientistForm = new Scientist(username);
                    scientistForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль. Пожалуйста, повторите попытку.");
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль. Пожалуйста, повторите попытку.");
            }
        }

        private bool CheckCredentialsInTable(string username, string password)
        {
            string connectionString = "Data Source=UserLogin.db;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "SELECT COUNT(*) FROM Users WHERE Login = @username AND Password = @password";
                    //command.CommandText = "SELECT COUNT(*) FROM Admins WHERE Login = @username AND Password = @password";
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    long count = (long)command.ExecuteScalar();
                    if (count > 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Закрытие подключения к базе данных при закрытии формы
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            Application.Exit();
        }

        
    }
}

    
