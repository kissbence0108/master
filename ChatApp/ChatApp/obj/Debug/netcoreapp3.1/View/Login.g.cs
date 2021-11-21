﻿#pragma checksum "..\..\..\..\View\Login.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92DA8403D5E28B4432BAEAF2830F122734D6211E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ChatApp;
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


namespace ChatApp.View {
    
    
    /// <summary>
    /// Login
    /// </summary>
    public partial class Login : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 94 "..\..\..\..\View\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginUser;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\..\View\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox LoginPasswordBox;
        
        #line default
        #line hidden
        
        
        #line 175 "..\..\..\..\View\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTestConnection;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\..\..\View\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogin;
        
        #line default
        #line hidden
        
        
        #line 208 "..\..\..\..\View\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Register_Page;
        
        #line default
        #line hidden
        
        
        #line 219 "..\..\..\..\View\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exitBttn;
        
        #line default
        #line hidden
        
        
        #line 233 "..\..\..\..\View\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RegisterUser;
        
        #line default
        #line hidden
        
        
        #line 234 "..\..\..\..\View\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RegisterPass;
        
        #line default
        #line hidden
        
        
        #line 235 "..\..\..\..\View\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RegisterPassC;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ChatApp;component/view/login.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Login.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 12 "..\..\..\..\View\Login.xaml"
            ((ChatApp.View.Login)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LoginUser = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.LoginPasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 138 "..\..\..\..\View\Login.xaml"
            this.LoginPasswordBox.PasswordChanged += new System.Windows.RoutedEventHandler(this.LoginPassword_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnTestConnection = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.btnLogin = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.Register_Page = ((System.Windows.Controls.Button)(target));
            
            #line 215 "..\..\..\..\View\Login.xaml"
            this.Register_Page.Click += new System.Windows.RoutedEventHandler(this.Register_Page_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.exitBttn = ((System.Windows.Controls.Button)(target));
            
            #line 226 "..\..\..\..\View\Login.xaml"
            this.exitBttn.Click += new System.Windows.RoutedEventHandler(this.exitBttn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.RegisterUser = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.RegisterPass = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.RegisterPassC = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

