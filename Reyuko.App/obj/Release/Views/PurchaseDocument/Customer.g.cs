﻿#pragma checksum "..\..\..\..\Views\PurchaseDocument\Customer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7E5A8A962A6CDBFA467EB5E286B687264FBCC849061EB33540E192D8BBD5F782"
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


namespace Reyuko.App.Views.PurchaseDocument {
    
    
    /// <summary>
    /// Customer
    /// </summary>
    public partial class Customer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 53 "..\..\..\..\Views\PurchaseDocument\Customer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label InfoMail;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\Views\PurchaseDocument\Customer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCustomerID;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\Views\PurchaseDocument\Customer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtName;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Views\PurchaseDocument\Customer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCustomerClasification;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\Views\PurchaseDocument\Customer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPhone;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\Views\PurchaseDocument\Customer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmail;
        
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
            System.Uri resourceLocater = new System.Uri("/Reyuko.App;component/views/purchasedocument/customer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\PurchaseDocument\Customer.xaml"
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
            
            #line 39 "..\..\..\..\Views\PurchaseDocument\Customer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 46 "..\..\..\..\Views\PurchaseDocument\Customer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.InfoMail = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txtCustomerID = ((System.Windows.Controls.TextBox)(target));
            
            #line 70 "..\..\..\..\Views\PurchaseDocument\Customer.xaml"
            this.txtCustomerID.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtCustomerID_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtName = ((System.Windows.Controls.TextBox)(target));
            
            #line 71 "..\..\..\..\Views\PurchaseDocument\Customer.xaml"
            this.txtName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cbCustomerClasification = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.txtPhone = ((System.Windows.Controls.TextBox)(target));
            
            #line 73 "..\..\..\..\Views\PurchaseDocument\Customer.xaml"
            this.txtPhone.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtPhone_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtEmail = ((System.Windows.Controls.TextBox)(target));
            
            #line 74 "..\..\..\..\Views\PurchaseDocument\Customer.xaml"
            this.txtEmail.LostFocus += new System.Windows.RoutedEventHandler(this.TxtEmail_OnLostFocus);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

