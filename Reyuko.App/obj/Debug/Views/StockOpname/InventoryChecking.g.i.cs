﻿#pragma checksum "..\..\..\..\Views\StockOpname\InventoryChecking.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "57935F23DD90DFBBCB8D1BF3777977551F8309A029E78D1BDA4F9EEECD36EF60"
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


namespace Reyuko.App.Views.StockOpname {
    
    
    /// <summary>
    /// InventoryChecking
    /// </summary>
    public partial class InventoryChecking : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 83 "..\..\..\..\Views\StockOpname\InventoryChecking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LstInventoryChecking;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\..\Views\StockOpname\InventoryChecking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.AutoCompleteBox srlocation;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\..\..\Views\StockOpname\InventoryChecking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.AutoCompleteBox srdocumentnumber;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\..\Views\StockOpname\InventoryChecking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtvalue;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\..\..\Views\StockOpname\InventoryChecking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRange;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\..\..\Views\StockOpname\InventoryChecking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGInventoryChecking;
        
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
            System.Uri resourceLocater = new System.Uri("/Reyuko.App;component/views/stockopname/inventorychecking.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\StockOpname\InventoryChecking.xaml"
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
            
            #line 38 "..\..\..\..\Views\StockOpname\InventoryChecking.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.playtutorial_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 59 "..\..\..\..\Views\StockOpname\InventoryChecking.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NewInventoryChecking_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 67 "..\..\..\..\Views\StockOpname\InventoryChecking.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditInventroyChecking_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 75 "..\..\..\..\Views\StockOpname\InventoryChecking.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Refresh_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LstInventoryChecking = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.srlocation = ((System.Windows.Controls.AutoCompleteBox)(target));
            
            #line 125 "..\..\..\..\Views\StockOpname\InventoryChecking.xaml"
            this.srlocation.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SearchLokasi_selectedchange);
            
            #line default
            #line hidden
            return;
            case 7:
            this.srdocumentnumber = ((System.Windows.Controls.AutoCompleteBox)(target));
            
            #line 143 "..\..\..\..\Views\StockOpname\InventoryChecking.xaml"
            this.srdocumentnumber.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dokumen_selectedchange);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtvalue = ((System.Windows.Controls.TextBox)(target));
            
            #line 157 "..\..\..\..\Views\StockOpname\InventoryChecking.xaml"
            this.txtvalue.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Txtvalue_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtRange = ((System.Windows.Controls.TextBox)(target));
            
            #line 158 "..\..\..\..\Views\StockOpname\InventoryChecking.xaml"
            this.txtRange.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtRange_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.DGInventoryChecking = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

