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
    public partial class About : Form
    {
        private int idOfGame;

        private MySqlConnection sqlConnection;

        private MySqlCommand command;

        private string 
            sqlCommandText,
            gameName,
            gameGenre,
            gameDate,
            gameDeveloper,
            gameAge,
            gamePlatform,
            gameStores;

        private int userId;

        public bool liked ;

        private Main f2;

        private Profile f4;

        public About()
        {
            InitializeComponent();
        }

        public About(Image imageOfGame, int idOfGame, MySqlConnection sqlConnection, int userId, bool liked, Main f2, Profile f4)
        {
            InitializeComponent();
            pictureBox1.BackgroundImage = imageOfGame;
            this.idOfGame = idOfGame+1;    
            this.sqlConnection = sqlConnection;
            this.userId = userId;
            this.liked = liked;
            this.f2 = f2;
            this.f4 = f4;
            command = sqlConnection.CreateCommand();

            if (liked)
            {
                buttonLike.ImageIndex = 1;

            }
            loadGameProperties();
        }
        private void buttonLike_Click(object sender, EventArgs e)
        {
            if (liked == false)
            {
                liked = true;
                buttonLike.ImageIndex = 1;
            }
            else
            {
                liked = false;
                buttonLike.ImageIndex = 0;  
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (liked == true)
            {
                sqlCommandText = 
                    $"INSERT game_data.user_choice (id_user,id_game,game_dev,game_genre)" +
                    $"VALUES ({userId},{idOfGame},'{gameDeveloper}','{gameGenre}');";
                command.CommandText = sqlCommandText;
                command.ExecuteNonQuery();
            }
            else
            {
                sqlCommandText = 
                    $"DELETE FROM game_data.user_choice " +
                    $"WHERE id_user = {userId} AND id_game = {idOfGame};";
                command.CommandText = sqlCommandText;
                command.ExecuteNonQuery();
            }
            f2.updateGameList();
            if (f4.initalized)
            {
                f4.updateGameList();
            }
            Close();
        }

        private void loadGameProperties()
        {
            sqlCommandText = $"SELECT * FROM game_data.main WHERE id = {idOfGame};";
            command.CommandText = sqlCommandText;

            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Read();

                    gameName = reader.GetString(1);
                    gameGenre = reader.GetString(2);
                    gameDate = reader.GetString(3);
                    gameDeveloper = reader.GetString(4);
                    gameAge = reader.GetString(5);
                    gamePlatform = reader.GetString(6);
                    gameStores = reader.GetString(7);

                    labelName.Text = $"Name: {gameName}";
                    labelGener.Text = $"Genr: {gameGenre}";
                    labelDate.Text = $"Date: {gameDate}";
                    labelDeveloper.Text = $"Developer: {gameDeveloper}";
                    labelAge.Text = $"Age: {gameAge}";
                    labelPlatform.Text = $"Platform: {gamePlatform}";
                    labelStores.Text = $"Stores: {gameStores}";
                }
            }
        }
    }
}
