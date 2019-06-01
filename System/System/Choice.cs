using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    abstract class GetDetails
    {
        public int monitor=0, speed=0, ram=0, drive=0, mouse=0, keyBoard=0, ports=0;
        public int monitor_p, speed_p, ram_p, drive_p, mouse_p, keyBoard_p, ports_p;
        public abstract void Details();
        
    }
}
    