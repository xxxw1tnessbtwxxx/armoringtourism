using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Armoring
{
    class Info
    {
        private int days, count;
        private bool childrens;
        private double min, max;
        DateTime[] times = new DateTime[2];

        private int idCity;

        public Info(DateTime start, DateTime end, int days, int count, bool childrens)
        {

            this.days = days;
            this.count = count;
            this.childrens = childrens;
            times[0] = start;
            times[1] = end;

        }

        public DateTime[] GiveDateTimes() => times;
        public int GiveDays() => days;
        public int GiveCount() => count;
        public bool CheckedChildrens() => childrens;
        public double GetMin() => min;
        public double GetMax() => max;

        public void SetCity(int idCity) => this.idCity = idCity;

        public void SetMin(double min) => this.min = min;
        public void SetMax(double max) => this.max = max;

    }
}
