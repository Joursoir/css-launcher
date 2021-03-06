﻿#pragma checksum "..\..\Settings_Window.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "74221D4F7FF68D468040D6A8261AB27837FA423BD2D14863817B1EC098BF1E26"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using SuperDesign;
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


namespace SuperDesign {
    
    
    /// <summary>
    /// Settings_Window
    /// </summary>
    public partial class Settings_Window : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\Settings_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonAvatar;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\Settings_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox s_language;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\Settings_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox s_line;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\Settings_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button reset_sline;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\Settings_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox s_clantag;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\Settings_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.ToggleSwitch s_avatar;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\Settings_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button s_accept_change;
        
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
            System.Uri resourceLocater = new System.Uri("/cssLauncher;component/settings_window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Settings_Window.xaml"
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
            this.buttonAvatar = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\Settings_Window.xaml"
            this.buttonAvatar.Click += new System.Windows.RoutedEventHandler(this.ChangeAvatar);
            
            #line default
            #line hidden
            
            #line 39 "..\..\Settings_Window.xaml"
            this.buttonAvatar.Loaded += new System.Windows.RoutedEventHandler(this.ButtonBase_Loaded);
            
            #line default
            #line hidden
            
            #line 40 "..\..\Settings_Window.xaml"
            this.buttonAvatar.MouseMove += new System.Windows.Input.MouseEventHandler(this.buttonAvatar_MouseMove);
            
            #line default
            #line hidden
            
            #line 40 "..\..\Settings_Window.xaml"
            this.buttonAvatar.MouseLeave += new System.Windows.Input.MouseEventHandler(this.buttonAvatar_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 2:
            this.s_language = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.s_line = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.reset_sline = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\Settings_Window.xaml"
            this.reset_sline.Click += new System.Windows.RoutedEventHandler(this.ResetConsoleLine);
            
            #line default
            #line hidden
            return;
            case 5:
            this.s_clantag = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.s_avatar = ((MahApps.Metro.Controls.ToggleSwitch)(target));
            return;
            case 7:
            this.s_accept_change = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\Settings_Window.xaml"
            this.s_accept_change.Click += new System.Windows.RoutedEventHandler(this.AcceptChange);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

