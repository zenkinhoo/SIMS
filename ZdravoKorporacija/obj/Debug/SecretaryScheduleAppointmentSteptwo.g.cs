﻿#pragma checksum "..\..\SecretaryScheduleAppointmentSteptwo.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3CDDAAD3F66632C757F2B9BBDCB69DF60B15A8B99F1C1C613CBE7AAF207631B4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bolnica;
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


namespace Bolnica {
    
    
    /// <summary>
    /// SecretaryScheduleAppointmentSteptwo
    /// </summary>
    public partial class SecretaryScheduleAppointmentSteptwo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\SecretaryScheduleAppointmentSteptwo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox infoPatient;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\SecretaryScheduleAppointmentSteptwo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelRoom;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\SecretaryScheduleAppointmentSteptwo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboRoom;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\SecretaryScheduleAppointmentSteptwo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox slobodnitermini;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\SecretaryScheduleAppointmentSteptwo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox infoDoctor;
        
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
            System.Uri resourceLocater = new System.Uri("/ZdravoKorporacija;component/secretaryscheduleappointmentsteptwo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SecretaryScheduleAppointmentSteptwo.xaml"
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
            this.infoPatient = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            
            #line 14 "..\..\SecretaryScheduleAppointmentSteptwo.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.chooseOperation);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 15 "..\..\SecretaryScheduleAppointmentSteptwo.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.chooseExemination);
            
            #line default
            #line hidden
            return;
            case 4:
            this.labelRoom = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.comboRoom = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            
            #line 19 "..\..\SecretaryScheduleAppointmentSteptwo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.slobodnitermini = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.infoDoctor = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
