#pragma checksum "..\..\..\ViewsSecretary\CreateEmergencyAppointment.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BCA8E5A621C8C40C0E7CBED27F3A9576B0D907EE2AC49F3EF6F521B9F9A51242"
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
    /// CreateEmergencyAppointment
    /// </summary>
    public partial class CreateEmergencyAppointment : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\ViewsSecretary\CreateEmergencyAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox area;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\ViewsSecretary\CreateEmergencyAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox new_patient_register;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\ViewsSecretary\CreateEmergencyAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox firstAndLastName;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\ViewsSecretary\CreateEmergencyAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox doctorType;
        
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
            System.Uri resourceLocater = new System.Uri("/ZdravoKorporacija;component/viewssecretary/createemergencyappointment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ViewsSecretary\CreateEmergencyAppointment.xaml"
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
            
            #line 49 "..\..\..\ViewsSecretary\CreateEmergencyAppointment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Home_page);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 50 "..\..\..\ViewsSecretary\CreateEmergencyAppointment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.View_patients);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 51 "..\..\..\ViewsSecretary\CreateEmergencyAppointment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.View_appointments);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 52 "..\..\..\ViewsSecretary\CreateEmergencyAppointment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.View_rooms);
            
            #line default
            #line hidden
            return;
            case 6:
            this.new_patient_register = ((System.Windows.Controls.ComboBox)(target));
            
            #line 53 "..\..\..\ViewsSecretary\CreateEmergencyAppointment.xaml"
            this.new_patient_register.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 58 "..\..\..\ViewsSecretary\CreateEmergencyAppointment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.View_graphs);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 59 "..\..\..\ViewsSecretary\CreateEmergencyAppointment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BulletinBoard);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 60 "..\..\..\ViewsSecretary\CreateEmergencyAppointment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emergency_appointment);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 62 "..\..\..\ViewsSecretary\CreateEmergencyAppointment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.View_profile);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 63 "..\..\..\ViewsSecretary\CreateEmergencyAppointment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Log_out);
            
            #line default
            #line hidden
            return;
            case 12:
            this.firstAndLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            
            #line 75 "..\..\..\ViewsSecretary\CreateEmergencyAppointment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Is_patient_exist);
            
            #line default
            #line hidden
            return;
            case 14:
            this.doctorType = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            
            #line 78 "..\..\..\ViewsSecretary\CreateEmergencyAppointment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Schedule_appointment);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 79 "..\..\..\ViewsSecretary\CreateEmergencyAppointment.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.chooseOperation);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 80 "..\..\..\ViewsSecretary\CreateEmergencyAppointment.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.chooseExemination);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

