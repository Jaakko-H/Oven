using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Subject
{
    public partial class PullObserver : Form, IPullObserver
    {
        Oven oven;
        private delegate void SetLabelSub();

        /// <summary>
        /// Take a reference to the subject as parameter for the constructor
        /// </summary>
        /// <param name="oven"></param>
        public PullObserver(Oven oven)
        {
            InitializeComponent();
            this.oven = oven;
        }

        /// <summary>
        /// Safely update the label on this form
        /// Update the label with the current temperature that is fetched from the subject by the observer
        /// </summary>
        public void Update()
        {
            if (this.InvokeRequired)
            {
                SetLabelSub Del = new SetLabelSub(Update);
                this.Invoke(Del, new object[] { });
            }
            else
            {
                label2.Text = Convert.ToString(oven.getTemp());
            }
        }

       

        private void btnAttach_Click(object sender, EventArgs e)
        {
            oven.Attach(this);
        }

        private void btnDetach_Click(object sender, EventArgs e)
        {
            oven.Detach(this);
        }

       
    }
}
