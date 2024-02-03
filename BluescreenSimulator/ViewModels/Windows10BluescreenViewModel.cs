using System.Threading;
using BluescreenSimulator.Views;

namespace BluescreenSimulator.ViewModels
{
    [BluescreenView(typeof(BluescreenWindow))]
    [CmdParameter("--win10", Description = "使用Windows 10蓝屏。")]
    public class Windows10BluescreenViewModel : BluescreenViewModelBase<Windows10Bluescreen>
    {
        public override string StyleName => "Windows 10样式";

        public Windows10BluescreenViewModel() : this(null)
        {

        }
        public Windows10BluescreenViewModel(Windows10Bluescreen model = null) : base(model)
        {
            
        }
        private CancellationTokenSource _source = new CancellationTokenSource();

        [CmdParameter("-e", Description = "{Text} 作为表情", FullAlias = "emoticon")]
        public string Emoticon
        {
            get => Model.Emoticon;
            set => SetModelProperty(value);
        }
        [CmdParameter("-m1", Description = "{Text} 作为第一行文本", FullAlias = "main1")]
        public string MainText1
        {
            get => Model.MainText1;
            set => SetModelProperty(value);
        }
        [CmdParameter("-m2", Description = "{Text} 作为第二行文本", FullAlias = "main2")]
        public string MainText2
        {
            get => Model.MainText2;
            set => SetModelProperty(value);
        }
        [CmdParameter("-p", Description = "{Text} 作为进度文本", FullAlias = "progress")]
        public string Complete
        {
            get => Model.Complete;
            set => SetModelProperty(value);
        }
        [CmdParameter("-mi", Description = "{Text} 作为更多信息", FullAlias = "moreinfo")]
        public string MoreInfo
        {
            get => Model.MoreInfo;
            set => SetModelProperty(value);
        }
        [CmdParameter("-s", Description = "{Text} 作为支持人员", FullAlias = "supportperson")]
        public string SupportPerson
        {
            get => Model.SupportPerson;
            set => SetModelProperty(value);
        }
        [CmdParameter("-sc", Description = "{Text} 作为中止代码", FullAlias = "stopcode")]
        public string StopCode
        {
            get => Model.StopCode;
            set => SetModelProperty(value);
        }
        [CmdParameter("-hq", Description = "隐藏二维码", FullAlias = "hideqr")]
        public bool HideQR
        {
            get => Model.HideQR;
            set => SetModelProperty(value, others: nameof(ShowQR));
        }

        public bool ShowQR => !HideQR;
        [CmdParameter("-oq", Description = "使用原二维码", FullAlias = "origqr")]
        public bool UseOriginalQR
        {
            get => Model.UseOriginalQR;
            set => SetModelProperty(value);
        }

        [CmdParameter("-td", Description = "文本显示延迟", FullAlias = "textdelay")]
        public double TextDelay
        {
            get => Model.TextDelay;
            set => SetModelProperty(value);
        }
        
        public override bool SupportsRainbow => true;
    }
}