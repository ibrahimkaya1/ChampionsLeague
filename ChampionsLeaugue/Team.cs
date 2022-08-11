using System;
using System.Collections.Generic;
using System.Text;

namespace ChampionsLeaugue
{
    internal class Team
    {
        private string takimAdi;
        private string takimUlkesi;
        private int puan;
        private int aGol;
        private int yGol;
        private int avarage;
      //  private int takimPuani;

        public Team (string ad, string ulke)
        {
            takimAdi = ad;
            takimUlkesi = ulke;
        }
        public Team(string ad, int point,int AG, int YG, int AVG)
        {
            takimAdi = ad;
            puan = point;
            aGol = AG;
            yGol = YG;
            avarage = AVG;
        }
        public int Point
        {
            get { return puan; }
            set { puan = value; }
        }
        public int AGol
        {
            get { return aGol; }
            set { aGol = value; }
        }
        public int YGol
        {
            get { return yGol; }
            set { yGol = value; }
        }
        public int Avarage
        {
            get { return avarage; }
            set { avarage = value; }
        }
        public string TakimAdi 
        {
            get { return takimAdi; }
            set { takimAdi = value; }
        }
        public string TakimUlkesi
        {
            get { return takimUlkesi; }
            set { takimUlkesi = value; }
        }

        public object Items { get; internal set; }

        public override string ToString()
        {
            return takimAdi + " - " + takimUlkesi;
        }
    }
}
