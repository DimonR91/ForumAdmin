﻿#pragma checksum "..\..\..\BanParameters.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1FB809E9C27828AB4F09D8A48B5AE3D7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace ForumController {
    
    
    /// <summary>
    /// BanParameters
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class BanParameters : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\BanParameters.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label DaysLabel;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\..\BanParameters.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DaysTextBox;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\BanParameters.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label MonthsLabel;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\BanParameters.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MonthsTextBox;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\BanParameters.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label YearsLabel;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\BanParameters.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox YearsTextBox;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\BanParameters.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ReasonLabel;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\BanParameters.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ReasonTextBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\BanParameters.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BanButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ForumController;component/banparameters.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\BanParameters.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DaysLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.DaysTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.MonthsLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.MonthsTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.YearsLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.YearsTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.ReasonLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.ReasonTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.BanButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\BanParameters.xaml"
            this.BanButton.Click += new System.Windows.RoutedEventHandler(this.BanButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

