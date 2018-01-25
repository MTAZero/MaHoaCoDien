using CSML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaHoa.Crypto
{
    public static class Hill
    {
        // Ma Hoa
        public static string encrypt(string PlainText, Matrix Key)
        {
            string plainText = PlainText.ToUpper();
            string ans = "";

            int lenKey = Key.RowCount;
            int index = 0;
            while (index < plainText.Length)
            {
                double[] plMa = new double[plainText.Length];

                for(int j =1; j<=lenKey; j++)
                {
                    plMa[j - 1] = (double)(plainText[index] - 'A');
                    index++;
                }

                Matrix plMtr = new Matrix(plMa);
                Matrix ansMtr = plMtr * Key;
            }

            return ans;
        }
        
        // Giai Ma
        public static string decrypt(string CipherText, Matrix Key)
        {
            string cipherText = CipherText.ToUpper();
            string ans = "";

            Matrix KeyInverse = Key.Inverse();
            

            return ans;
        }
    }
}
