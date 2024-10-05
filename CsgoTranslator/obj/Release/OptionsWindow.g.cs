﻿#pragma checksum "..\..\OptionsWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D7D4A9AF9592EB065FCEF6B9B33B089F59E3FA3A5FB4E4202F45624CB52E641A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CsgoTranslator;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace CsgoTranslator {
    
    
    /// <summary>
    /// OptionsWindow
    /// </summary>
    public partial class OptionsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 62 "..\..\OptionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbFolderPath;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\OptionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbLang;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\OptionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbOwnUsername;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\OptionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CbIgnoreOwnMessages;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\OptionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CbTransFromAll;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\OptionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CbTransFromTeam;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\OptionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RbTransToAll;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\OptionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RbTransToTeam;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\OptionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbTelnetPort;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\OptionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RbCommandsTeam;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\OptionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RbCommandsBoth;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\OptionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RbCommandsSelf;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CsgoTranslator;component/optionswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\OptionsWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TbFolderPath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TbLang = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 67 "..\..\OptionsWindow.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).RequestNavigate += new System.Windows.Navigation.RequestNavigateEventHandler(this.Hyperlink_RequestNavigate);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TbOwnUsername = ((System.Windows.Controls.TextBox)(target));
            
            #line 73 "..\..\OptionsWindow.xaml"
            this.TbOwnUsername.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TbOwnUsername_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CbIgnoreOwnMessages = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.CbTransFromAll = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.CbTransFromTeam = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.RbTransToAll = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 9:
            this.RbTransToTeam = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 10:
            this.TbTelnetPort = ((System.Windows.Controls.TextBox)(target));
            
            #line 102 "..\..\OptionsWindow.xaml"
            this.TbTelnetPort.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TbTelnetPort_OnPreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 11:
            this.RbCommandsTeam = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 12:
            this.RbCommandsBoth = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 13:
            this.RbCommandsSelf = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 14:
            
            #line 121 "..\..\OptionsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnSetDefault_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 122 "..\..\OptionsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnSaveOptions_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

