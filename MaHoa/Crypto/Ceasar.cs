using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaHoa.Crypto
{
    public static class Ceasar
    {
        // Ma Hoa
        public static string encrypt(string PlainText, int Key)
        {
            string plainText = PlainText.ToUpper();
            string ans = "";

            for (int i=0; i<plainText.Length; i++)
            {
                if (plainText[i] < 'A' || plainText[i] > 'Z')
                {
                    ans = ans + plainText[i];
                    continue;
                }

                int c = plainText[i] - 'A';
                int z = (c + Key) % 26;
                ans = ans + (char) (z + 'A'); 
            }

            return ans;
        }

        // Giai Ma
        public static string decrypt(string CipherText, int Key)
        {
            string cipherText = CipherText.ToUpper();
            string ans = "";

            for (int i = 0; i < cipherText.Length; i++)
            {
                if (cipherText[i] < 'A' || cipherText[i]>'Z')
                {
                    ans = ans + cipherText[i];
                    continue;
                }

                int c = cipherText[i] - 'A';
                int z = ((c - Key) % 26 + 26) % 26;
                ans = ans + (char)(z + 'A');
            }

            return ans;
        }

        /// Tham Ma
        public static string decrypt(string cipherText)
        {
            cipherText = cipherText.ToUpper();
            double[] frequence = new double[] { 0.082, 0.015, 0.028, 0.043, 0.127, 0.022, 0.20, 0.061, 0.070, 0.002, 0.008, 0.040, 0.024, 0.067, 0.075, 0.019, 0.001, 0.060, 0.063, 0.091, 0.028, 0.010, 0.023, 0.001, 0.020, 0.001 };

            int[] cnt = new int[26];
            for (int i = 0; i < 26; i++) cnt[i] = 0;

            for (int i = 0; i < 26; i++)
            {
                if (cipherText[i] < 'A' || cipherText[i] > 'Z')
                    continue;
                int k = cipherText[i] - 'A';
                cnt[k]++;
            }

            int ma = 65;
            for (int i = 65; i <= 'Z'; i++)
                if (cnt[i - 'A'] > cnt[ma - 'A']) ma = i;

            int key = (ma - 'E' + 26)%26;

            return decrypt(cipherText, key);
        }
    }
}
