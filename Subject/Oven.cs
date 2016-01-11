using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace Subject
{
    public partial class Oven : Form, IOven
    {
        int currentTemp; 
        int desiredTemp;
        List<IPullObserver> pullObservers;
        List<IPushObserver> pushObservers;
        System.Timers.Timer timer; //timer to change the temperature of the oven

        public Oven()
        {
            InitializeComponent();
            textBox1.Text = "0";
            label2.Text = "0";
            currentTemp = 0;
            desiredTemp = 0;
            pullObservers = new List<IPullObserver>();
            pushObservers = new List<IPushObserver>();
            timer = new System.Timers.Timer(2000);
        }

        /// <summary>
        /// update the temperature of this thread safely using the InvokeRequired-method
        /// </summary>
        public void updateTemp()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(updateTemp));
                return;
            }

            label2.Text = "current temperature: " + currentTemp;
        }

        /// <summary>
        /// Attaches an observer using the pull-interface to the oven
        /// </summary>
        /// <param name="observer"></param>
        public void Attach(IPullObserver observer)
        {
            bool match = pullObservers.Contains(observer);
            if (!match)
            {
                pullObservers.Add(observer);
                label3.Text = "" + pullObservers.Count;
            }
        }

        /// <summary>
        /// Attaches an observer using the push-interface to the oven
        /// </summary>
        /// <param name="observer"></param>
        public void Attach(IPushObserver observer)
        {
            bool match = pushObservers.Contains(observer);
            if (!match)
            {
                pushObservers.Add(observer);
                label1.Text = "" + pushObservers.Count;
            }
        }

        /// <summary>
        /// Detaches a push-observer
        /// </summary>
        /// <param name="observer"></param>
        public void Detach(IPushObserver observer)
        {
            bool match = pushObservers.Contains(observer);
            if (match)
            {
                pushObservers.Remove(observer);
                label1.Text = "" + pushObservers.Count;
            }
        }

        /// <summary>
        /// Detaches a pull-observer
        /// </summary>
        /// <param name="observer"></param>
        public void Detach(IPullObserver observer)
        {
            bool match = pullObservers.Contains(observer);
            if (match)
            {
                pullObservers.Remove(observer);
                label3.Text = "" + pullObservers.Count;
            }
        }

        /// <summary>
        /// A function to update the information on all the observers attached to the oven 
        /// </summary>
        public void Notify()
        {
            foreach (IPullObserver observer in pullObservers)
            {
                observer.Update();
            }

            foreach (IPushObserver observer in pushObservers)
            {
                observer.Update(currentTemp, desiredTemp);
            }
        }

        /// <summary>
        /// Increases the temperature by 5 every time this method gets called and updates it on the subject
        /// as well as on the observers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Heat(object sender, ElapsedEventArgs e)
        {
            if (currentTemp < desiredTemp)
            {
                currentTemp = currentTemp + 5;
                Notify();
                updateTemp();
            }
        }

        public void setDesiredTemp(int temp)
        {
            this.desiredTemp = temp;
        }

        public int getTemp()
        {
            return currentTemp;
        }

        /// <summary>
        /// Create a new timer for event
        /// </summary>
        public void startHeating()
        {
            timer.Elapsed += new ElapsedEventHandler(Heat);
            timer.Enabled = true;
        }

        private void btnStartHeating_Click_1(object sender, EventArgs e)
        {
            startHeating();
        }

        private void btnSetTemp_Click_1(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(textBox1.Text);
            setDesiredTemp(temp);
        }

        private void btnAddPush_Click_1(object sender, EventArgs e)
        {
            new PushObserver(this).Show();
        }

        private void btnAddPull_Click_1(object sender, EventArgs e)
        {
            new PullObserver(this).Show();
        }
    }
}
