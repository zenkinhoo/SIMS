﻿#pragma checksum "..\..\..\ViewsSecretary\AppointmentsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4C5451199B79B94B6B7A021BE1CCDCFD7D2FD6A1C8651CF53DA11A3A4D13AAEB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bolnica.ViewsSecretary;
using FontAwesome.WPF;
using FontAwesome.WPF.Converters;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace Bolnica.ViewsSecretary {
    
    
    /// <summary>
    /// AppointmentsPage
    /// </summary>
    public partial class AppointmentsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\ViewsSecretary\AppointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox area;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\ViewsSecretary\AppointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox new_patient_register;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\ViewsSecretary\AppointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvAppointmnets;
        
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
            System.Uri resourceLocater = new System.Uri("/ZdravoKorporacija;component/viewssecretary/appointmentspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ViewsSecretary\AppointmentsPage.xaml"
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
            this.area = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            
            #line 48 "..\..\..\ViewsSecretary\AppointmentsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Home_page);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 49 "..\..\..\ViewsSecretary\AppointmentsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.View_patients);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 50 "..\..\..\ViewsSecretary\AppointmentsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.View_appointments);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 51 "..\..\..\ViewsSecretary\AppointmentsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.View_rooms);
            
            #line default
            #line hidden
            return;
            case 6:
            this.new_patient_register = ((System.Windows.Controls.ComboBox)(target));
            
            #line 52 "..\..\..\ViewsSecretary\AppointmentsPage.xaml"
            this.new_patient_register.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 57 "..\..\..\ViewsSecretary\AppointmentsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.View_graphs);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 58 "..\..\..\ViewsSecretary\AppointmentsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BulletinBoard);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 59 "..\..\..\ViewsSecretary\AppointmentsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emergency_appointment);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 61 "..\..\..\ViewsSecretary\AppointmentsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.View_profile);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 62 "..\..\..\ViewsSecretary\AppointmentsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Log_out);
            
            #line default
            #line hidden
            return;
            case 12:
            this.lvAppointmnets = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

