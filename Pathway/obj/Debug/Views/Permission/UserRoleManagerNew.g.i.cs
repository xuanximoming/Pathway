﻿#pragma checksum "F:\Demo\pathway\Pathway\Pathway\Views\Permission\UserRoleManagerNew.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C4964FE6D7CFDF0AFDF595F4B05420C9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace YidanEHRApplication.Views.Permission {
    
    
    public partial class UserRoleManagerNew : System.Windows.Controls.Page {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Telerik.Windows.Controls.RadTabControl radTabControlPathManager;
        
        internal Telerik.Windows.Controls.RadGridView GridView;
        
        internal Telerik.Windows.Controls.RadButton btnDel;
        
        internal Telerik.Windows.Controls.RadButton btnUpdate;
        
        internal Telerik.Windows.Controls.RadButton btnAdd;
        
        internal Telerik.Windows.Controls.RadButton btnClear;
        
        internal Telerik.Windows.Controls.RadButton btnSave;
        
        internal Telerik.Windows.Controls.RadButton btnTxtClear;
        
        internal System.Windows.Controls.TextBlock textBlock0;
        
        internal System.Windows.Controls.TextBlock textBlock1;
        
        internal System.Windows.Controls.TextBlock textBlock2;
        
        internal Telerik.Windows.Controls.RadComboBox cbxUser;
        
        internal Telerik.Windows.Controls.RadComboBox cbxRole;
        
        internal Telerik.Windows.Controls.RadGridView GridViewRole;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Pathway;component/Views/Permission/UserRoleManagerNew.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.radTabControlPathManager = ((Telerik.Windows.Controls.RadTabControl)(this.FindName("radTabControlPathManager")));
            this.GridView = ((Telerik.Windows.Controls.RadGridView)(this.FindName("GridView")));
            this.btnDel = ((Telerik.Windows.Controls.RadButton)(this.FindName("btnDel")));
            this.btnUpdate = ((Telerik.Windows.Controls.RadButton)(this.FindName("btnUpdate")));
            this.btnAdd = ((Telerik.Windows.Controls.RadButton)(this.FindName("btnAdd")));
            this.btnClear = ((Telerik.Windows.Controls.RadButton)(this.FindName("btnClear")));
            this.btnSave = ((Telerik.Windows.Controls.RadButton)(this.FindName("btnSave")));
            this.btnTxtClear = ((Telerik.Windows.Controls.RadButton)(this.FindName("btnTxtClear")));
            this.textBlock0 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock0")));
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock1")));
            this.textBlock2 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock2")));
            this.cbxUser = ((Telerik.Windows.Controls.RadComboBox)(this.FindName("cbxUser")));
            this.cbxRole = ((Telerik.Windows.Controls.RadComboBox)(this.FindName("cbxRole")));
            this.GridViewRole = ((Telerik.Windows.Controls.RadGridView)(this.FindName("GridViewRole")));
        }
    }
}
