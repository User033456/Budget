﻿#pragma checksum "..\..\..\mainPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FF94AA421B5B6C33FBBFE774BF83AFE40700AC1E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
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
using System.Windows.Controls.Ribbon;
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
using proga;


namespace proga {
    
    
    /// <summary>
    /// mainPage
    /// </summary>
    public partial class mainPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 190 "..\..\..\mainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PlaneIncome1_tb;
        
        #line default
        #line hidden
        
        
        #line 191 "..\..\..\mainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PlaneadditionalIncome_tb;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\..\mainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TotalIncome_tb;
        
        #line default
        #line hidden
        
        
        #line 221 "..\..\..\mainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FactIncome1_tb;
        
        #line default
        #line hidden
        
        
        #line 222 "..\..\..\mainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FactAdditionalIncome_tb;
        
        #line default
        #line hidden
        
        
        #line 223 "..\..\..\mainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FactTotalIncome_tb;
        
        #line default
        #line hidden
        
        
        #line 251 "..\..\..\mainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PlannedBalance;
        
        #line default
        #line hidden
        
        
        #line 252 "..\..\..\mainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock FactBalance;
        
        #line default
        #line hidden
        
        
        #line 253 "..\..\..\mainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Difference;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/proga;component/mainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\mainPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 7 "..\..\..\mainPage.xaml"
            ((proga.mainPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.MainPage_OnLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PlaneIncome1_tb = ((System.Windows.Controls.TextBox)(target));
            
            #line 190 "..\..\..\mainPage.xaml"
            this.PlaneIncome1_tb.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.PlaneIncomeUpdate);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PlaneadditionalIncome_tb = ((System.Windows.Controls.TextBox)(target));
            
            #line 191 "..\..\..\mainPage.xaml"
            this.PlaneadditionalIncome_tb.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.PlaneIncomeUpdate);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TotalIncome_tb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.FactIncome1_tb = ((System.Windows.Controls.TextBox)(target));
            
            #line 221 "..\..\..\mainPage.xaml"
            this.FactIncome1_tb.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FactIncomeUpdate);
            
            #line default
            #line hidden
            return;
            case 6:
            this.FactAdditionalIncome_tb = ((System.Windows.Controls.TextBox)(target));
            
            #line 222 "..\..\..\mainPage.xaml"
            this.FactAdditionalIncome_tb.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FactIncomeUpdate);
            
            #line default
            #line hidden
            return;
            case 7:
            this.FactTotalIncome_tb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.PlannedBalance = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.FactBalance = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.Difference = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

