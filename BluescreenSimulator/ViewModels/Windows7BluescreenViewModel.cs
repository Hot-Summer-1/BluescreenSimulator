using BluescreenSimulator.Views;

namespace BluescreenSimulator.ViewModels
{
    [BluescreenView(typeof(BluescreenWindowWin7))]
    [CmdParameter("--win7", Description = "使用Windows 7蓝屏")]
    public class Windows7BluescreenViewModel : BluescreenViewModelBase<Windows7Bluescreen>
    {
        public override string StyleName => "Windows 7样式";

        [CmdParameter("-dc", Description = "传储完成时显示的文本", FullAlias = "--dumpcomplete")]
        public string DumpComplete
        {
            get => Model.DumpComplete;
            set => SetModelProperty(value);
        }
        [CmdParameter("-dp", Description = "用来显示进度的文本 (@p 表示当前进度)", FullAlias = "--dumpprogress")]
        public string DumpProgress
        {
            get => Model.DumpProgress.Replace("@p", Progress.ToString());
            set => SetModelProperty(value, others: nameof(DumpProgressEdit));
        }
        public string DumpProgressEdit
        {
            get => Model.DumpProgress;
            set => DumpProgress = value;
        }
        [CmdParameter("-ds", Description = "用来显示传储开始的文本", FullAlias = "--dumpstart")]
        public string DumpStart
        {
            get => Model.DumpStart;
            set => SetModelProperty(value);
        }
        [CmdParameter("-ec", Description = "第二行显示的错误代码", FullAlias = "--error")]
        public string ErrorCode
        {
            get => Model.ErrorCode;
            set => SetModelProperty(value);
        }
        [CmdParameter("-bh", Description = "第一行内容", FullAlias = "--header")]
        public string Header
        {
            get => Model.Header;
            set => SetModelProperty(value);
        }
        [CmdParameter("-s", Description = "要遵循的步骤", FullAlias = "--steps")]
        public string Steps
        {
            get => Model.Steps;
            set => SetModelProperty(value);
        }
        [CmdParameter("-sh", Description = "步骤前的标头", FullAlias = "--stepsheader")]
        public string StepsHeader
        {
            get => Model.StepsHeader;
            set => SetModelProperty(value);
        }
        [CmdParameter("-th", Description = "终止代码前的标头", FullAlias = "--techheader")]
        public string TechnicalInfoHeader
        {
            get => Model.TechnicalInfoHeader;
            set => SetModelProperty(value);
        }
        [CmdParameter("-sc", Description = "终止代码", FullAlias = "--stopcode")]
        public string StopCode
        {
            get => Model.StopCode;
            set => SetModelProperty(value);
        }
        public override int Progress
        {
            get => base.Progress;
            set { base.Progress = value; OnPropertyChanged(nameof(IsDumpComplete)); OnPropertyChanged(nameof(DumpProgress));}
        }

        public bool IsDumpComplete => Progress >= 100;
    }
}
