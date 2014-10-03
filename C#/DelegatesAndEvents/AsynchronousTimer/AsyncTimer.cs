using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousTimer
{
    class AsyncTimer
    {
        private int ticks;
        private int t;

        private Action tik;

        public AsyncTimer(Action func, int ticks, int t)
        {
            this.T = t;
            this.Ticks = ticks;
            this.tik = func;
            this.OnTick(EventArgs.Empty);
        }

        public int Ticks
        {
            get { return this.ticks; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The value cannot less than 0");
                }
                this.ticks = value;
            }
        }

        public virtual void OnTick(EventArgs e)
        {
            if (null != this.tik)
            {
                Thread newThread = new Thread(() =>
                {
                    int passedTicks = 0;
                    while (passedTicks < this.T)
                    {
                        this.tik();
                        passedTicks++;
                        Thread.Sleep(this.Ticks);
                    }
                });
                newThread.Start();
            }
        }

        public int T
        {
            get { return this.t; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The value cannot less than 0");
                }
                this.t = value;
            }
        }
    }


}
