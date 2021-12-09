using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoteriaMexicanaApp
{
    class Baraja
    {
        int[] A = new int[54];
        int[] numeros = new int[54];
        int[] numer = new int[54];
        Random aleat = new Random();
        int c;
        int d;


        public Int32 Ncarta
        {
            get
            {
                return Num;
            }
            set
            {
                Num = value;
            }
        }

        public void revolver()
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = (i);
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                d = aleat.Next(0, 53);
                c = numeros[d];
                numeros[d] = numeros[i];
                numeros[i] = c;
            }
        }

        public void opt()
        {
            revolver();
            for (int i = 0; i < 54; i++)
            {
                numer[i] = numeros[i];
            }
        }

        public Int32 ObtNumero(Int32 idnumer)
        {
            if (idnumer == 0) { return numeros[0]; }
            else if (idnumer == 1) { return numeros[1]; }
            else if (idnumer == 2) { return numeros[2]; }
            else if (idnumer == 3) { return numeros[3]; }
            else if (idnumer == 4) { return numeros[4]; }
            else if (idnumer == 5) { return numeros[5]; }
            else if (idnumer == 6) { return numeros[6]; }
            else if (idnumer == 7) { return numeros[7]; }
            else if (idnumer == 8) { return numeros[8]; }
            else if (idnumer == 9) { return numeros[9]; }
            else if (idnumer == 10) { return numeros[10]; }
            else if (idnumer == 11) { return numeros[11]; }
            else if (idnumer == 12) { return numeros[12]; }
            else if (idnumer == 13) { return numeros[13]; }
            else if (idnumer == 14) { return numeros[14]; }
            else if (idnumer == 15) { return numeros[15]; }
            else if (idnumer == 16) { return numeros[16]; }
            else if (idnumer == 17) { return numeros[17]; }
            else if (idnumer == 18) { return numeros[18]; }
            else if (idnumer == 19) { return numeros[19]; }
            else if (idnumer == 20) { return numeros[20]; }
            else if (idnumer == 21) { return numeros[21]; }
            else if (idnumer == 22) { return numeros[22]; }
            else if (idnumer == 23) { return numeros[23]; }
            else if (idnumer == 24) { return numeros[24]; }
            else if (idnumer == 25) { return numeros[25]; }
            else if (idnumer == 26) { return numeros[26]; }
            else if (idnumer == 27) { return numeros[27]; }
            else if (idnumer == 28) { return numeros[28]; }
            else if (idnumer == 29) { return numeros[29]; }
            else if (idnumer == 30) { return numeros[30]; }
            else if (idnumer == 31) { return numeros[31]; }
            else if (idnumer == 32) { return numeros[32]; }
            else if (idnumer == 33) { return numeros[33]; }
            else if (idnumer == 34) { return numeros[34]; }
            else if (idnumer == 35) { return numeros[35]; }
            else if (idnumer == 36) { return numeros[36]; }
            else if (idnumer == 37) { return numeros[37]; }
            else if (idnumer == 38) { return numeros[38]; }
            else if (idnumer == 39) { return numeros[39]; }
            else if (idnumer == 40) { return numeros[40]; }
            else if (idnumer == 41) { return numeros[41]; }
            else if (idnumer == 42) { return numeros[42]; }
            else if (idnumer == 43) { return numeros[43]; }
            else if (idnumer == 44) { return numeros[44]; }
            else if (idnumer == 45) { return numeros[45]; }
            else if (idnumer == 46) { return numeros[46]; }
            else if (idnumer == 47) { return numeros[47]; }
            else if (idnumer == 48) { return numeros[48]; }
            else if (idnumer == 49) { return numeros[49]; }
            else if (idnumer == 50) { return numeros[50]; }
            else if (idnumer == 51) { return numeros[51]; }
            else if (idnumer == 52) { return numeros[52]; }
            else if (idnumer == 53) { return numeros[53]; }
            return 6;
        }

        public int Num { get; set; }
    }
}
