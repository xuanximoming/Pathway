﻿#pragma checksum "F:\Demo\pathway\Pathway\Pathway\WorkFlow\Designer\RuleMenu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A652C9751B54359EB027857A06BAC25E"
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


namespace YidanEHRApplication.WorkFlow.Designer {
    
    
    public partial class RuleMenu : System.Windows.Controls.UserControl {
        
        internal System.Windows.Media.Animation.Storyboard sbShowMenu;
        
        internal System.Windows.Media.Animation.Storyboard sbCloseMenu;
        
        internal System.Windows.Controls.StackPanel spContentMenu;
        
        internal System.Windows.Controls.HyperlinkButton btnShowRuleSetting;
        
        internal System.Windows.Controls.HyperlinkButton btnDelete;
        
        internal System.Windows.Controls.HyperlinkButton btnCopy;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Pathway;component/WorkFlow/Designer/RuleMenu.xaml", System.UriKind.Relative));
            this.sbShowMenu = ((System.Windows.Media.Animation.Storyboard)(this.FindName("sbShowMenu")));
            this.sbCloseMenu = ((System.Windows.Media.Animation.Storyboard)(this.FindName("sbCloseMenu")));
            this.spContentMenu = ((System.Windows.Controls.StackPanel)(this.FindName("spContentMenu")));
            this.btnShowRuleSetting = ((System.Windows.Controls.HyperlinkButton)(this.FindName("btnShowRuleSetting")));
            this.btnDelete = ((System.Windows.Controls.HyperlinkButton)(this.FindName("btnDelete")));
            this.btnCopy = ((System.Windows.Controls.HyperlinkButton)(this.FindName("btnCopy")));
        }
    }
}
