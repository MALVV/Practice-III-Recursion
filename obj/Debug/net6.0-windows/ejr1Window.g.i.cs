﻿#pragma checksum "..\..\..\ejr1Window.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C6D57FE7B69EE259BCBA9284E42EE9925A0DE77A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Tarea_04_03;


namespace Tarea_04_03 {
    
    
    /// <summary>
    /// ejr1Window
    /// </summary>
    public partial class ejr1Window : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\ejr1Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMontoInicial;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\ejr1Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbMontoInicial;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\ejr1Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAños;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\ejr1Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbAños;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\ejr1Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView show;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\ejr1Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCalcular;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\ejr1Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReset;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Tarea_04_03;component/ejr1window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ejr1Window.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtMontoInicial = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.lbMontoInicial = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.txtAños = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.lbAños = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.show = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.btnCalcular = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\ejr1Window.xaml"
            this.btnCalcular.Click += new System.Windows.RoutedEventHandler(this.btnCalcular_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnReset = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\ejr1Window.xaml"
            this.btnReset.Click += new System.Windows.RoutedEventHandler(this.btnReset_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

