﻿#pragma checksum "..\..\..\..\Views\SalesReturn\SalesReturn.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D945DE4DE2B89B84FAE52E9CF4DC4479608B774614C3E52E84912F92CF5C9C62"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DevExpress.Xpf.DXBinding;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Reyuko.App.Views.SalesReturn {
    
    
    /// <summary>
    /// SalesReturn
    /// </summary>
    public partial class SalesReturn : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 133 "..\..\..\..\Views\SalesReturn\SalesReturn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.AutoCompleteBox srcustomer;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\..\Views\SalesReturn\SalesReturn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbRecap;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\..\Views\SalesReturn\SalesReturn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbClasification;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\..\..\Views\SalesReturn\SalesReturn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtvalue;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\..\Views\SalesReturn\SalesReturn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRange;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\..\Views\SalesReturn\SalesReturn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCurrency;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\..\Views\SalesReturn\SalesReturn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGSalesReturn;
        
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
            System.Uri resourceLocater = new System.Uri("/Reyuko.App;component/views/salesreturn/salesreturn.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\SalesReturn\SalesReturn.xaml"
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
            
            #line 39 "..\..\..\..\Views\SalesReturn\SalesReturn.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Viewaschart_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 46 "..\..\..\..\Views\SalesReturn\SalesReturn.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Viewposted_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 53 "..\..\..\..\Views\SalesReturn\SalesReturn.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.playtutorial_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 74 "..\..\..\..\Views\SalesReturn\SalesReturn.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NewSalesReturn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 82 "..\..\..\..\Views\SalesReturn\SalesReturn.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Payment_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 90 "..\..\..\..\Views\SalesReturn\SalesReturn.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Detail_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 98 "..\..\..\..\Views\SalesReturn\SalesReturn.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Print_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 106 "..\..\..\..\Views\SalesReturn\SalesReturn.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Refresh_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 114 "..\..\..\..\Views\SalesReturn\SalesReturn.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.srcustomer = ((System.Windows.Controls.AutoCompleteBox)(target));
            
            #line 133 "..\..\..\..\Views\SalesReturn\SalesReturn.xaml"
            this.srcustomer.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.customer_selectedchange);
            
            #line default
            #line hidden
            return;
            case 11:
            this.cbRecap = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            this.cbClasification = ((System.Windows.Controls.ComboBox)(target));
            
            #line 148 "..\..\..\..\Views\SalesReturn\SalesReturn.xaml"
            this.cbClasification.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbClasification_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 13:
            this.txtvalue = ((System.Windows.Controls.TextBox)(target));
            
            #line 149 "..\..\..\..\Views\SalesReturn\SalesReturn.xaml"
            this.txtvalue.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Txtvalue_TextChanged);
            
            #line default
            #line hidden
            return;
            case 14:
            this.txtRange = ((System.Windows.Controls.TextBox)(target));
            
            #line 150 "..\..\..\..\Views\SalesReturn\SalesReturn.xaml"
            this.txtRange.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtRange_TextChanged);
            
            #line default
            #line hidden
            return;
            case 15:
            this.cbCurrency = ((System.Windows.Controls.ComboBox)(target));
            
            #line 151 "..\..\..\..\Views\SalesReturn\SalesReturn.xaml"
            this.cbCurrency.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.currency_selectedchange);
            
            #line default
            #line hidden
            return;
            case 16:
            this.DGSalesReturn = ((System.Windows.Controls.DataGrid)(target));
            
            #line 171 "..\..\..\..\Views\SalesReturn\SalesReturn.xaml"
            this.DGSalesReturn.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DGSalesReturn_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

