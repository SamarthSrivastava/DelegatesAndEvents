using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatesEvents
{
    public partial class PassingValuesMainForm : Form
    {
        public PassingValuesMainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sIdentifier = AssignValueToVariable();

            CustomTypeEventArgs paramContainingUpdatedVariable = CustomTypeEventArgs.GetCustomTypeEventArgs();
            paramContainingUpdatedVariable.stringProperty = sIdentifier;

            PassingValuesSecondForm obj = new PassingValuesSecondForm();
            obj.Show();
        }

        public string AssignValueToVariable()
        {
            string obj = "ABCDEFGHIKLMNOPQRSTUVWXYZ"; //use data source or any other way
            return obj;
        }
    }

    public class CustomTypeEventArgs : System.EventArgs
    {
        public static CustomTypeEventArgs instance = null;
        private string str;

        private CustomTypeEventArgs() { }

        public static CustomTypeEventArgs GetCustomTypeEventArgs()
        {
            if (instance == null)
                instance = new CustomTypeEventArgs();

            return instance;
        }

        public string stringProperty
        {
            get { return str; }
            set { str = value; }
        }
    }
}