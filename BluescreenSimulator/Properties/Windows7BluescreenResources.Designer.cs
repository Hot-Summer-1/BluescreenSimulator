﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BluescreenSimulator.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Windows7BluescreenResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Windows7BluescreenResources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BluescreenSimulator.Properties.Windows7BluescreenResources", typeof(Windows7BluescreenResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 Physical memory dump complete.
        ///Contact your system administator or technical support group for further assistance. 的本地化字符串。
        /// </summary>
        public static string DumpComplete {
            get {
                return ResourceManager.GetString("DumpComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Dumping physical memory to disk: @p 的本地化字符串。
        /// </summary>
        public static string DumpProgress {
            get {
                return ResourceManager.GetString("DumpProgress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Collecting data for crash dump...
        ///Initializing disk for crash dump...
        ///Beginning dump of physical memory. 的本地化字符串。
        /// </summary>
        public static string DumpStart {
            get {
                return ResourceManager.GetString("DumpStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 IRQL_NOT_LESS_OR_EQUAL 的本地化字符串。
        /// </summary>
        public static string ErrorCode {
            get {
                return ResourceManager.GetString("ErrorCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 A problem has been detected and windows has been shutdown to prevent damage to your computer. 的本地化字符串。
        /// </summary>
        public static string Header {
            get {
                return ResourceManager.GetString("Header", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Check to make sure any hardware or software is properly installed.
        ///If this is a new installation. ask your hardware or software manufacturer for any windows updates you might need.
        ///
        ///If problems continue, disable or remove any newly installed hardware or software. Disable BIOS memory options such as caching or shadowing. If you need to use Safe Mode to remove or disable components, restart your computer, press F8 to select Advanced Startup Options, and then select Safe Mode. 的本地化字符串。
        /// </summary>
        public static string Steps {
            get {
                return ResourceManager.GetString("Steps", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 If this is the first time you&apos;ve seen this error screen, restart your computer. if this screen appears again. follow these steps: 的本地化字符串。
        /// </summary>
        public static string StepsHeader {
            get {
                return ResourceManager.GetString("StepsHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 *** STOP: 0x000000FE (0x00000008, 0x000000006, 0x00000009, 0x847075cc) 的本地化字符串。
        /// </summary>
        public static string StopCode {
            get {
                return ResourceManager.GetString("StopCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Technical information: 的本地化字符串。
        /// </summary>
        public static string TechnicalInfoHeader {
            get {
                return ResourceManager.GetString("TechnicalInfoHeader", resourceCulture);
            }
        }
    }
}
