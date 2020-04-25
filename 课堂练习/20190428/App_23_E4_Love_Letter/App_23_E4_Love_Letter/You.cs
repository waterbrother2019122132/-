﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_23_E4_Love_Letter
{
    // 所有代理的标准形式
    public delegate void energyEventHandler(object sender, EnergyEventArgs e);
    public delegate void moodEventHandler(object sender, MoodEventArgs m);

    public class EnergyEventArgs: EventArgs   // 事件参数类：将所有的参数封装在此类中
    {
        int energy;
        public EnergyEventArgs(int energy)
        {
            this.energy = energy;
        }
        public int Energy
        {
            get { return energy; }
        }
    }

    public class MoodEventArgs : EventArgs
    {
        int mood;
        public MoodEventArgs(int mood)
        {
            this.mood = mood;
        }
        public int Mood
        {
            get { return mood; }
        }
    }

    class You
    {
        int energyValue, moodValue;
        public event energyEventHandler energyEvent;
        public event moodEventHandler moodEvent;

        public You(int v1, int v2)
        {
            energyValue = v1;
            moodValue = v2;
        }

        public void run()
        {
            for (int i = 8; i < 22; i++)
            {
                energyValue--;
                moodValue--;
                Console.WriteLine("Time: {0}:00", i);
                if (energyEvent != null)
                {
                    EnergyEventArgs e = new EnergyEventArgs(energyValue);
                    energyEvent(this, e);
                    MoodEventArgs m = new MoodEventArgs(moodValue);
                    moodEvent(this, m);
                }
            }
        }

        public int EnergyValue
        {
            set { energyValue = value; }
        }

        public int MoodValue
        {
            set { moodValue = value; }
        }
    }
}
