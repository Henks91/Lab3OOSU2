﻿#pragma checksum "..\..\..\HuvudMeny.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0F5F6616D5940ED2F4835189158F380F41840C57"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PresentationsLager.WPF;
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


namespace PresentationsLager.WPF {
    
    
    /// <summary>
    /// HuvudMeny
    /// </summary>
    public partial class HuvudMeny : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\HuvudMeny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBokaBok;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\HuvudMeny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnHämtaBokning;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\HuvudMeny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnÅterlämning;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\HuvudMeny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnLoggaUt;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PresentationsLager.WPF;V1.0.0.0;component/huvudmeny.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\HuvudMeny.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BtnBokaBok = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\HuvudMeny.xaml"
            this.BtnBokaBok.Click += new System.Windows.RoutedEventHandler(this.BtnBokaBok_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnHämtaBokning = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\HuvudMeny.xaml"
            this.BtnHämtaBokning.Click += new System.Windows.RoutedEventHandler(this.BtnHämtaBokning_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnÅterlämning = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\HuvudMeny.xaml"
            this.BtnÅterlämning.Click += new System.Windows.RoutedEventHandler(this.BtnÅterlämning_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnLoggaUt = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\HuvudMeny.xaml"
            this.BtnLoggaUt.Click += new System.Windows.RoutedEventHandler(this.BtnLoggaUt_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

