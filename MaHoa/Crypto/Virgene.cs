using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaHoa.Crypto
{
    public static class Virgene
    {
        // Ma Hoa
        public static string encrypt(string PlainText, string Key)
        {
            string plainText = PlainText.ToUpper();
            Key = Key.ToUpper();
            string ans = "";
            int j = 0;

            for (int i=0; i<plainText.Length; i++)
            {
                if (plainText[i] <'A' || plainText[i]>'Z')
                {
                    ans = ans + plainText[i];
                    continue;
                }

                int c = plainText[i] - 'A';
                int kc = Key[j] - 'A';

                int z = (c + kc) % 26;
                ans = ans + (char) (z + 'A');

                j++;
                if (j == Key.Length) j = 0;
            }

            return ans;
        }

        // Giai Ma
        public static string decrypt(string CipherText, string Key)
        {
            string cipherText = CipherText.ToUpper();
            Key = Key.ToUpper();
            string ans = "";
            int j = 0;

            for (int i = 0; i < cipherText.Length; i++)
            {
                if (cipherText[i] < 'A' || cipherText[i] > 'Z')
                {
                    ans = ans + cipherText[i];
                    continue;
                }

                int c = cipherText[i] - 'A';
                int kc = Key[j] - 'A';

                int z = ((c - kc) % 26 + 26) % 26;
                ans = ans + (char)(z + 'A');

                j++;
                if (j == Key.Length) j = 0;
            }

            return ans;
        }
    }
}
