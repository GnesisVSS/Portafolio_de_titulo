﻿#pragma checksum "..\..\P_pago.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1904061B833672BF625006F186FC3B2B3773EAE517C0BDE9D4DAFD11FAE7AF26"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro;
using MahApps.Metro.Accessibility;
using MahApps.Metro.Actions;
using MahApps.Metro.Automation.Peers;
using MahApps.Metro.Behaviors;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Converters;
using MahApps.Metro.Markup;
using MahApps.Metro.Theming;
using MahApps.Metro.ValueBoxes;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Portafolio;
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


namespace Portafolio {
    
    
    /// <summary>
    /// P_pago
    /// </summary>
    public partial class P_pago : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\P_pago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button boton_confirmacion;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\P_pago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPagar;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\P_pago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblMetodo;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\P_pago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboMetodo;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\P_pago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblMonto;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\P_pago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMonto;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\P_pago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVolver;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\P_pago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTituloProfesional;
        
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
            System.Uri resourceLocater = new System.Uri("/Portafolio;component/p_pago.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\P_pago.xaml"
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
            this.boton_confirmacion = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\P_pago.xaml"
            this.boton_confirmacion.Click += new System.Windows.RoutedEventHandler(this.Boton_confirmacion_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnPagar = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.lblMetodo = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.cboMetodo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.lblMonto = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.txtMonto = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnVolver = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\P_pago.xaml"
            this.btnVolver.Click += new System.Windows.RoutedEventHandler(this.BtnVolver_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lblTituloProfesional = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

