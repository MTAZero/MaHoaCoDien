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
    }
}
