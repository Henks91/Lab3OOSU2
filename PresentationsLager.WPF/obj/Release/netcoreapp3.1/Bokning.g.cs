<<<<<<< HEAD
﻿#pragma checksum "..\..\..\Bokning.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F116E8B7776AC312CCFC63F985875F64685CAA79"
=======
﻿#pragma checksum "..\..\..\Bokning.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03A9C39FE17EE960B15BDAB4BEBE91DF05C0B24D"
>>>>>>> origin/Calle
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
    /// Bokning
    /// </summary>
    public partial class Bokning : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\Bokning.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxMedlemsNr;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Bokning.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnVisaTillgängligaBöcker;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Bokning.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgValdaBöckerBokning;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Bokning.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgTillgängligaBöcker;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Bokning.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBokaBöcker;
        
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
            System.Uri resourceLocater = new System.Uri("/PresentationsLager.WPF;component/bokning.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Bokning.xaml"
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
            this.TextBoxMedlemsNr = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.BtnVisaTillgängligaBöcker = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.dgValdaBöckerBokning = ((System.Windows.Controls.DataGrid)(target));
            
            #line 35 "..\..\..\Bokning.xaml"
            this.dgValdaBöckerBokning.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgValdaBöcker_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dgTillgängligaBöcker = ((System.Windows.Controls.DataGrid)(target));
            
            #line 42 "..\..\..\Bokning.xaml"
            this.dgTillgängligaBöcker.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgTillgängligaBöcker_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnBokaBöcker = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

