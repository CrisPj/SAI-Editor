﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAI_Editor.Database.Classes;

namespace SAI_Editor.Classes
{
    public class SmartScriptListViewItem : ListViewItem
    {
        private SmartScript _script;
        private Color _lastBackColor = Color.White;

        public SmartScriptListViewItem(string text) : base(text) { }

        public SmartScript Script
        {
            get { return _script; }
            set { _script = value; }
        }

        public Color LastBackColor
        {
            get { return _lastBackColor; }
            set { _lastBackColor = value; }
        }
    }
}
