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
    public partial class PushObserver : Form, IPushObserver
    {
        Oven oven;
        int desiredTemp;
        private delegate void SetLabelSub(int temp, int maxTemp);

        /// <summary>
        /// Take a reference to the subject as parameter for the constructor
        /// </summary>
        /// <param name="oven"></param>
        public PushObserver(Oven oven)
        {
            InitializeComponent();
            this.oven = oven;
        }

        /// <summary>
        /// Receives all the parameters defined to the observer from the subject
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="maxTemp"></param>
        public void Update(int temp, int maxTemp)
        {
            if (this.InvokeRequired)
            {
                SetLabelSub Del = new SetLabelSub(Update);
                this.Invoke(Del, new object[] { temp, maxTemp });
            }
            else
            {
                label2.Text = "" + temp;
                this.desiredTemp = maxTemp;
                label4.Text = "" + desiredTemp;
                this.progressBar1.Value = temp;
                this.progressBar1.Maximum = this.desiredTemp;
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
