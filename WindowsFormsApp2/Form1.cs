using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        private string 
            connectionString = "server=localhost;port=3306;username=root;password=qwerty123456",
            sqlCommandText,
            loginText,
            passwordText;

        private MySqlConnection sqlConnection;

        private MySqlCommand command;

        private int userId;

        public Login()
        {
            InitializeComponent();
            sqlConnection = new MySqlConnection(connectionString);
            command = sqlConnection.CreateCommand();
            sqlConnection.Open();   
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            sqlCommandText = 
                    $"INSERT game_data.user (name,login,pass)" +
                    $"VALUES ('{loginText}','{loginText}','{passwordText}');";
                command.CommandText = sqlCommandText;
                command.ExecuteNonQuery();

            labelError.Text = "You have been signed up";
            buttonSignUp.Visible = false;
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            labelError.Text = "";

            if (textBoxLogin.Text == string.Empty)
            {
                labelError.Text = "Login field is empty";
            }

            else
            {
                loginText = textBoxLogin.Text;
            }

            if (textBoxPassword.Text == string.Empty)
            {
                if (labelError.Text != string.Empty)
                {
                    labelError.Text += "\n";
                }
                labelError.Text += "Password field is empty";
            }

            else
            {
                passwordText = textBoxPassword.Text;
            }

            if (labelError.Text != string.Empty)
            {
                return;
            }

            searchLoginAndPass();
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void labelError_SizeChanged(object sender, EventArgs e)
        {
            labelError.Left = 175 - (labelError.Width / 2);
        }

        private void searchLoginAndPass()
        {
            sqlCommandText =
                $"SELECT * FROM game_data.user WHERE login = '{loginText}' " +
                $"AND pass = '{passwordText}'";
            command.CommandText = sqlCommandText;

            using (DbDataReader reader = command.ExecuteReader())
            {
                if (!reader.HasRows)
                {
                    labelError.Text = "Wrong login or password";
                    buttonSignUp.Visible = true;
                    reader.Close();
                    return;
                }
                reader.Read();

                userId = reader.GetInt32(0);

                Hide();
                reader.Close();
                Main f2 = new Main(sqlConnection, userId);
                f2.ShowDialog();
                sqlConnection.Close();
                sqlConnection.Dispose();
                Close();
            }
        }
    }

}
