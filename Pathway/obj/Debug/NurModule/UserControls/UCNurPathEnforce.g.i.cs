﻿#pragma checksum "F:\Demo\pathway\Pathway\Pathway\NurModule\UserControls\UCNurPathEnforce.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C4F0B92204409CB69631346DC0B1996D"
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


namespace YidanEHRApplication.NurModule.UserControls {
    
    
    public partial class UCNurPathEnforce : System.Windows.Controls.UserControl {
        
        internal Telerik.Windows.Controls.RadBusyIndicator radBusyIndicator;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock textBlockPatient;
        
        internal Telerik.Windows.Controls.RadButton radButtonShow;
        
        internal System.Windows.Controls.TextBlock textBlockPath;
        
        internal Telerik.Windows.Controls.RadButton buttonConfirm;
        
        internal Telerik.Windows.Controls.RadButton radButtonAdviceList;
        
        internal Telerik.Windows.Controls.RadButton radbuttonViewPre;
        
        internal Telerik.Windows.Controls.RadButton radbuttonViewNext;
        
        internal System.Windows.Controls.Grid gridWorkFlowShow;
        
        internal System.Windows.Controls.HyperlinkButton hlkButtonShowPaht;
        
        internal Telerik.Windows.Controls.RadGridView radGridViewOrderList;
        
        internal System.Windows.Controls.StackPanel stpInfo;
        
        internal System.Windows.Controls.StackPanel notesInfo;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Pathway;component/NurModule/UserControls/UCNurPathEnforce.xaml", System.UriKind.Relative));
            this.radBusyIndicator = ((Telerik.Windows.Controls.RadBusyIndicator)(this.FindName("radBusyIndicator")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.textBlockPatient = ((System.Windows.Controls.TextBlock)(this.FindName("textBlockPatient")));
            this.radButtonShow = ((Telerik.Windows.Controls.RadButton)(this.FindName("radButtonShow")));
            this.textBlockPath = ((System.Windows.Controls.TextBlock)(this.FindName("textBlockPath")));
            this.buttonConfirm = ((Telerik.Windows.Controls.RadButton)(this.FindName("buttonConfirm")));
            this.radButtonAdviceList = ((Telerik.Windows.Controls.RadButton)(this.FindName("radButtonAdviceList")));
            this.radbuttonViewPre = ((Telerik.Windows.Controls.RadButton)(this.FindName("radbuttonViewPre")));
            this.radbuttonViewNext = ((Telerik.Windows.Controls.RadButton)(this.FindName("radbuttonViewNext")));
            this.gridWorkFlowShow = ((System.Windows.Controls.Grid)(this.FindName("gridWorkFlowShow")));
            this.hlkButtonShowPaht = ((System.Windows.Controls.HyperlinkButton)(this.FindName("hlkButtonShowPaht")));
            this.radGridViewOrderList = ((Telerik.Windows.Controls.RadGridView)(this.FindName("radGridViewOrderList")));
            this.stpInfo = ((System.Windows.Controls.StackPanel)(this.FindName("stpInfo")));
            this.notesInfo = ((System.Windows.Controls.StackPanel)(this.FindName("notesInfo")));
        }
    }
}
