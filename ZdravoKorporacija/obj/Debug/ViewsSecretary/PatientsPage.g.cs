#pragma checksum "..\..\..\ViewsSecretary\PatientsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DF70E96C2D031EC08E1089F7C91D66B992403AF297CF47B160C8E46C0B677952"
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
    /// PatientsPage
    /// </summary>
    public partial class PatientsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\ViewsSecretary\PatientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox area;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\ViewsSecretary\PatientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox new_patient_register;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\ViewsSecretary\PatientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvUsers;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\ViewsSecretary\PatientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox firstAndLastName;
        
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
            System.Uri resourceLocater = new System.Uri("/ZdravoKorporacija;component/viewssecretary/patientspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ViewsSecretary\PatientsPage.xaml"
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
            
            #line 48 "..\..\..\ViewsSecretary\PatientsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Home_page);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 50 "..\..\..\ViewsSecretary\PatientsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.View_appointments);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 51 "..\..\..\ViewsSecretary\PatientsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.View_rooms);
            
            #line default
            #line hidden
            return;
            case 5:
            this.new_patient_register = ((System.Windows.Controls.ComboBox)(target));
            
            #line 52 "..\..\..\ViewsSecretary\PatientsPage.xaml"
            this.new_patient_register.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 57 "..\..\..\ViewsSecretary\PatientsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.View_graphs);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 58 "..\..\..\ViewsSecretary\PatientsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BulletinBoard);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 59 "..\..\..\ViewsSecretary\PatientsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Emergency_appointment);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 60 "..\..\..\ViewsSecretary\PatientsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.View_profile);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 61 "..\..\..\ViewsSecretary\PatientsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Log_out);
            
            #line default
            #line hidden
            return;
            case 11:
            this.lvUsers = ((System.Windows.Controls.ListView)(target));
            return;
            case 12:
            
            #line 83 "..\..\..\ViewsSecretary\PatientsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Search_patient);
            
            #line default
            #line hidden
            return;
            case 13:
            this.firstAndLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            
            #line 86 "..\..\..\ViewsSecretary\PatientsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.delete_patient);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 87 "..\..\..\ViewsSecretary\PatientsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.details_patient);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

