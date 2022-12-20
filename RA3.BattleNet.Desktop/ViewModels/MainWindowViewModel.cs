using System;
using System.IO;
using Avalonia.Controls.Shapes;
using LibGit2Sharp;
using Path = System.IO.Path;

namespace RA3.BattleNet.Desktop.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "主页";

        public MainWindowViewModel()
        {
            var liveContentDirectory = Path.Combine(Environment.CurrentDirectory, "liveContentTest");
            var repoURL = "https://gitee.com/RA3BattleNet/LiveContent.git";
            var cloneOptions = new CloneOptions()
            {
                BranchName = "master",
                Checkout = true,
            };
            if (!Directory.Exists(liveContentDirectory))
            {
                // Clone if directory not exists.
                //Repository.Clone(repoURL, liveContentDirectory);
            }
        }
        
    }
}