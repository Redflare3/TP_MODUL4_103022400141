using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL4_103022400141
{
    public class KodePos
    {
        public enum KodePosType {
            BATUNUNGGAL,
            KUJANGSARI,
            MENGGER,
            WATES,
            CIJAURA,
            JATISARI,
            MARGASARI,
            SEKEJATI,
            KEBONWARU,
            MALEER
        }
        public static int getKodePos(KodePosType type){
            int[] kodePosList = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274 };
            return kodePosList[(int)type];
        }
    }
}
