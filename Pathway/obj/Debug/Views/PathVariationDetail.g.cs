﻿#pragma checksum "F:\Demo\pathway\Pathway\Pathway\Views\PathVariationDetail.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3FD54920F40F89CC60C6E4BB6A8D4C98"
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


namespace YidanEHRApplication.Views {
    
    
    public partial class PathVariationDetail : System.Windows.Controls.Page {
        
        internal Telerik.Windows.Controls.RadBusyIndicator radBusyIndicator;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid Main;
        
        internal Telerik.Windows.Controls.RadComboBox cbxVQueryType;
        
        internal Telerik.Windows.Controls.RadComboBox cbxVariationType;
        
        internal Telerik.Windows.Controls.RadComboBox cbxQueryCodeType;
        
        internal Telerik.Windows.Controls.RadComboBox cbxQueryCodeState;
        
        internal System.Windows.Controls.TextBox txtCode;
        
        internal System.Windows.Controls.Button btnQueryCode;
        
        internal System.Windows.Controls.Button btnClearCode;
        
        internal Telerik.Windows.Controls.RadGridView GridViewPathVariation;
        
        internal System.Windows.Controls.CheckBox checkBoxAll;
        
        internal Telerik.Windows.Controls.GridViewDataColumn State;
        
        internal Telerik.Windows.Controls.RadDataPager radDataPager;
        
        internal System.Windows.Controls.Button btnClassCode;
        
        internal System.Windows.Controls.Button btnEnableCode;
        
        internal System.Windows.Controls.Button btnDisableCode;
        
        internal Telerik.Windows.Controls.GroupBox groupBox1;
        
        internal System.Windows.Controls.Button btnCreateCode;
        
        internal System.Windows.Controls.Button btnTxtClear;
        
        internal Telerik.Windows.Controls.RadDropDownButton ddbBydm;
        
        internal Telerik.Windows.Controls.RadTreeView TreeView;
        
        internal System.Windows.Controls.TextBox txtBydm;
        
        internal System.Windows.Controls.TextBox txtByms;
        
        internal System.Windows.Controls.TextBox txtBymc;
        
        internal System.Windows.Controls.TextBox txtPym;
        
        internal System.Windows.Controls.Label label3;
        
        internal System.Windows.Controls.Label label1;
        
        internal System.Windows.Controls.Label label2;
        
        internal System.Windows.Controls.Label label4;
        
        internal System.Windows.Controls.Label label5;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Pathway;component/Views/PathVariationDetail.xaml", System.UriKind.Relative));
            this.radBusyIndicator = ((Telerik.Windows.Controls.RadBusyIndicator)(this.FindName("radBusyIndicator")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Main = ((System.Windows.Controls.Grid)(this.FindName("Main")));
            this.cbxVQueryType = ((Telerik.Windows.Controls.RadComboBox)(this.FindName("cbxVQueryType")));
            this.cbxVariationType = ((Telerik.Windows.Controls.RadComboBox)(this.FindName("cbxVariationType")));
            this.cbxQueryCodeType = ((Telerik.Windows.Controls.RadComboBox)(this.FindName("cbxQueryCodeType")));
            this.cbxQueryCodeState = ((Telerik.Windows.Controls.RadComboBox)(this.FindName("cbxQueryCodeState")));
            this.txtCode = ((System.Windows.Controls.TextBox)(this.FindName("txtCode")));
            this.btnQueryCode = ((System.Windows.Controls.Button)(this.FindName("btnQueryCode")));
            this.btnClearCode = ((System.Windows.Controls.Button)(this.FindName("btnClearCode")));
            this.GridViewPathVariation = ((Telerik.Windows.Controls.RadGridView)(this.FindName("GridViewPathVariation")));
            this.checkBoxAll = ((System.Windows.Controls.CheckBox)(this.FindName("checkBoxAll")));
            this.State = ((Telerik.Windows.Controls.GridViewDataColumn)(this.FindName("State")));
            this.radDataPager = ((Telerik.Windows.Controls.RadDataPager)(this.FindName("radDataPager")));
            this.btnClassCode = ((System.Windows.Controls.Button)(this.FindName("btnClassCode")));
            this.btnEnableCode = ((System.Windows.Controls.Button)(this.FindName("btnEnableCode")));
            this.btnDisableCode = ((System.Windows.Controls.Button)(this.FindName("btnDisableCode")));
            this.groupBox1 = ((Telerik.Windows.Controls.GroupBox)(this.FindName("groupBox1")));
            this.btnCreateCode = ((System.Windows.Controls.Button)(this.FindName("btnCreateCode")));
            this.btnTxtClear = ((System.Windows.Controls.Button)(this.FindName("btnTxtClear")));
            this.ddbBydm = ((Telerik.Windows.Controls.RadDropDownButton)(this.FindName("ddbBydm")));
            this.TreeView = ((Telerik.Windows.Controls.RadTreeView)(this.FindName("TreeView")));
            this.txtBydm = ((System.Windows.Controls.TextBox)(this.FindName("txtBydm")));
            this.txtByms = ((System.Windows.Controls.TextBox)(this.FindName("txtByms")));
            this.txtBymc = ((System.Windows.Controls.TextBox)(this.FindName("txtBymc")));
            this.txtPym = ((System.Windows.Controls.TextBox)(this.FindName("txtPym")));
            this.label3 = ((System.Windows.Controls.Label)(this.FindName("label3")));
            this.label1 = ((System.Windows.Controls.Label)(this.FindName("label1")));
            this.label2 = ((System.Windows.Controls.Label)(this.FindName("label2")));
            this.label4 = ((System.Windows.Controls.Label)(this.FindName("label4")));
            this.label5 = ((System.Windows.Controls.Label)(this.FindName("label5")));
        }
    }
}
