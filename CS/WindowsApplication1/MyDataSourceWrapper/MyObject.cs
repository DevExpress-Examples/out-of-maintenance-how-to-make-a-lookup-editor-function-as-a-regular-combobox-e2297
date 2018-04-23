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

        private object _Value;
        public object Value
        {
            get { return _Value; }
            set { _Value = value; }
        }
    }
}
