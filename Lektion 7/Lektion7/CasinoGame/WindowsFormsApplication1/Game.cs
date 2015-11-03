using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Game
{
    /// <summary>
    /// Represent the game. Include a Thread that read the
    /// Wheels each 0.1 sec. 
    /// </summary>
    class Game
    {
        #region event
        public delegate void noChange(int [] no);
        public event noChange NextNumbers;
        #endregion

        Wheel[] w = new Wheel[3];

        private bool stopped = true;

        /// <summary>
        /// Create a thread for wheel reading
        /// </summary>
        public Game()
        {
            Thread gameT = new Thread(new ThreadStart(Throw));
            gameT.Start();
        }

        /// <summary>
        /// Start the game and fire the event for each readind period
        /// </summary>
        public void Throw()
        {
            int [] no = new int[3];
            for (int i = 0; i < 3; i++)
                w[i] = new Wheel(i.ToString());
            stopped = false;

            while (stopped == false)
            {
                Thread.Sleep(100);
                //lock (this)
                {
                    no[0] = w[0].Value;
                    no[1] = w[1].Value;
                    no[2] = w[2].Value;
                }
                // Fire the event
                if (NextNumbers != null)
                    NextNumbers(no);
            }
        }

        /// <summary>
        /// Stoppes game and stop all wheel threads
        /// </summary>
        public void StopPlay()
        {
            this.stopped = true;
            for (int i = 0; i < 3; i++)
                w[i].Stop();
        }

    }
}
