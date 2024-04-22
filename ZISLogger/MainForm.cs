using BotTemplait;
using System.Text.Json;
using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Diagnostics;

namespace ZISLogger
{
    public partial class MainForm : Form
    {
        private static List<TableLine> lines = new List<TableLine>();
        public static Config config;
        public static User user;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Crypt.Key = Encoding.UTF8.GetBytes("0123456789abcdef"); //по хорошему должен быть в secret
            Crypt.IV = Encoding.UTF8.GetBytes("1234567890abcdef"); //по хорошему должен каждый раз генерироваться
                                                                   //но это гемор
            config = JsonSerializer.Deserialize<Config>(File.ReadAllText("config.json"));
            DataBase.connectionString = config.mysql;
            var auth = new AuthForm();
            auth.ShowDialog();

        }


        public void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel2.Location = new Point(0, -panel2.Size.Height / 110 * e.NewValue);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            var stats = new Color[] { Color.Green, Color.Yellow, Color.Red };
            if (user != null && user.Status == "admin")
            {
                var reader = DataBase.ReadMultiline("select * from logs");
                panel2.Size = new Size(panel2.Size.Width, 23 * reader.Length);
                var encData = new string[reader.Length];
                var watcher = new Stopwatch();
                watcher.Start();
                for (int i = 0; i < reader.Length; i++)
                    encData[i] = Crypt.DecryptStringFromBytes_Aes(Convert.FromBase64String(reader[i][2].ToString()));
                watcher.Stop();
                encTime.Text = $"Decryption time: {watcher.Elapsed.TotalMilliseconds}";
                for (int i = 0; i < reader.Length; i++)
                {
                    var line = new TableLine();
                    line.idBox.Text = reader[i][0].ToString();
                    line.datetimeBox.Text = reader[i][1].ToString();
                    line.contentBox.Text = encData[i];
                    line.statusPanel.BackColor = stats[(int)reader[i][3] - 1];
                    line.Dock = DockStyle.Bottom;
                    panel2.Controls.Add(line);
                    lines.Add(line);
                }
            }
            else
            {
                mainTab.Controls.Remove(logPage);
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            try 
            { 
                Crypt.Key = Encoding.UTF8.GetBytes(keyBox.Text);
                Crypt.IV = Encoding.UTF8.GetBytes(ivBox.Text);
                var watcher = new Stopwatch();
                watcher.Start();
                encryptBox.Text = Convert.ToBase64String(Crypt.EncryptStringToBytes_Aes(decryptBox.Text));
                watcher.Stop();
                encTime.Text = $"Encryption time: {watcher.Elapsed.TotalMilliseconds}";
                incorrectDataLabel.Visible = false;
            }
            catch (Exception ex)
            {
                incorrectDataLabel.Visible = true;
                incorrectDataLabel.Text = ex.Message;
                DataBase.Log("Info: "+ex.Message,1);
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                Crypt.Key = Encoding.UTF8.GetBytes(keyBox.Text);
                Crypt.IV = Encoding.UTF8.GetBytes(ivBox.Text);
                var watcher = new Stopwatch();
                watcher.Start();
                decryptBox.Text = Crypt.DecryptStringFromBytes_Aes(Convert.FromBase64String(encryptBox.Text));
                watcher.Stop();
                encTime.Text = $"Decryption time: {watcher.Elapsed.TotalMilliseconds}";
                incorrectDataLabel.Visible = false;
            }
            catch (Exception ex)
            {
                incorrectDataLabel.Visible = true;
                incorrectDataLabel.Text = ex.Message;
                DataBase.Log("Info: " + ex.Message, 1);
            }

        }
    }
}
