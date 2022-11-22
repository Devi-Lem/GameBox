using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Profile : Form
    {

        private About f3;

        private MySqlConnection sqlConnection;

        private MySqlCommand command;

        private int 
            userId,
            gameId,
            cycleCount = 0,
            gameCoverWidth;

        private string sqlCommandText;

        private List<int> likedGames = new List<int>();

        private List<Bitmap> gameCoversList = new List<Bitmap>();

        private List<PictureBox> gamesList = new List<PictureBox>();

        private Main f2;

        public bool initalized = false;
        public Profile ()
        {
            InitializeComponent ();
        }

        public Profile(MySqlConnection sqlConnection, int userId, List<Bitmap> gameCoversList, Main f2)
        {
            InitializeComponent();
            this.sqlConnection = sqlConnection;
            command = sqlConnection.CreateCommand();
            this.userId = userId;   
            this.gameCoversList = gameCoversList;
            this.f2 = f2;
            initalized = true;

            loadUserName();
            getLikedGames();
            addGames();
        }
        private void getLikedGames()
        {
            likedGames.Clear();
            sqlCommandText =
                $"SELECT id_game FROM game_data.user_choice" +
                $" WHERE id_user = {userId};";
            command.CommandText = sqlCommandText;
            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        likedGames.Add(reader.GetInt32(0));
                    }
                }
            }
        }

        private void loadUserName()
        {
            sqlCommandText = $"SELECT name FROM game_data.user WHERE id = {userId}";

            command.CommandText = sqlCommandText;

            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    labelUsername.Text = $"Username: {reader.GetString(0)}";
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox obj = (PictureBox)sender;
            f3 = new About(obj.BackgroundImage, (int)obj.Tag, sqlConnection, userId, true, f2, this);

            f3.TopLevel = false;
            panelWorkspace.Controls.Add(f3);
            f3.Dock = DockStyle.Fill;
            f3.BringToFront();
            f3.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            f2.makeProfileButtonVisible();
            Close();

        }

        private async Task addGames()
        {
            sqlCommandText = $"SELECT * FROM game_data.main WHERE id IN (";
            for (int i = 0; i < likedGames.Count; i++)
            {
                sqlCommandText += Convert.ToString(likedGames[i]);
                if (i == likedGames.Count - 1)
                {
                    continue;
                }
                sqlCommandText += ", ";
            }
            sqlCommandText += ")";

            command.CommandText = sqlCommandText;

            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        gameId = Convert.ToInt32(reader.GetValue(0)) - 1;

                        if (cycleCount == 0)
                        {
                            pictureBox1.BackgroundImage = gameCoversList[gameId];
                            pictureBox1.Tag = gameId;
                            gamesList.Add(pictureBox1);
                            cycleCount++;
                            continue;
                        }

                        PictureBox pictureBox = new PictureBox();

                        pictureBox.BackColor = pictureBox1.BackColor;
                        pictureBox.BackgroundImage = gameCoversList[gameId];
                        pictureBox.BackgroundImageLayout = ImageLayout.Stretch;

                        pictureBox.Name = $"{gameId + 1}";
                        pictureBox.Tag = gameId;

                        pictureBox.Location = pictureBox1.Location;
                        pictureBox.Margin = pictureBox1.Margin;
                        pictureBox.Padding = pictureBox1.Padding;
                        pictureBox.Size = pictureBox1.Size;
                        pictureBox.Anchor = pictureBox1.Anchor;

                        pictureBox.Click += pictureBox1_Click;

                        panelGameDisplay.Controls.Add(pictureBox);
                        gamesList.Add(pictureBox);
                        cycleCount++;
                    }
                }
            }
            cycleCount = 0;
        }

        public void updateGameList()
        {
            int count = panelGameDisplay.Controls.Count - 1;
            for (int i = count; i > 0; i--)
            {
                panelGameDisplay.Controls.RemoveAt(i);
            }

            getLikedGames();
            addGames();
        }

        private async Task changeGameCoverSize()
        {
            if (panelGameDisplay.Width >= 1450)
            {
                await Task.Run(() =>
                {
                    foreach (PictureBox pictureBox in gamesList)
                    {
                        SetGameCoverSize(pictureBox, 250, 375);
                    }

                });
                return;
            }

            if (panelGameDisplay.Width >= 1100)
            {
                await Task.Run(() =>
                {
                    foreach (PictureBox pictureBox in gamesList)
                    {
                        SetGameCoverSize(pictureBox, 200, 300);
                    }
                });
                return;
            }
            if (panelGameDisplay.Width >= 0)
            {
                await Task.Run(() =>
                {
                    foreach (PictureBox pictureBox in gamesList)
                    {
                        SetGameCoverSize(pictureBox, 150, 225);
                    }
                });
                return;
            }
        }

        private async void Form4_ResizeBegin(object sender, EventArgs e)
        {
            await changeGameCoverSize();
        }

        private async void Form4_ResizeEnd(object sender, EventArgs e)
        {
            await changeGameCoverSize();
            await changeGamesCoversColums();

        }

        private async void Form4_Resize(object sender, EventArgs e)
        {
            await changeGameCoverSize();
            await changeGamesCoversColums();
        }

        delegate void SetGameCoverSizeCallback(PictureBox button, int width, int height);

        private void SetGameCoverSize(PictureBox pictureBox, int width, int height)
        {
            if (panelGameDisplay.InvokeRequired)
            {
                SetGameCoverSizeCallback d = new SetGameCoverSizeCallback(SetGameCoverSize);
                Invoke(d, new object[] { pictureBox, width, height });
            }
            else
            {
                pictureBox.Size = new Size(width, height);
            }
        }

        private async Task changeGamesCoversColums(int amount = 3)
        {
            gameCoverWidth = pictureBox1.Width;
            //await Task.Run(() =>
            //{
            for (int i = 0; i < amount; i++)
            {
                if (panelGameDisplay.GetColumnWidths()[0] > gameCoverWidth * 2 - (gameCoverWidth / 100) * 50)
                {
                    panelGameDisplay.ColumnCount++;
                    panelGameDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, panelGameDisplay.ColumnStyles[0].Width));

                }
                if (panelGameDisplay.GetColumnWidths()[0] <= gameCoverWidth + 20)
                {
                    panelGameDisplay.ColumnCount--;
                    panelGameDisplay.ColumnStyles.RemoveAt(panelGameDisplay.ColumnCount);
                }
                double rowCount = (double)gamesList.Count / panelGameDisplay.ColumnCount;
                panelGameDisplay.RowCount = (int)Math.Ceiling(rowCount);
                Refresh();
            }
            //});
        }
    }
}
