using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoteriaMexicanaApp
{
    class Numero_De_Cartas
    {
        private Int32 _NumeroBaraja;

        public Int32 NumeroBaraja
        {
            get { return _NumeroBaraja; }
            set { _NumeroBaraja = value; }
        }

        public String NombreBaraja(Int32 NumeroBaraja)
        {
            try
            {
                if (NumeroBaraja == 0) { return "1 "; }
                else if (NumeroBaraja == 1) { return "2 "; }
                else if (NumeroBaraja == 2) { return " 3"; }
                else if (NumeroBaraja == 3) { return " 4 "; }
                else if (NumeroBaraja == 4) { return " 5 "; }
                else if (NumeroBaraja == 5) { return " 6 "; }
                else if (NumeroBaraja == 6) { return " 7 "; }
                else if (NumeroBaraja == 7) { return " 8 "; }
                else if (NumeroBaraja == 8) { return " 9"; }
                else if (NumeroBaraja == 9) { return " 10 "; }
                else if (NumeroBaraja == 10) { return " 11"; }
                else if (NumeroBaraja == 11) { return " 12"; }
                else if (NumeroBaraja == 12) { return " 13"; }
                else if (NumeroBaraja == 13) { return " 14"; }
                else if (NumeroBaraja == 14) { return " 15"; }
                else if (NumeroBaraja == 15) { return " 16"; }
                else if (NumeroBaraja == 16) { return " 17"; }
                else if (NumeroBaraja == 17) { return " 18"; }
                else if (NumeroBaraja == 18) { return " 19"; }
                else if (NumeroBaraja == 19) { return " 20"; }
                else if (NumeroBaraja == 2) { return " 21"; }
                else if (NumeroBaraja == 21) { return " 22"; }
                else if (NumeroBaraja == 22) { return " 23"; }
                else if (NumeroBaraja == 23) { return " 24"; }
                else if (NumeroBaraja == 24) { return " 25"; }
                else if (NumeroBaraja == 25) { return " 26"; }
                else if (NumeroBaraja == 26) { return " 27"; }
                else if (NumeroBaraja == 27) { return " 28"; }
                else if (NumeroBaraja == 28) { return " 29"; }
                else if (NumeroBaraja == 29) { return " 30"; }
                else if (NumeroBaraja == 30) { return " 31"; }
                else if (NumeroBaraja == 31) { return " 32"; }
                else if (NumeroBaraja == 32) { return " 33"; }
                else if (NumeroBaraja == 33) { return " 34"; }
                else if (NumeroBaraja == 34) { return " 35"; }
                else if (NumeroBaraja == 35) { return " 36"; }
                else if (NumeroBaraja == 36) { return " 37"; }
                else if (NumeroBaraja == 37) { return " 38"; }
                else if (NumeroBaraja == 38) { return " 39"; }
                else if (NumeroBaraja == 39) { return " 40"; }
                else if (NumeroBaraja == 40) { return " 41"; }
                else if (NumeroBaraja == 41) { return " 42"; }
                else if (NumeroBaraja == 42) { return " 43"; }
                else if (NumeroBaraja == 43) { return " 44"; }
                else if (NumeroBaraja == 44) { return " 45"; }
                else if (NumeroBaraja == 45) { return " 46"; }
                else if (NumeroBaraja == 46) { return " 47"; }
                else if (NumeroBaraja == 47) { return " 48"; }
                else if (NumeroBaraja == 48) { return " 49"; }
                else if (NumeroBaraja == 49) { return " 50 "; }
                else if (NumeroBaraja == 50) { return " 51"; }
                else if (NumeroBaraja == 51) { return " 52"; }
                else if (NumeroBaraja == 52) { return " 53"; }
                else if (NumeroBaraja == 53) { return " 54"; }
                else { return ""; }
            }
            catch
            {
                MessageBox.Show("Verificar la carta de la baraja");
                return "";
            }
        }
    }
}
