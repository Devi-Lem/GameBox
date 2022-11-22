using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Main : Form
    {
        private int 
            borderSize = 2, 
            gameCoverWidth,
            gameId,
            cycleCount = 0,
            userId;

        private Size formSize;

        private List<Button> buttonList = new List<Button>();
            
        private List<PictureBox> gamesList = new List<PictureBox>();

        private List<Bitmap> gameCoversList = new List<Bitmap>();
        
        private List<int> likedGames = new List<int>();

        private bool grow; 

        private About f3 = new About();
        
        private Profile f4 = new Profile();

        private MySqlConnection sqlConnection;

        private MySqlCommand command;
        
        private string 
            sqlCommandText, 
            sqlCommandText2,
            gameDevTemp,
            gameGenerTemp;

        public Main(MySqlConnection sqlConnection, int userId)
        {
            InitializeComponent();
            this.sqlConnection = sqlConnection;
            command = this.sqlConnection.CreateCommand();
            DoubleBuffered = true;
            this.userId = userId;

            Padding = new Padding(borderSize);
            BackColor = Color.FromArgb(116, 43, 194);
            SetStyle(ControlStyles.ResizeRedraw, true);

            getLikedGames();
            addButtonToList();
            Collapse();
            loadGameCovers();
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

        public void loadGameCovers()
        {
            gameCoversList.Add(Properties.Resources.assasinsCreed);
            gameCoversList.Add(Properties.Resources.assasinsCreed2);
            gameCoversList.Add(Properties.Resources.assasinsCreedBrotherhood);
            gameCoversList.Add(Properties.Resources.assasinsCreedAltairsChronicles);
            gameCoversList.Add(Properties.Resources.assasinsCreedRevelations);
            gameCoversList.Add(Properties.Resources.assasinsCreed3);
            gameCoversList.Add(Properties.Resources.assasinsCreed3Liberation);
            gameCoversList.Add(Properties.Resources.assasinsCreed4BlackFlag);
            gameCoversList.Add(Properties.Resources.assasinsCreedUnity);
            gameCoversList.Add(Properties.Resources.assasinsCreedRouge);
            gameCoversList.Add(Properties.Resources.assasinsCreedSyndicate);
            gameCoversList.Add(Properties.Resources.assasinsCreedOrigins);
            gameCoversList.Add(Properties.Resources.assasinsCreedOdyssey);
            gameCoversList.Add(Properties.Resources.assasinsCreedValhalla);
            gameCoversList.Add(Properties.Resources.farCry);
            gameCoversList.Add(Properties.Resources.farCryInstincts);
            gameCoversList.Add(Properties.Resources.farCry2);
            gameCoversList.Add(Properties.Resources.farCry3);
            gameCoversList.Add(Properties.Resources.farCry3BloodDragon);
            gameCoversList.Add(Properties.Resources.farCry4);
            gameCoversList.Add(Properties.Resources.farCryPrimal);
            gameCoversList.Add(Properties.Resources.farCry5);
            gameCoversList.Add(Properties.Resources.farCryNewDawn);
            gameCoversList.Add(Properties.Resources.farCry6);
            gameCoversList.Add(Properties.Resources.forHonor);
            gameCoversList.Add(Properties.Resources.tomClancysRainbowSixSiege);
            gameCoversList.Add(Properties.Resources.tomClancysTheDivision);
            gameCoversList.Add(Properties.Resources.gta2);
            gameCoversList.Add(Properties.Resources.gta3);
            gameCoversList.Add(Properties.Resources.gtaSanAndreas);
            gameCoversList.Add(Properties.Resources.gtaLibertyCityStories);
            gameCoversList.Add(Properties.Resources.gta4);
            gameCoversList.Add(Properties.Resources.redDeadRevolverpng);
            gameCoversList.Add(Properties.Resources.rdr);
            gameCoversList.Add(Properties.Resources.gta5);
            gameCoversList.Add(Properties.Resources.gtaOnline);
            gameCoversList.Add(Properties.Resources.rdr2);
            gameCoversList.Add(Properties.Resources.rdrOnline);
            gameCoversList.Add(Properties.Resources.nfsMostWanted05);
            gameCoversList.Add(Properties.Resources.battlefield3);
            gameCoversList.Add(Properties.Resources.crysis2);
            gameCoversList.Add(Properties.Resources.battlefield4);
            gameCoversList.Add(Properties.Resources.crysis3);
            gameCoversList.Add(Properties.Resources.theSims4);
            gameCoversList.Add(Properties.Resources.battlefield1);
            gameCoversList.Add(Properties.Resources.nfsPayback);
            gameCoversList.Add(Properties.Resources.starWarsBattlefront2);
            gameCoversList.Add(Properties.Resources.fifa21);
            gameCoversList.Add(Properties.Resources.halfLife);
            gameCoversList.Add(Properties.Resources.counterStrike);
            gameCoversList.Add(Properties.Resources.counterStrikeSource);
            gameCoversList.Add(Properties.Resources.halfLife2);
            gameCoversList.Add(Properties.Resources.garrysMod);
            gameCoversList.Add(Properties.Resources.teamFortress2);
            gameCoversList.Add(Properties.Resources.portal);
            gameCoversList.Add(Properties.Resources.lead4Dead);
            gameCoversList.Add(Properties.Resources.lead4Dead2);
            gameCoversList.Add(Properties.Resources.portal2);
            gameCoversList.Add(Properties.Resources.counterStrikeGlobalOffensive);
            gameCoversList.Add(Properties.Resources.dota2);
            gameCoversList.Add(Properties.Resources.warcraft);
            gameCoversList.Add(Properties.Resources.diablo);
            gameCoversList.Add(Properties.Resources.starcraft);
            gameCoversList.Add(Properties.Resources.diablo2);
            gameCoversList.Add(Properties.Resources.wow);
            gameCoversList.Add(Properties.Resources.diablo3);
            gameCoversList.Add(Properties.Resources.hearthstone);
            gameCoversList.Add(Properties.Resources.heroesOfTheStorm);
            gameCoversList.Add(Properties.Resources.overwatch);
            gameCoversList.Add(Properties.Resources.halo3);
            gameCoversList.Add(Properties.Resources.forzaHorizon4);
            gameCoversList.Add(Properties.Resources.seaOfThieves);
            gameCoversList.Add(Properties.Resources.grounded);
            gameCoversList.Add(Properties.Resources.ori);
            gameCoversList.Add(Properties.Resources.bleedingEdge);
            gameCoversList.Add(Properties.Resources.gearsTactics);
            gameCoversList.Add(Properties.Resources.haloInfinite);
            gameCoversList.Add(Properties.Resources.forzaHorizon5);
            gameCoversList.Add(Properties.Resources.ageOfEmpires4);
            gameCoversList.Add(Properties.Resources.ctr);
            gameCoversList.Add(Properties.Resources.jak3);
            gameCoversList.Add(Properties.Resources.theLastOfUs);
            gameCoversList.Add(Properties.Resources.uncharted2);
            gameCoversList.Add(Properties.Resources.uncharted3);
            gameCoversList.Add(Properties.Resources.theLastOfUs2);
            gameCoversList.Add(Properties.Resources.uncharted4);
            gameCoversList.Add(Properties.Resources.unchartedTheLostLegacy);
            gameCoversList.Add(Properties.Resources.jakX);
            gameCoversList.Add(Properties.Resources.Jak2);
        }

        private void addButtonToList()
        {
            buttonList.Add(buttonProfile);
            buttonList.Add(buttonLogout);
        }

        private void addGames()
        {
            sqlCommandText = "SELECT * FROM game_data.main ";

            if (likedGames.Count > 0)
            {
                sqlCommandText += $"WHERE id NOT IN(";
                for (int i = 0; i < likedGames.Count; i++)
                {
                    sqlCommandText += Convert.ToString(likedGames[i]);
                    if (i == likedGames.Count - 1)
                    {
                        continue;
                    }
                    sqlCommandText += ", ";
                }
                sqlCommandText += ") ORDER BY";

                sqlCommandText2 =
                    "SELECT game_dev, COUNT(*) AS dev_count " +
                    "FROM game_data.user_choice " +
                    $"where id_user = {userId} " +
                    "group by game_dev " +
                    "order by dev_count desc";


                command.CommandText = sqlCommandText2;

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            gameDevTemp = Convert.ToString(reader.GetValue(0));
                            sqlCommandText += $" dev = '{gameDevTemp}' desc,";
                        }
                    }
                }

                sqlCommandText2 =
                   "SELECT game_genre, COUNT(*) AS genre_count " +
                   "FROM game_data.user_choice " +
                   $"where id_user = {userId} " +
                   "group by game_genre " +
                   "order by genre_count desc";

                command.CommandText = sqlCommandText2;

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            gameGenerTemp = Convert.ToString(reader.GetValue(0));
                            sqlCommandText += $" genre like '%{gameGenerTemp}%' desc,";
                        }
                    }
                }
                sqlCommandText = sqlCommandText.Remove(sqlCommandText.Length - 1);
            }

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
                            gamesList.Add(pictureBox1);
                            pictureBox1.Tag = gameId;
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

        #region Control Panel

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void controlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                buttonMaximize.BackgroundImage = Properties.Resources.Fullscreen;
                formSize = ClientSize;
                Padding = new Padding(9);
                pictureBoxLogo.Left = 8;
                pictureBoxLogo.Top = 8;
                WindowState = FormWindowState.Maximized;

            }
            else
            {
                buttonMaximize.BackgroundImage = Properties.Resources.Maximize;
                Padding = new Padding(borderSize);
                pictureBoxLogo.Left = 0;
                pictureBoxLogo.Top = 0;
                WindowState = FormWindowState.Normal;
                Size = formSize;
            }
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Side Menu

        private async void buttonCollapseMenu_Click(object sender, EventArgs e)
        {
            await Collapse();
        }

        private async Task Collapse()
        {
            int speed = 5; // speed of collapsing

            if (panelMenu.Width >= 110) // if not collapsed
            {
                await Task.Run(() =>
                {
                    for (int i = 110; i >= 25; i -= speed) // shrinking menu
                    {
                        grow = false;
                        moveMenuPanel(i);
                    }

                    buttonCollapseMenu.Image = Properties.Resources.MenuButton;
                    foreach (Button button in buttonList)
                        button.ImageAlign = ContentAlignment.MiddleCenter; // correcting buttons images
                });
            }
            else // if collapsed
            {
                await Task.Run(() =>
                {
                    foreach (Button button in buttonList)
                        button.ImageAlign = ContentAlignment.MiddleLeft; // correcting buttons images

                    for (int i = 25; i <= 110; i += speed) // expanding menu
                    {
                        grow = true;
                        moveMenuPanel(i);
                    }

                    buttonCollapseMenu.Image = Properties.Resources.Return;
                });
            }
        }

        private void moveMenuPanel(int i)
        {
            SetPanelSize(i); // change panel size
            SetLocationButton(i); // change collapse button position
            if (grow == true || pictureBoxLogo.Width != 25) 
                SetImageSize(i); // change logo size and move label
            foreach (Button button in buttonList)
                SetSizeButton(i, button); // change menu buttons size
        }

        delegate void SetLocationCallback(int i);

        delegate void SetSizeCallback(int i, Button button);

        private void SetLocationButton(int i)
        {
            if (buttonCollapseMenu.InvokeRequired)
            {
                SetLocationCallback d = new SetLocationCallback(SetLocationButton);
                Invoke(d, new object[] { i });
            }
            else
            {
                buttonCollapseMenu.Left = i - 25; // move buttons acording to menu
            }
        }

        private void SetPanelSize(int i)
        {
            if (panelMenu.InvokeRequired)
            {
                SetLocationCallback d = new SetLocationCallback(SetPanelSize);
                Invoke(d, new object[] { i });
            }
            else
            {
                panelMenu.Width = i;
                panelMenu.Refresh();
            }
        }

        private void SetImageSize(int i)
        {
            if (pictureBoxLogo.InvokeRequired && label1.InvokeRequired)
            {
                foreach (Button button in buttonList)
                    if (button.InvokeRequired)
                    {
                        SetLocationCallback d = new SetLocationCallback(SetImageSize);
                        Invoke(d, new object[] { i });
                    }
            }
            else
            {
                if (i <= 85)
                {
                    pictureBoxLogo.Width = i;
                    pictureBoxLogo.Height = i;
                }

                label1.Left = i;

                foreach (Button button in buttonList)
                {
                    if (grow)
                        button.Top++;
                    else
                        button.Top--;
                }
            }
        }

        private async void button_MouseHover(object sender, EventArgs e)
        {
            await showButton(sender as Button);
        }

        private async void button_MouseLeave(object sender, EventArgs e)
        {
            await hideButton(sender as Button);
        }

        private async Task showButton(Button button)
        {
            if (panelMenu.Width == 25) // if button is minimized
            {
                await Task.Run(() =>
                {
                    button.ImageAlign = ContentAlignment.MiddleLeft;

                    for (int i = 25; i <= 110; i += 1) // increase button size
                        SetSizeButton(i, button);

                });
            }
        }

        private async Task hideButton(Button button)
        {
            if (panelMenu.Width == 25 && button.Width >= 26) // if button is maximized
            {
                await Task.Run(() =>
                {

                    for (int i = 110; i >= 25; i -= 1) // decrease button size
                        SetSizeButton(i, button);

                });

                button.ImageAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void SetSizeButton(int i, Button button)
        {
            if (buttonCollapseMenu.InvokeRequired)
            {
                SetSizeCallback d = new SetSizeCallback(SetSizeButton);
                Invoke(d, new object[] { i, button });
            }
            else
            {
                button.Width = i;
            }
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            f4 = new Profile(sqlConnection, userId, gameCoversList, this);

            f4.TopLevel = false;
            f4.Dock = DockStyle.Fill;
            panelWorkspace.Controls.Add(f4);
            f4.BringToFront();
            f4.Show();

            buttonProfile.Visible = false;
        }

        public void makeProfileButtonVisible()
        {
            buttonProfile.Visible = true;   
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Login f1 = new Login();
            Hide();
            f1.ShowDialog();
            Close();
        }
        #endregion

        #region Form Resize
        protected override void WndProc(ref Message message)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            if (message.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref message);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)message.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(message.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize)//If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                            {
                                message.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            }
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                            {
                                message.Result = (IntPtr)HTTOP; //Resize vertically up
                            }
                            else //Resize diagonally to the right
                            {
                                message.Result = (IntPtr)HTTOPRIGHT;
                            }
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                            {
                                message.Result = (IntPtr)HTLEFT;
                            }
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                            {
                                message.Result = (IntPtr)HTRIGHT;
                            }


                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                            {
                                message.Result = (IntPtr)HTBOTTOMLEFT;
                            }
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                            {
                                message.Result = (IntPtr)HTBOTTOM;
                            }
                            else //Resize diagonally to the right
                            {
                                message.Result = (IntPtr)HTBOTTOMRIGHT;
                            }
                        }
                    }
                }
                return;
            }
            #endregion

            //Remove border and keep snap window
            if (message.Msg == WM_NCCALCSIZE && message.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (message.Msg == WM_SYSCOMMAND)
            {
                int wParam = (message.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref message);

        }

        private async void Form2_ResizeBegin(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized) // if form maximized
            {
                Padding = new Padding(borderSize); // change form padding back to normal
                pictureBoxLogo.Left = 0;
                pictureBoxLogo.Top = 0;
                buttonMaximize.BackgroundImage = Properties.Resources.Maximize;
            }
            await changeGameCoverSize();
            Refresh();

        }
       
        private async void Form2_Resize(object sender, EventArgs e)
        {
            await changeGameCoverSize();
            await changeGamesCoversColums();
            Refresh();
        }

        private async void Form2_ResizeEnd(object sender, EventArgs e)
        {
            await changeGameCoverSize();
            await changeGamesCoversColums();
            Refresh();
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox obj = (PictureBox)sender;
            f3 = new About(obj.BackgroundImage, (int)obj.Tag, sqlConnection, userId, false, this, f4);

            f3.TopLevel = false;
            f3.Dock = DockStyle.Fill;
            panelWorkspace.Controls.Add(f3);
            f3.BringToFront();
            f3.Show();
            
        }
        private async Task changeGameCoverSize()
        {
            if (panelGameDisplay.Width >= 1450)
            {
                await Task.Run(() =>
                {
                    foreach (PictureBox button in gamesList)
                    {
                        SetGameCoverSize(button, 250, 375);
                    }

                });
                return;
            }

            if (panelGameDisplay.Width >= 1100)
            {
                await Task.Run(() =>
                {
                    foreach (PictureBox button in gamesList)
                    {
                        SetGameCoverSize(button, 200, 300);
                    }
                });
                return;
            }
            if (panelGameDisplay.Width >= 0)
            {
                await Task.Run(() =>
                {
                    foreach (PictureBox button in gamesList)
                    {
                        SetGameCoverSize(button, 150, 225);
                    }
                });
                return;
            }
        }

        delegate void SetGameCoverSizeCallback(PictureBox button, int width, int height);

        private void SetGameCoverSize(PictureBox pictureBox, int width, int height)
        {
            if (buttonCollapseMenu.InvokeRequired)
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
                if  (panelGameDisplay.GetColumnWidths()[0] <= gameCoverWidth + 20)
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

        public void updateGameList()
        {
            int count = panelGameDisplay.Controls.Count-1;
            for (int i = count; i > 0; i--)
            {
                panelGameDisplay.Controls.RemoveAt(i);
            }

            getLikedGames();
            addGames();
        }
    }
}

