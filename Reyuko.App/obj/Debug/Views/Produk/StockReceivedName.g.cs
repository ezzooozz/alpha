﻿#pragma checksum "..\..\..\..\Views\Produk\StockReceivedName.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "961BE4FFFAC0C15EA6C85BDCACA088591DA47152E9D676FE612EECB3478817F0"
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


namespace Reyuko.App.Views.Produk {
    
    
    /// <summary>
    /// StockReceivedName
    /// </summary>
    public partial class StockReceivedName : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 85 "..\..\..\..\Views\Produk\StockReceivedName.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.AutoCompleteBox srcustomer;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\Views\Produk\StockReceivedName.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBLocation;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\Views\Produk\StockReceivedName.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBCash;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\Views\Produk\StockReceivedName.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTotalUnit;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\Views\Produk\StockReceivedName.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPurchasingprice;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\Views\Produk\StockReceivedName.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtReceivednumber;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\Views\Produk\StockReceivedName.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNote;
        
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
            System.Uri resourceLocater = new System.Uri("/Reyuko.App;component/views/produk/stockreceivedname.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Produk\StockReceivedName.xaml"
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
            
            #line 51 "..\..\..\..\Views\Produk\StockReceivedName.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnSave_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 59 "..\..\..\..\Views\Produk\StockReceivedName.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnCancel_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 66 "..\..\..\..\Views\Produk\StockReceivedName.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NewVendor_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.srcustomer = ((System.Windows.Controls.AutoCompleteBox)(target));
            return;
            case 5:
            this.CBLocation = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.CBCash = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.txtTotalUnit = ((System.Windows.Controls.TextBox)(target));
            
            #line 100 "..\..\..\..\Views\Produk\StockReceivedName.xaml"
            this.txtTotalUnit.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtTotalUnit_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtPurchasingprice = ((System.Windows.Controls.TextBox)(target));
            
            #line 101 "..\..\..\..\Views\Produk\StockReceivedName.xaml"
            this.txtPurchasingprice.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtPurchasingprice_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtReceivednumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 102 "..\..\..\..\Views\Produk\StockReceivedName.xaml"
            this.txtReceivednumber.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtReceivednumber_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.txtNote = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

