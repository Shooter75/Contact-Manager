﻿#pragma checksum "..\..\..\UIL\AddContactToOtherGroupUIL.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0EFC0A078CA30F07F380EBD2982B74CD"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FirstFloor.ModernUI.Presentation;
using FirstFloor.ModernUI.Windows;
using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.Windows.Converters;
using FirstFloor.ModernUI.Windows.Navigation;
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
using Xceed.Wpf.Toolkit;


namespace ContactManagerArchitecture1.UIL {
    
    
    /// <summary>
    /// AddContactToOtherGroupUIL
    /// </summary>
    public partial class AddContactToOtherGroupUIL : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\UIL\AddContactToOtherGroupUIL.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ContactList_CB;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\UIL\AddContactToOtherGroupUIL.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox GroupList_CB;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\UIL\AddContactToOtherGroupUIL.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddGroupRelation_B;
        
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
            System.Uri resourceLocater = new System.Uri("/ContactManagerArchitecture1;component/uil/addcontacttoothergroupuil.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UIL\AddContactToOtherGroupUIL.xaml"
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
            this.ContactList_CB = ((System.Windows.Controls.ComboBox)(target));
            
            #line 13 "..\..\..\UIL\AddContactToOtherGroupUIL.xaml"
            this.ContactList_CB.Loaded += new System.Windows.RoutedEventHandler(this.ContactList_CB_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GroupList_CB = ((System.Windows.Controls.ComboBox)(target));
            
            #line 14 "..\..\..\UIL\AddContactToOtherGroupUIL.xaml"
            this.GroupList_CB.Loaded += new System.Windows.RoutedEventHandler(this.GroupList_CB_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AddGroupRelation_B = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\UIL\AddContactToOtherGroupUIL.xaml"
            this.AddGroupRelation_B.Click += new System.Windows.RoutedEventHandler(this.AddGroupRelation_B_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

