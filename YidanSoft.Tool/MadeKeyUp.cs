﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace YidanSoft.Tool
{
    public class MadeKeyUp
    {
        /// <summary>
        /// 生成KeyUp事件
        /// </summary>
        public void Made_KeyUp()
        {
            for (int i = 0; i < Controls.Count - 1; i++)
            {
                Control control1 = Controls[i];
                Control control2 = Controls[i + 1];
                control1.KeyUp += new KeyEventHandler((obj, e) =>
                {
                    if (e.Key == Key.Enter)
                    {
                        control2.Focus();
                    }
                });
            }
        }

        /// <summary>
        /// 控件列表
        /// </summary>
        public List<Control> Controls = new List<Control>();
    }
}