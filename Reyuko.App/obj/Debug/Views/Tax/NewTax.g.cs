﻿#pragma checksum "..\..\..\..\Views\Tax\NewTax.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FE5DEAEEC1B6D8E3C48A2C3A4B034BD42B747E5DC832B8EAE2732C865D90CA90"
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


namespace Reyuko.App.Views.Tax {
    
    
    /// <summary>
    /// NewTax
    /// </summary>
    public partial class NewTax : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 71 "..\..\..\..\Views\Tax\NewTax.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TXTKodePajak;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Views\Tax\NewTax.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TXTNamaPajak;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\Views\Tax\NewTax.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TXTPersentase;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\Views\Tax\NewTax.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TXTKeterangan;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\Views\Tax\NewTax.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CHKAktif;
        
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
            System.Uri resourceLocater = new System.Uri("/Reyuko.App;component/views/tax/newtax.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Tax\NewTax.xaml"
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
            
            #line 52 "..\..\..\..\Views\Tax\NewTax.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 60 "..\..\..\..\Views\Tax\NewTax.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TXTKodePajak = ((System.Windows.Controls.TextBox)(target));
            
            #line 71 "..\..\..\..\Views\Tax\NewTax.xaml"
            this.TXTKodePajak.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TXTKodePajak_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TXTNamaPajak = ((System.Windows.Controls.TextBox)(target));
            
            #line 72 "..\..\..\..\Views\Tax\NewTax.xaml"
            this.TXTNamaPajak.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TXTNamaPajak_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TXTPersentase = ((System.Windows.Controls.TextBox)(target));
            
            #line 73 "..\..\..\..\Views\Tax\NewTax.xaml"
            this.TXTPersentase.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TXTPersentase_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TXTKeterangan = ((System.Windows.Controls.TextBox)(target));
            
            #line 74 "..\..\..\..\Views\Tax\NewTax.xaml"
            this.TXTKeterangan.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TXTKeterangan_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CHKAktif = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

