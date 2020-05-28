using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using System.Security;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using System.Diagnostics;

namespace SuperDesign
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        IniFiles manager = new IniFiles(AppDomain.CurrentDomain.BaseDirectory + "rev.ini");

        private void Window_Load(object sender, EventArgs e)
        {
            // сначала грузится, а потом уже элементы к нему (не факт)
            // MessageBox.Show("Text");

            string nickname = manager.ReadINI("steamclient", "PlayerName");
            loginBox.Text = nickname;
        }

        private void PlayButton(object sender, EventArgs e)
        {
            if (loginBox.Text.Length < 3) // меняем на стандартное имя
                loginBox.Text = "cssLauncherPlayer";

            manager.Write("steamclient", "PlayerName", loginBox.Text);
            CMD("start Run_CSS.exe");
                // CMD("start " + Settings.GameFolder + "-steam -game cstrike");

                //ProcessStartInfo startInfo = new ProcessStartInfo(Settings.GameFolder, "-steam -game cstrike -russian");

                //Process.Start(startInfo).WaitForExit();
                /*Process proc = new Process();
                proc.StartInfo.FileName = @"C:\Games\Counter-Strike Source v91\start_css.bat";
                proc.StartInfo.WorkingDirectory = @"C:\Games\Counter-Strike Source v91";
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.Start();
                proc.WaitForExit();*/
        }
        private void CMD(string line)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c {line}",
                WindowStyle = ProcessWindowStyle.Hidden
            }).WaitForExit();
        }

        private void Click_Settings(object sender, EventArgs e)
        {
            Settings_Window new_window = new Settings_Window();
            new_window.ShowDialog(); // делаем недоступным старое окно, при вызове "настройки"
        }
    }

    public class IniFiles
    {

        string Path; //Имя файла.

        [DllImport("kernel32", CharSet = CharSet.Auto)] // Подключаем kernel32.dll и описываем его функцию WritePrivateProfilesString
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Auto)] // Еще раз подключаем kernel32.dll, а теперь описываем функцию GetPrivateProfileString
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        static extern uint GetPrivateProfileSection(string lpAppName, IntPtr lpReturnedString, uint nSize, string lpFileName);
        // С помощью конструктора записываем пусть до файла и его имя.
        public IniFiles(string IniPath)
        {
            Path = new FileInfo(IniPath).FullName.ToString();
        }

        //Читаем ini-файл и возвращаем значение указного ключа из заданной секции.
        public string ReadINI(string Section, string Key)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }
        //Записываем в ini-файл. Запись происходит в выбранную секцию в выбранный ключ.
        public void Write(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, Path);
        }

        //Удаляем ключ из выбранной секции.
        public void DeleteKey(string Key, string Section = null)
        {
            Write(Section, Key, null);
        }
        //Удаляем выбранную секцию
        public void DeleteSection(string Section = null)
        {
            Write(Section, null, null);
        }
        //Проверяем, есть ли такой ключ, в этой секции
        public bool KeyExists(string Section, string Key)
        {
            return ReadINI(Section, Key).Length > 0;
        }

        //читаем в массив все пары ключей-значнией в данной секции
        public bool GetPrivateProfileSection(string appName, string fileName, out string[] section)
        {
            section = null;

            if (!System.IO.File.Exists(fileName))
                return false;

            const uint MAX_BUFFER = 32767;

            IntPtr pReturnedString = Marshal.AllocCoTaskMem((int)MAX_BUFFER * sizeof(char));

            uint bytesReturned = GetPrivateProfileSection(appName, pReturnedString, MAX_BUFFER, fileName);

            if ((bytesReturned == MAX_BUFFER - 2) || (bytesReturned == 0))
            {
                Marshal.FreeCoTaskMem(pReturnedString);
                return false;
            }
            string returnedString = Marshal.PtrToStringAuto(pReturnedString, (int)(bytesReturned - 1));

            section = returnedString.Split('\0');

            Marshal.FreeCoTaskMem(pReturnedString);
            return true;
        }
    }
}
