// Updated by XamlIntelliSenseFileGenerator 7/1/2020 10:23:27 AM
#pragma checksum "..\..\..\..\Views\AccountData\Skuother.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "88712909D3049A6BCC5FA4B61CBCF8AA01CD2CC377719D1493F1EEBF3580AC91"
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


namespace Reyuko.App.Views.AccountData
{


    /// <summary>
    /// Skuother
    /// </summary>
    public partial class Skuother : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {


#line 53 "..\..\..\..\Views\AccountData\Skuother.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label info;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Reyuko.App;component/views/accountdata/skuother.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\Views\AccountData\Skuother.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 11 "..\..\..\..\Views\AccountData\Skuother.xaml"
                    ((Reyuko.App.Views.ReceivedGood.Skuother)(target)).Loaded += new System.Windows.RoutedEventHandler(this.load);

#line default
#line hidden
                    return;
                case 2:
                    this.info = ((System.Windows.Controls.Label)(target));
                    return;
                case 3:
                    this.txtnama = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.txttotal = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:
                    this.txtprice = ((System.Windows.Controls.TextBox)(target));

#line 57 "..\..\..\..\Views\AccountData\Skuother.xaml"
                    this.txtprice.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txttotal_TextChanged);

#line default
#line hidden
                    return;
                case 6:
                    this.txtdiskon = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 7:
                    this.txttax = ((System.Windows.Controls.TextBox)(target));

#line 59 "..\..\..\..\Views\AccountData\Skuother.xaml"
                    this.txttax.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txttax_TextChanged);

#line default
#line hidden
                    return;
                case 8:
                    this.txttotal1 = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 9:
                    this.txttota = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 10:
                    this.txtdiskon1 = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 11:

#line 64 "..\..\..\..\Views\AccountData\Skuother.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Addsku_Clicks);

#line default
#line hidden
                    return;
                case 12:

#line 71 "..\..\..\..\Views\AccountData\Skuother.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_Clicks);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

