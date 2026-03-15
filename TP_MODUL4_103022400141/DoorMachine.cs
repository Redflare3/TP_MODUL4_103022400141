using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL4_103022400141{
    public class DoorMachine {
        public enum State{
            TERKUNCI, TERBUKA
        }
        public static void Start() { 
            State curState = State.TERKUNCI;
            string[] conditionName = { "Terkunci", "Terbuka" };
            Console.WriteLine("Kondisi awal: " + conditionName[(int)curState]);
            Console.Write("Masukan kondisi(BukaPintu/KunciPintu) :");
            string inputCon = Console.ReadLine().ToUpper();

            while (inputCon != "") {
                switch (curState) {
                    case State.TERKUNCI:
                        if (inputCon == "BUKAPINTU") {
                            curState = State.TERBUKA;
                        }
                        else {
                            curState = State.TERKUNCI;
                        }
                        break;
                    case State.TERBUKA:
                        if (inputCon == "KUNCIPINTU") {
                            curState = State.TERKUNCI;
                        }
                        else {
                            curState = State.TERBUKA;
                        }
                        break;
                }
                Console.WriteLine("Kondisi Pintu saat ini: " + conditionName[(int)curState]);
                Console.Write("Masukan kondisi(BukaPintu/KunciPintu) :");
                inputCon = Console.ReadLine().ToUpper();
            }
        }
    }
}
