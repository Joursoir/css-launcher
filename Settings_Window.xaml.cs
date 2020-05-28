using System;
using Microsoft.Win32;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace SuperDesign
{
    /// <summary>
    /// Логика взаимодействия для Settings_Window.xaml
    /// </summary>
    public partial class Settings_Window : MetroWindow
    {
        IniFiles manager = new IniFiles(AppDomain.CurrentDomain.BaseDirectory + "rev.ini");
        private string new_file_folder = AppDomain.CurrentDomain.BaseDirectory + "platform\\avatar.dat";
        private string rez_file_folder = AppDomain.CurrentDomain.BaseDirectory + "platform\\avatar1.dat";
        private Image pAvatar;
        public Settings_Window()
        {
            InitializeComponent();
            s_language.ItemsSource = new List<string> { "Russian", "English", "French", "Italian", "German", "Spanish", "Portugeuse" };
            /* ставим стандартное значение: */

            // язык игры:
            string language = manager.ReadINI("Emulator", "Language");
            int index = s_language.Items.IndexOf(language);
            s_language.SelectedIndex = index;

            // строка запуска:
            string launch_line = manager.ReadINI("Loader", "ProcName");
            s_line.Text = launch_line;

            // клан-тег:
            string clan_tag = manager.ReadINI("steamclient", "ClanTag");
            s_clantag.Text = clan_tag;

            // показ аватара:
            bool show_avatar = Convert.ToBoolean(manager.ReadINI("steamclient", "Use_avatar"));
            s_avatar.IsChecked = show_avatar;
        }

        private void ButtonBase_Loaded(object sender, EventArgs e)
        {
            // аватар:
            pAvatar = buttonAvatar.Template.FindName("imageAvatar", buttonAvatar) as Image;
            if (System.IO.File.Exists(new_file_folder))
            {
                System.IO.File.Copy(new_file_folder, rez_file_folder, true);

                BitmapImage bitmapImage = GetBitmapImage(rez_file_folder);
                pAvatar.Source = bitmapImage;
                System.IO.File.Delete(rez_file_folder);
                System.IO.File.Copy(new_file_folder, rez_file_folder, true);
            }


        }

        private void buttonAvatar_MouseMove(object sender, MouseEventArgs e) => this.Cursor = Cursors.Hand;
        private void buttonAvatar_MouseLeave(object sender, MouseEventArgs e) => this.Cursor = Cursors.Arrow;

        private void AcceptChange(object sender, EventArgs e)
        {
            manager.Write("Emulator", "Language", s_language.SelectedItem.ToString());
            manager.Write("Loader", "ProcName", s_line.Text);
            manager.Write("steamclient", "ClanTag", s_clantag.Text);
            manager.Write("steamclient", "Use_avatar", s_avatar.IsChecked.ToString());
            
            this.Close();
        }

        private void ChangeAvatar(object sender, EventArgs e)
        {
            OpenFileDialog aFile = new OpenFileDialog(); // aFile = avatarFile
            aFile.Filter = "Image (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            aFile.RestoreDirectory = true;

            // Show open file dialog box
            Nullable<bool> result = aFile.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                // Open document
                string file_folder = aFile.FileName;

                // переименовываем, перемещаем, меняем формат:
                System.IO.File.Copy(file_folder, new_file_folder, true);
                System.IO.File.Copy(file_folder, rez_file_folder, true);

                // string new_file_folder = System.IO.Path.ChangeExtension(file_folder, ".dat"); // меняет формат

                BitmapImage bitmapImage = GetBitmapImage(rez_file_folder);
                pAvatar.Source = bitmapImage;
                System.IO.File.Delete(rez_file_folder);


            }
        }
        private void ResetConsoleLine(object sender, EventArgs e)
        {
            s_line.Text = "hl2.exe -game cstrike -steam -silent -novid -high";
        }

        public static BitmapImage GetBitmapImage(string str)
        {
            var bitmap = new BitmapImage();
            using (var stream = new System.IO.FileStream(str, System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                bitmap.BeginInit();
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.StreamSource = stream;
                bitmap.EndInit();
                bitmap.Freeze();
            }
            return bitmap;
        }
    }
    public class MyControl : Control
    {
        static MyControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(MyControl),
                new FrameworkPropertyMetadata(typeof(MyControl)));
        }

        public static readonly DependencyProperty DisplayProperty = DependencyProperty.Register(
            "Display", typeof(ItemsControl), typeof(MyControl));

        public ItemsControl Display
        {
            get
            {
                return (ItemsControl)this.GetValue(MyControl.DisplayProperty);
            }
            set
            {
                this.SetValue(MyControl.DisplayProperty, value);
            }
        }
    }
}
