using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Input;
using BluescreenSimulator.Properties;
using BluescreenSimulator.ViewModels;

namespace BluescreenSimulator.Views
{
    public partial class MainWindow : Window
    {
        private MainWindowViewModel _vm;
        private IBluescreenViewModel CurrentBluescreen => _vm.SelectedBluescreen;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = _vm = new MainWindowViewModel();
            InputBindings.Add(new InputBinding(new DelegateCommand(() =>
            {
                Settings.Default.IsDarkTheme = !Settings.Default.IsDarkTheme;
                Settings.Default.Save();
            }), new KeyGesture(Key.F12)));
        }

        private void ShowBSOD(object sender, RoutedEventArgs e)
        {
            if (CheckData())
            {
                CurrentBluescreen.ShowView();
            }
        }

        private void OpenAbout(object sender, RoutedEventArgs e)
        {
            var about = new About();
            about.Show();
        }

        private void GenerateExe(object sender, RoutedEventArgs e)
        {
            var command = GenerateCommand();
            if (command == null)
            {
                return;
            }

            var path = Environment.GetCommandLineArgs()[0];
            var filenameStartIndex = path.LastIndexOf('\\') + 1;
            var folder = path.Substring(0, filenameStartIndex);
            var filename = path.Substring(filenameStartIndex);
            var commandFile = "command";

            File.WriteAllText(commandFile, command);

            var exeCreator = new ExeCreator { Owner = this, CommandBox = { Text = filename + " " + command } };
            exeCreator.ShowDialog();

            if (exeCreator.DialogResult != true)
            {
                return;
            }

            var desiredFilename = exeCreator.FileName.Text;
            if (string.IsNullOrEmpty(desiredFilename))
            {
                return;
            }

            var iexpressSED =
                            $@"
                [Version]
                Class=IEXPRESS
                SEDVersion=3
                [Options]
                PackagePurpose=InstallApp
                ShowInstallProgramWindow=1
                HideExtractAnimation=1
                UseLongFileName=1
                InsideCompressed=0
                RebootMode=N
                TargetName={folder}\{desiredFilename}.exe
                AppLaunched=cmd /c %FILE0% --read-command-file
                PostInstallCmd=<None>
                SourceFiles=SourceFiles
                [Strings]
                FILE0=""{filename}""
                FILE1=""{commandFile}""
                [SourceFiles]
                SourceFiles0 = {folder}
                [SourceFiles0]
                %FILE0%=
                %FILE1%=";


            var SEDPath = Path.GetTempPath() + "\\optionfile.SED";

            File.WriteAllText(SEDPath, iexpressSED);
            Process p = new Process();
            p.StartInfo.FileName = "C:\\Windows\\system32\\iexpress.exe";
            p.StartInfo.Arguments = $"/N {SEDPath}";
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.Start();
            p.WaitForExit();
            File.Delete(SEDPath);
            File.Delete(commandFile);
            MessageBox.Show("EXE文件已创建。", "BluescreenWindow Simulator", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private string GenerateCommand()
        {
            var success = CheckData();
            if (!success) return "";
            return CurrentBluescreen.CreateCommandParameters();
        }


        private bool CheckData()
        {
            if (!string.IsNullOrWhiteSpace(CurrentBluescreen.CmdCommand))
            {
                var messageBoxResult = MessageBox.Show("使用命令可能很危险。" +
                    "对于因不负责任或不仔细使用命令选项而造成的任何数据丢失或其他损害，我概不负责。" +
                    "请重新检查你的命令，以确保你执行了预期的操作：\r\n\r\n" + CurrentBluescreen.CmdCommand.Trim() + "\r\n\r\n" + "是否要继续？",
                    "警告", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (messageBoxResult == MessageBoxResult.No)
                {
                    return false;
                }
            }
            return true;
        }

        private void Tabs_SelectionChanged()
        {

        }

        private void Tabs_SelectionChanged_1()
        {

        }
    }
}
