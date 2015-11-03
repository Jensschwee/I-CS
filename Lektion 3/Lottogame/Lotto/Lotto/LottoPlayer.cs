using System;
using System.Collections.Generic;
using System.Text;

namespace Lotto
{
    /// <summary>
    /// Represent a Lotto Player
    /// </summary>
    /// <author> Steffen Skov</author>
    class LottoPlayer
    {
        DanskeSpil ds;

        public LottoPlayer(DanskeSpil ds)
        {
            this.ds = ds;
            // Subscribe the Lotto drawing by DanskeSpil
            ds.LottoNumbersEvent += CheckMyNum;
        }

        public LottoPlayer(DanskeSpil ds, int[] num) : this(ds)
        {
            myNum = num;
        }


        private int[] myNum = { 1, 3, 5, 7, 9, 11, 13 };

        /// <summary>
        /// My Lotto nummers
        /// 7 numbers between 1 and 36
        /// </summary>
        public int[] MyNum
        {
            get { return myNum; }
            set 
            { 
                if (LegalNumbers(value) == true)
                    myNum = value; 
                else
                    throw new Exception("Wrong numbers");
            }
        }

        /// <summary>
        /// Check for legal Lotto numbers
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private bool LegalNumbers(int[] n)
        {
            bool legal = true;
            if (n.Length == 7)
            {
                for (int i = 0; i < 7; i++)
                    if (n[i] > 37 || n[i] < 0)
                        legal = false;
            }
            else
                legal = false;
            return legal;
        }

        /// <summary>
        /// Event handler method
        /// </summary>
        /// <param name="n">Lotto numbers</param>
        public void CheckMyNum(int[] n)
        {
            bool luck = true;
            for (int i = 0; i < 7; i++)
            {
                if (n[i] != myNum[i]) luck = false;
            }

            if (luck == true)
                Console.WriteLine("Now I am Millionaire");
            else
                Console.WriteLine("Not a millionaire");

        }
    }

}