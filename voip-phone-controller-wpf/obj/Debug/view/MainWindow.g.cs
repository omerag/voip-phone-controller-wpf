﻿#pragma checksum "..\..\..\view\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C9BA1D0FF8FD00C22B0C9171FDC799F67CFEAD6B31597645B9D3BF712761B4AC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using voip_phone_controller_wpf;


namespace voip_phone_controller_wpf {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\view\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CallNumberTextbox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\view\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioBtnNoc1;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\view\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioBtnNoc2;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\view\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioBtnNoc3;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\view\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridXMAL;
        
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
            System.Uri resourceLocater = new System.Uri("/voip-phone-controller-wpf;component/view/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\view\MainWindow.xaml"
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
            this.CallNumberTextbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\view\MainWindow.xaml"
            this.CallNumberTextbox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\view\MainWindow.xaml"
            this.CallNumberTextbox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\view\MainWindow.xaml"
            this.CallNumberTextbox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ClearTextbox);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 14 "..\..\..\view\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CallBtn);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 15 "..\..\..\view\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.HangBtn);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RadioBtnNoc1 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 18 "..\..\..\view\MainWindow.xaml"
            this.RadioBtnNoc1.Click += new System.Windows.RoutedEventHandler(this.RadioBtnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.RadioBtnNoc2 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 19 "..\..\..\view\MainWindow.xaml"
            this.RadioBtnNoc2.Click += new System.Windows.RoutedEventHandler(this.RadioBtnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RadioBtnNoc3 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 20 "..\..\..\view\MainWindow.xaml"
            this.RadioBtnNoc3.Click += new System.Windows.RoutedEventHandler(this.RadioBtnClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DataGridXMAL = ((System.Windows.Controls.DataGrid)(target));
            
            #line 28 "..\..\..\view\MainWindow.xaml"
            this.DataGridXMAL.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGridXMAL_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 28 "..\..\..\view\MainWindow.xaml"
            this.DataGridXMAL.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DataGridXMAL_DoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

