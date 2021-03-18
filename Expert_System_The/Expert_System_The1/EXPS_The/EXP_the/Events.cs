using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem_The
{
    class Events
    {
        String masukien;

        public String Masukien
        {
            get { return masukien; }
            set { masukien = value; }
        }
        String motasukien;

        public String Motasukien
        {
            get { return motasukien; }
            set { motasukien = value; }
        }
        public string LoaiSK { get; set; }
    }
}
