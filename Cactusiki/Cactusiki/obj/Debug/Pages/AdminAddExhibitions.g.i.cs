﻿#pragma checksum "..\..\..\Pages\AdminAddExhibitions.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0B44681B871A24361040A8362B8F00B134CF1C85AEDB0A56C88EB50854FA0F93"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Cactusiki.Pages;
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


namespace Cactusiki.Pages {
    
    
    /// <summary>
    /// AdminAddExhibitions
    /// </summary>
    public partial class AdminAddExhibitions : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Pages\AdminAddExhibitions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtName;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\AdminAddExhibitions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtName_DateStart;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pages\AdminAddExhibitions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtName_DateEnd;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pages\AdminAddExhibitions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtCount;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\AdminAddExhibitions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAdd;
        
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
            System.Uri resourceLocater = new System.Uri("/Cactusiki;component/pages/adminaddexhibitions.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AdminAddExhibitions.xaml"
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
            this.TxtName = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\Pages\AdminAddExhibitions.xaml"
            this.TxtName.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxtName_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TxtName_DateStart = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\Pages\AdminAddExhibitions.xaml"
            this.TxtName_DateStart.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxtCount_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TxtName_DateEnd = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\..\Pages\AdminAddExhibitions.xaml"
            this.TxtName_DateEnd.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxtCount_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TxtCount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.BtnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Pages\AdminAddExhibitions.xaml"
            this.BtnAdd.Click += new System.Windows.RoutedEventHandler(this.BtnAdd_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

