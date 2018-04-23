using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace WindowsApplication1
{
    public class MyObject
    {

        public MyObject()
        {

        }

        private int _ID;
        public int ID
        {
            get { return _ID; }
            set
            {
                _ID = value;
            }
        }

        private object _DisplayText;
        public object DisplayText
        {
            get { return _DisplayText; }
            set { _DisplayText = value; }
        }
    }
}
