﻿#pragma checksum "..\..\P_GestionContrato.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3990F3792C48B51D8A5B950BE63E82DBFE30AC58A46A07A2FD0BB163E5B87371"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// P_GestionContrato
    /// </summary>
    public partial class P_GestionContrato : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\P_GestionContrato.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button boton_confirmacion;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\P_GestionContrato.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgContrato;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\P_GestionContrato.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblRunCliente;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\P_GestionContrato.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRunCliente;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\P_GestionContrato.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblFiltro;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\P_GestionContrato.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmpresa;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\P_GestionContrato.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBuscar;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\P_GestionContrato.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelar;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\P_GestionContrato.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelar2;
        
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
            System.Uri resourceLocater = new System.Uri("/Portafolio;component/p_gestioncontrato.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\P_GestionContrato.xaml"
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
            
            #line 25 "..\..\P_GestionContrato.xaml"
            this.boton_confirmacion.Click += new System.Windows.RoutedEventHandler(this.Boton_confirmacion_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dgContrato = ((System.Windows.Controls.DataGrid)(target));
            
            #line 33 "..\..\P_GestionContrato.xaml"
            this.dgContrato.Loaded += new System.Windows.RoutedEventHandler(this.dtgContratos_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lblRunCliente = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txtRunCliente = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\P_GestionContrato.xaml"
            this.txtRunCliente.KeyDown += new System.Windows.Input.KeyEventHandler(this.txtRunCliente_KeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lblFiltro = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.txtEmpresa = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnBuscar = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\P_GestionContrato.xaml"
            this.btnBuscar.Click += new System.Windows.RoutedEventHandler(this.btnBuscar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\P_GestionContrato.xaml"
            this.btnCancelar.Click += new System.Windows.RoutedEventHandler(this.btnCancelar_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnCancelar2 = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\P_GestionContrato.xaml"
            this.btnCancelar2.Click += new System.Windows.RoutedEventHandler(this.btnCancelar2_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

