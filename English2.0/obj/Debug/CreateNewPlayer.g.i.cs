﻿#pragma checksum "..\..\CreateNewPlayer.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B764B75B5F1F26A5731334B8E65EC689"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using English2._0;
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


namespace English2._0 {
    
    
    /// <summary>
    /// CreateNewPlyer
    /// </summary>
    public partial class CreateNewPlyer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\CreateNewPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\CreateNewPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextName;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\CreateNewPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextPassword;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\CreateNewPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelError;
        
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
            System.Uri resourceLocater = new System.Uri("/English2.0;component/createnewplayer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CreateNewPlayer.xaml"
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
            this.Save = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\CreateNewPlayer.xaml"
            this.Save.Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextName = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\CreateNewPlayer.xaml"
            this.TextName.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.TextName_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TextPassword = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\CreateNewPlayer.xaml"
            this.TextPassword.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.TextPassword_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LabelError = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            
            #line 28 "..\..\CreateNewPlayer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

