﻿#pragma checksum "..\..\SecretaryScheduleAppointments.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9AA164ABD8205056493B024ABD61B3AC5A6DD644AFC37711CCBFD1568FF5DC8B"
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
    /// SecretaryScheduleAppointments
    /// </summary>
    public partial class SecretaryScheduleAppointments : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\SecretaryScheduleAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox dataPatient;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\SecretaryScheduleAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton prvi;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\SecretaryScheduleAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton drugi;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\SecretaryScheduleAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker startTime;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\SecretaryScheduleAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combo;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\SecretaryScheduleAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox startTimeHours;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\SecretaryScheduleAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox endTimeHours;
        
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
            System.Uri resourceLocater = new System.Uri("/ZdravoKorporacija;component/secretaryscheduleappointments.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SecretaryScheduleAppointments.xaml"
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
            this.dataPatient = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.prvi = ((System.Windows.Controls.RadioButton)(target));
            
            #line 15 "..\..\SecretaryScheduleAppointments.xaml"
            this.prvi.Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.drugi = ((System.Windows.Controls.RadioButton)(target));
            
            #line 16 "..\..\SecretaryScheduleAppointments.xaml"
            this.drugi.Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.startTime = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.combo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            
            #line 20 "..\..\SecretaryScheduleAppointments.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.startTimeHours = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.endTimeHours = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 23 "..\..\SecretaryScheduleAppointments.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

