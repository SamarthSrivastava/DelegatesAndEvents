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
    public partial class PassingValuesSecondForm : Form
    {
        string valueToBeAssigned = null;

        public delegate void PassesValueHandler(object sender, CustomTypeEventArgs e);
        public event PassesValueHandler passValueEvent;

        public PassingValuesSecondForm()
        {
            InitializeComponent();

            passValueEvent += PassingValuesSecondForm_passValueEvent;
            passValueEvent(this, CustomTypeEventArgs.GetCustomTypeEventArgs());
        }

        public void PassingValuesSecondForm_passValueEvent(object sender, CustomTypeEventArgs e)
        {
            //this value which was loaded in the previous form is available to be used in this form from the start
            //as the local variable was assigned the very same value as loaded in the previous form in the constructor of the form.
            valueToBeAssigned = e.stringProperty;
        }
    }
}
