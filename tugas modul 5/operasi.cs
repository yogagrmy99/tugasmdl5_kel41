using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_modul_5
{
    class operasi
    {
        public float lt;
        public float ht;
        public float lb;
        public float hb;
        public float jt;
        public float jb;
        public float njopd;
        public float njop;
        public float njkp;
        public float pbb;

        public float Mpbb()
        {
            jt = lt * ht;
            jb = lb * hb;
            njopd = jt + jb;
            if (njopd >= 24000000)
            {
                njop = njopd - 12000000;
            }
            else
            {
                njop = njopd;
            }
            njkp = 0.2f * njop;
            pbb = 0.005f * njkp;
            
            return pbb;
        }    
    }
}