﻿#pragma checksum "F:\Demo\pathway\Pathway\Pathway\Views\PrintForm\RptPathEnterStatistics.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0E6A366909C6C1A8A52861BE47DFE3D5"
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


namespace YidanEHRApplication.Views.ReportForms {
    
    
    public partial class RptPathEnterStatistics : System.Windows.Controls.Page {
        
        internal Telerik.Windows.Controls.RadBusyIndicator radBusyIndicator;
        
        internal System.Windows.Controls.ScrollViewer PageScrollViewer;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.RowDefinition Row6;
        
        internal System.Windows.Controls.WrapPanel wrapPanel1;
        
        internal Telerik.Windows.Controls.RadDateTimePicker dtpStartDate;
        
        internal Telerik.Windows.Controls.RadDateTimePicker dtpEndDate;
        
        internal Telerik.Windows.Controls.RadComboBox cmbOffice;
        
        internal Telerik.Windows.Controls.RadComboBox cmbGetType;
        
        internal Telerik.Windows.Controls.RadComboBox cmbLjzt;
        
        internal System.Windows.Controls.AutoCompleteBox autoPath;
        
        internal Telerik.Windows.Controls.RadComboBox cmbBz;
        
        internal System.Windows.Controls.Button btnStat;
        
        internal System.Windows.Controls.Button btnClear;
        
        internal System.Windows.Controls.Button btnPrint;
        
        internal System.Windows.Controls.Button btnDetail;
        
        internal Telerik.Windows.Controls.RadGridView gvPathStat;
        
        internal Telerik.Windows.Controls.RadDataPager radDataPager;
        
        internal System.Windows.Controls.Expander ExpTb;
        
        internal System.Windows.Controls.Grid gridchat;
        
        internal System.Windows.Controls.RowDefinition HideRow0;
        
        internal System.Windows.Controls.RowDefinition HideRow1;
        
        internal Telerik.Windows.Controls.RadChart rctEnterPathRj;
        
        internal Telerik.Windows.Controls.RadChart rctEnterPathWc;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Pathway;component/Views/PrintForm/RptPathEnterStatistics.xaml", System.UriKind.Relative));
            this.radBusyIndicator = ((Telerik.Windows.Controls.RadBusyIndicator)(this.FindName("radBusyIndicator")));
            this.PageScrollViewer = ((System.Windows.Controls.ScrollViewer)(this.FindName("PageScrollViewer")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Row6 = ((System.Windows.Controls.RowDefinition)(this.FindName("Row6")));
            this.wrapPanel1 = ((System.Windows.Controls.WrapPanel)(this.FindName("wrapPanel1")));
            this.dtpStartDate = ((Telerik.Windows.Controls.RadDateTimePicker)(this.FindName("dtpStartDate")));
            this.dtpEndDate = ((Telerik.Windows.Controls.RadDateTimePicker)(this.FindName("dtpEndDate")));
            this.cmbOffice = ((Telerik.Windows.Controls.RadComboBox)(this.FindName("cmbOffice")));
            this.cmbGetType = ((Telerik.Windows.Controls.RadComboBox)(this.FindName("cmbGetType")));
            this.cmbLjzt = ((Telerik.Windows.Controls.RadComboBox)(this.FindName("cmbLjzt")));
            this.autoPath = ((System.Windows.Controls.AutoCompleteBox)(this.FindName("autoPath")));
            this.cmbBz = ((Telerik.Windows.Controls.RadComboBox)(this.FindName("cmbBz")));
            this.btnStat = ((System.Windows.Controls.Button)(this.FindName("btnStat")));
            this.btnClear = ((System.Windows.Controls.Button)(this.FindName("btnClear")));
            this.btnPrint = ((System.Windows.Controls.Button)(this.FindName("btnPrint")));
            this.btnDetail = ((System.Windows.Controls.Button)(this.FindName("btnDetail")));
            this.gvPathStat = ((Telerik.Windows.Controls.RadGridView)(this.FindName("gvPathStat")));
            this.radDataPager = ((Telerik.Windows.Controls.RadDataPager)(this.FindName("radDataPager")));
            this.ExpTb = ((System.Windows.Controls.Expander)(this.FindName("ExpTb")));
            this.gridchat = ((System.Windows.Controls.Grid)(this.FindName("gridchat")));
            this.HideRow0 = ((System.Windows.Controls.RowDefinition)(this.FindName("HideRow0")));
            this.HideRow1 = ((System.Windows.Controls.RowDefinition)(this.FindName("HideRow1")));
            this.rctEnterPathRj = ((Telerik.Windows.Controls.RadChart)(this.FindName("rctEnterPathRj")));
            this.rctEnterPathWc = ((Telerik.Windows.Controls.RadChart)(this.FindName("rctEnterPathWc")));
        }
    }
}
