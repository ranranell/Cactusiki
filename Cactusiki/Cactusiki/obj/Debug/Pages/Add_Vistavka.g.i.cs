﻿#pragma checksum "..\..\..\Pages\Add_Vistavka.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "54B1A66DB44FDA8183AD9466D6A1FDF34DA0897485E123D3BCA89D92E0C46576"
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
    /// Add_Vistavka
    /// </summary>
    public partial class Add_Vistavka : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\Pages\Add_Vistavka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image IPicture;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\Add_Vistavka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddImage;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\Add_Vistavka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtCode;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\Add_Vistavka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtName;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Pages\Add_Vistavka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtName_Копировать;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Pages\Add_Vistavka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtName_Копировать1;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Pages\Add_Vistavka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbxCategory;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Pages\Add_Vistavka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtCount;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Pages\Add_Vistavka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAdd;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Pages\Add_Vistavka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBack;
        
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
            System.Uri resourceLocater = new System.Uri("/Cactusiki;component/pages/add_vistavka.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Add_Vistavka.xaml"
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
            this.IPicture = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.BtnAddImage = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Pages\Add_Vistavka.xaml"
            this.BtnAddImage.Click += new System.Windows.RoutedEventHandler(this.BtnAddImage_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TxtCode = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\..\Pages\Add_Vistavka.xaml"
            this.TxtCode.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxtCode_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TxtName = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\..\Pages\Add_Vistavka.xaml"
            this.TxtName.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxtName_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TxtName_Копировать = ((System.Windows.Controls.TextBox)(target));
            
            #line 43 "..\..\..\Pages\Add_Vistavka.xaml"
            this.TxtName_Копировать.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxtName_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TxtName_Копировать1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 47 "..\..\..\Pages\Add_Vistavka.xaml"
            this.TxtName_Копировать1.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxtName_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CmbxCategory = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.TxtCount = ((System.Windows.Controls.TextBox)(target));
            
            #line 61 "..\..\..\Pages\Add_Vistavka.xaml"
            this.TxtCount.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxtCount_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\Pages\Add_Vistavka.xaml"
            this.BtnAdd.Click += new System.Windows.RoutedEventHandler(this.BtnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BtnBack = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\Pages\Add_Vistavka.xaml"
            this.BtnBack.Click += new System.Windows.RoutedEventHandler(this.BtnBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

