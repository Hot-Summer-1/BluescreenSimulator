using System.Diagnostics.CodeAnalysis;
using BluescreenSimulator.Views;

namespace BluescreenSimulator.ViewModels
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [CmdParameter("--win9x", Description = "使用Windows 9x蓝屏")]
    [BluescreenView(typeof(BluescreenWindow9x))]
    public class Windows9xBluescreenViewModel : BluescreenViewModelBase<Windows9xBluescreen>
    {
        public override string StyleName => "Windows 9x样式";

        public Windows9xBluescreenViewModel() : this(null)
        {
            
        }

        public Windows9xBluescreenViewModel(Windows9xBluescreen model = null) : base(model)
        {
        }

        [CmdParameter("-e", Description = "底端显示的错误消息", FullAlias = "error")]
        public string Error
        {
            get => Model.Error;
            set => SetModelProperty(value);
        }
        [CmdParameter("-bh", Description = "显示在灰色背景上的标题，默认为Windows", FullAlias = "header")]
        public string Header
        {
            get => Model.Header;
            set => SetModelProperty(value);
        }
        [CmdParameter("-i1", Description = "第一行信息", FullAlias = "infoline1")]
        public string InfoLine1
        {
            get => Model.InfoLine1;
            set => SetModelProperty(value);
        }
        [CmdParameter("-i2", Description = "第二行信息", FullAlias = "infoline2")]
        public string InfoLine2
        {
            get => Model.InfoLine2;
            set => SetModelProperty(value);
        }
        [CmdParameter("-i", Description = "要遵循的指示", FullAlias = "instructions")]
        public string Instructions
        {
            get => Model.Instructions;
            set => SetModelProperty(value);
        }
        [CmdParameter("-tc", Description = "继续的命令，在屏幕底端显示。", FullAlias = "continue")]
        public string ToContinue
        {
            get => Model.ToContinue;
            set => SetModelProperty(value);
        }
    }
}