using System;
using System.Data;
//using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace ScientistConferension
{
    public partial class Scientist : Form
    {
        private SQLiteConnection connection;
        private string username;

        public Scientist(string username)
        {
            InitializeComponent();
            confDgv.Hide();
            showDgv.Hide();
            //yearDgv.Hide();
            this.username = username;

            if (username == "user")
            {
                dataGridView1.ReadOnly = false;
                confDgv.ReadOnly = false;
                showDgv.ReadOnly = false;
            }
            else
            {
                dataGridView1.ReadOnly = true;
                confDgv.ReadOnly = true;
                showDgv.ReadOnly = true;
            }

            // Инициализация подключения к базе данных scienty.db
            string scientistDbPath = "scienty.db";
            bool createScientistTable = false;

            if (!System.IO.File.Exists(scientistDbPath))
            {
                createScientistTable = true;
                SQLiteConnection.CreateFile(scientistDbPath);
            }

            connection = new SQLiteConnection($"Data Source={scientistDbPath};");
            connection.Open();

            if (createScientistTable)
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS scientist (idSc INTEGER PRIMARY KEY, nameSc TEXT, orgSc TEXT, countrySc TEXT, degreeSc TEXT);";
                    cmd.ExecuteNonQuery();

                    // Вставляем начальные данные в таблицу Scientist
                    InsertInitialScientistData(cmd);
                }
            }
            // Загрузка данных из Scientist в DataGridView
            LoadScientistDataToDataGridView();


            string conferentionDbPath = "scienty.db";
            bool createConferentionTable = false;

            if (!System.IO.File.Exists(conferentionDbPath))
            {
                createConferentionTable = true;
                SQLiteConnection.CreateFile(conferentionDbPath);
            }

            connection = new SQLiteConnection($"Data Source={conferentionDbPath};");
            connection.Open();

            if (createConferentionTable)
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS conferention (idConf INTEGER PRIMARY KEY, nameConf TEXT, placeConf TEXT, dateConf DATE);";
                    cmd.ExecuteNonQuery();

                    // Вставляем начальные данные в таблицу Scientist
                    InsertInitialConferentionData(cmd);
                }
            }
            LoadConferentionDataToDataGridView();

            string showDbPath = "scienty.db";
            bool createShowTable = false;

            if (!System.IO.File.Exists(showDbPath))
            {
                createShowTable = true;
                SQLiteConnection.CreateFile(showDbPath);
            }

            connection = new SQLiteConnection($"Data Source={showDbPath};");
            connection.Open();

            if (createShowTable)
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS show (idConf INTEGER PRIMARY KEY, idSc INTEGER PRIMARY KEY, type TEXT, theme TEXT, publish TEXT);";
                    cmd.ExecuteNonQuery();

                    // Вставляем начальные данные в таблицу Scientist
                    InsertInitialShowData(cmd);
                }
            }
            LoadShowDataToDataGridView();
        }

        // Метод для вставки начальных данных в таблицу Scientist
        private void InsertInitialScientistData(SQLiteCommand cmd)
        {
            string[] initialName = {
                "Сергей Одинцов", "Рашид Сюняев", "Жорес Алферов", "Патрисия Дали", "Давид Обрамович Додин", "Минина Юлия Константиновна"
            };

            string[] initialOrg = {
                "Томский Государственный Педагогический Университет", "Институт космических исследований РАН", "Ленинградский физико-технический институт", "Дартмутский колледж ", "ВНИИОкеанология", "ИТЭУП УПС"
            };

            string[] initialCountry = {
                "Россия", "Россия", "Россия", "Великобритания", "Россия", "Россия"
            };

            string[] initialDegree = {
                "Доктор наук", "Ученый-астрофизик", "Ученый-физик", "Доктор философии по социологии", "Доктор наук", "Ученый"
            };

            for (int i = 0; i < initialName.Length; i++)
            {
                cmd.CommandText = "INSERT INTO scientist (nameSc, orgSc, countrySc, degreeSc) VALUES (@Name, @Org, @Country, @Degree);";
                cmd.Parameters.AddWithValue("@Name", initialName[i]);
                cmd.Parameters.AddWithValue("@Org", initialOrg[i]);
                cmd.Parameters.AddWithValue("@Country", initialCountry[i]);
                cmd.Parameters.AddWithValue("@Degree", initialDegree[i]);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
        } 

        private void LoadScientistDataToDataGridView()
        {
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM scientist", connection))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Устанавливаем источник данных для DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }

            // Установите ширину каждого столбца в DataGridView
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }

        // Метод для вставки начальных данных в таблицу Conf
        private void InsertInitialConferentionData(SQLiteCommand cmd)
        {
            string[] initialName = {
                "«Космология»", "«Спектр-Рентген-Гамма»", "«Современные проблемы фундаментальных и прикладных наук»", "«Беженцы и отсталость в Африке»", "«Магматические комплексы северо-запада Сибирской платформы и их никеленосность»", "«Первые шаги в SQL»"
            };

            string[] initialPlace = {
                "Томский Государственный Педагогический Университет", "Кафедра астрономии и космической геодезии КФУ", "МФТИ", "Оксфордский Университет", "ФГБУ «ВНИИОкеангеология»", "ИТЭУП УПС"
            };

            string[] initialDate = {
                "15-09-2016", "02-08-2017", "30-11-1999", "01-09-1999", "25-04-1999", "27-07-1999"
            };


            for (int i = 0; i < initialName.Length; i++)
            {
                cmd.CommandText = "INSERT INTO conferention (nameConf, placeConf, dateConf) VALUES (@Name, @Place, @Date);";
                cmd.Parameters.AddWithValue("@Name", initialName[i]);
                cmd.Parameters.AddWithValue("@Place", initialPlace[i]);
                cmd.Parameters.AddWithValue("@Date", initialDate[i]);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
        }

        private void LoadConferentionDataToDataGridView()
        {
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM conferention", connection))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Устанавливаем источник данных для DataGridView
                    confDgv.DataSource = dataTable;
                }
            }

            // Установите ширину каждого столбца в DataGridView
            confDgv.Columns[0].Width = 50;
            confDgv.Columns[1].Width = 250;
            confDgv.Columns[2].Width = 180;
            confDgv.Columns[3].Width = 100;
            confDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            confDgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }

        // Метод для вставки начальных данных в таблицу Show
        private void InsertInitialShowData(SQLiteCommand cmd)
        {
            string[] initialType = {
                "доклад", "доклад", "доклад", "доклад", "доклад", "сообщение"
            };

            string[] initialTheme = {
                "«Что называется космологией»", "«Спектр-Рентген-Гамма»", "«Полупроводниковые гетероструктуры — основа развития современной электроники и высокоэффективной энергетики»", "«Беженцы и отсталость в Африке: случай беженцев Барунди в Танзании»", "«Магматические комплексы северо-запада Сибирской платформы и их никеленосность»", "«Создание SQL запросов»"
            };

            string[] initialPublish = {
                "нет", "нет", "да", "да", "да", "нет"
            };


            for (int i = 0; i < initialType.Length; i++)
            {
                cmd.CommandText = "INSERT INTO conferention (nameConf, placeConf, dateConf) VALUES (@Type, @Theme, @Publish);";
                cmd.Parameters.AddWithValue("@Type", initialType[i]);
                cmd.Parameters.AddWithValue("@Theme", initialTheme[i]);
                cmd.Parameters.AddWithValue("@Publish", initialPublish[i]);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
        }

        private void LoadShowDataToDataGridView()
        {
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM show", connection))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Устанавливаем источник данных для DataGridView
                    showDgv.DataSource = dataTable;
                }
            }

            // Установите ширину каждого столбца в DataGridView
            showDgv.Columns[0].Width = 50;
            showDgv.Columns[1].Width = 50;
            showDgv.Columns[2].Width = 120;
            showDgv.Columns[3].Width = 250;
            showDgv.Columns[4].Width = 100;
            showDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            showDgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }

        private async void yearBtn_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("SELECT nameSc, publish, dateConf FROM show INNER JOIN scientist ON scientist.idSc=show.idSc INNER JOIN conferention ON conferention.idConf=show.idConf WHERE publish='да' ", connection);
            DataSet ds = new DataSet();

            dataadapter.Fill(ds, "conferention");
            confDgv.DataSource = ds.Tables[0];
            confDgv.Show();

            confDgv.Columns[0].Width = 150;
            confDgv.Columns[1].Width = 50;
            confDgv.Columns[2].Width = 120;

        }

        private void notPublishBtn_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("SELECT conferention.nameConf FROM conferention LEFT JOIN show ON conferention.idConf=show.idConf AND show.publish = 'да' WHERE show.publish IS NULL;", connection);
            DataSet ds = new DataSet();

            dataadapter.Fill(ds, "show");
            confDgv.DataSource = ds.Tables[0];
            confDgv.Show();

            confDgv.Columns[0].Width = 150;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("SELECT conferention.nameConf, COUNT(*) as degreeSc FROM conferention JOIN show ON conferention.idConf = show.idConf JOIN scientist ON show.idSc = scientist.idSc WHERE scientist.degreeSc = 'Доктор наук' GROUP BY conferention.idConf, conferention.nameConf ORDER BY degreeSc DESC;", connection);
            DataSet ds = new DataSet();

            dataadapter.Fill(ds, "scienty");
            confDgv.DataSource = ds.Tables[0];
            confDgv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("SELECT conferention.nameConf, COUNT(DISTINCT scientist.countrySc) AS countrySc FROM conferention JOIN show ON conferention.idConf = show.idConf JOIN scientist ON show.idSc = scientist.idSc GROUP BY conferention.idConf, conferention.nameConf;", connection);
            DataSet ds = new DataSet();

            dataadapter.Fill(ds, "show");
            confDgv.DataSource = ds.Tables[0];
            confDgv.Show();

        }

        private void конференцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            confDgv.Show();
            dataGridView1.Hide();
            showDgv.Hide();

        }

        private void учёныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            showDgv.Hide();
            confDgv.Hide();
        }

        private void выступленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showDgv.Show();
            confDgv.Hide();
            dataGridView1.Hide();

        }

        private void scientist_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Запускаем нужный файл
                System.Diagnostics.Process.Start("user_guide.docx");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        
    }
}

    

