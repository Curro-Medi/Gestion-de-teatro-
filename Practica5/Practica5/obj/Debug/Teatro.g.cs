﻿#pragma checksum "..\..\Teatro.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "08ECA169B4C7C4E459FC661F04FDC57F144F6587348EC758E1E8168927071A9C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Practica5;
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


namespace Practica5 {
    
    
    /// <summary>
    /// Teatro
    /// </summary>
    public partial class Teatro : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\Teatro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridSala;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Teatro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Comprar;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Teatro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Anularreserva;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Teatro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Anularcompra;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Teatro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Reservar;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Teatro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Salir;
        
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
            System.Uri resourceLocater = new System.Uri("/Practica5;component/teatro.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Teatro.xaml"
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
            this.GridSala = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Comprar = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Teatro.xaml"
            this.Comprar.Click += new System.Windows.RoutedEventHandler(this.Comprar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Anularreserva = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Teatro.xaml"
            this.Anularreserva.Click += new System.Windows.RoutedEventHandler(this.Anularreserva_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Anularcompra = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Teatro.xaml"
            this.Anularcompra.Click += new System.Windows.RoutedEventHandler(this.Anularcompra_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Reservar = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Teatro.xaml"
            this.Reservar.Click += new System.Windows.RoutedEventHandler(this.Reservar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Salir = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Teatro.xaml"
            this.Salir.Click += new System.Windows.RoutedEventHandler(this.Salir_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

