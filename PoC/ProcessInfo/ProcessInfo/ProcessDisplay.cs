using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessInformation
{
    public class ProcessDisplay : IComparable
    {
        public string ProcName { get; set; }
        public int ID { get; set; }
        public string RunTime { get; set; }

        public ProcessDisplay(string processname, int id, DateTime t0)
        {
            ProcName = processname;
            ID = id;
            TimeSpan TSRun = DateTime.Now.Subtract(t0);
            RunTime = new DateTime(TSRun.Ticks).ToString("dd 'days' HH 'hours' mm 'minutes' ss 'seconds'");
        }

        public int CompareTo(object o)
        {
            return this.ProcName.CompareTo((o as ProcessDisplay).ProcName);
        }
    }

}
