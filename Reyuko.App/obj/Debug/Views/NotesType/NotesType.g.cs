﻿#pragma checksum "..\..\..\..\Views\NotesType\NotesType.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AEC414909CE770EB423B3DC41D2A2EE15EE1BE5F97628C0AC6463BD4D4AEED0C"
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


namespace Reyuko.App.Views.NotesType {
    
    
    /// <summary>
    /// NotesType
    /// </summary>
    public partial class NotesType : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 78 "..\..\..\..\Views\NotesType\NotesType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGNotesType;
        
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
            System.Uri resourceLocater = new System.Uri("/Reyuko.App;component/views/notestype/notestype.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\NotesType\NotesType.xaml"
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
            
            #line 48 "..\..\..\..\Views\NotesType\NotesType.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 55 "..\..\..\..\Views\NotesType\NotesType.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.playtutorial_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 64 "..\..\..\..\Views\NotesType\NotesType.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NewNotesType_Clicks);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 71 "..\..\..\..\Views\NotesType\NotesType.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditNotesType_Clicks);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DGNotesType = ((System.Windows.Controls.DataGrid)(target));
            
            #line 94 "..\..\..\..\Views\NotesType\NotesType.xaml"
            this.DGNotesType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DGNoteType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

