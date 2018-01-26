using CSML;
using System;
using System.Collections;
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
                double[] plMa = new double[lenKey];

                Matrix plMtr = new Matrix(lenKey, lenKey);
                for (int j = 1; j <= lenKey; j++)
                {
                    if (index < plainText.Length)
                        plMa[j - 1] = (double)(plainText[index] - 'A');
                    else
                        plMa[j - 1] = 0;

                    if (plMa[j - 1] != -1) plMtr[j, 1] = new Complex(plMa[j - 1]); else plMtr[j, 1] = new Complex(0);

                    index++;
                }


                Matrix ansMtr = Key * plMtr;

                for (int j = 1; j <= lenKey; j++)
                {
                    int z = (((int)ansMtr[j, 1].Re) % 26 + 26) % 26;
                    ans = ans + (char)(z + 'A');
                }
            }

            return ans;
        }

        // Giai Ma
        public static string decrypt(string CipherText, Matrix Key)
        {
            string cipherText = CipherText.ToUpper();
            string ans = "";

            Matrix KeyInverse = Key.Inverse();
            ans = encrypt(cipherText, KeyInverse);

            return ans;
        }

        // Kiem tra ma tran ngich dao co thoa man k
        public static bool ok(Matrix a)
        {
            if (a.Determinant() == 0) return false;
            Matrix aInverse = a.Inverse();

            try
            {
                for (int i = 1; i <= a.ColumnCount; i++)
                    for (int j = 1; j <= a.RowCount; j++)
                        if (Math.Abs(aInverse[i, j].Re - Math.Round(aInverse[i, j].Re)) > 0.00001 || aInverse[i, j].Im != 0)
                            return false;
            }
            catch
            {

                return false;
            }

            return true;
        }

        // Tham ma
        public static string decrypt(string cirpher, string plainTextExample, string cipherTextExample)
        {
            int lenKey = 2;

            /// tìm key
            Matrix Key = new Matrix(lenKey, lenKey);
            int index = 0;

            double[] plMa = new double[lenKey];

            /// ma trận bản rõ
            Matrix plBR = new Matrix(lenKey, lenKey);
            for (int i = 1; i <= lenKey; i++)
            {
                for (int j = 1; j <= lenKey; j++)
                {
                    if (index < lenKey)
                        plMa[j - 1] = (double)(plainTextExample[index] - 'A');
                    else
                        plMa[j - 1] = 0;

                    if (plMa[j - 1] != -1) plBR[j, i] = new Complex(plMa[j - 1]); else plBR[j, i] = new Complex(0);

                    index++;
                }
            }

            // ma trận bản mã
            index = 0;
            Matrix plBM = new Matrix(lenKey, lenKey);
            for (int i = 1; i <= lenKey; i++)
            {
                for (int j = 1; j <= lenKey; j++)
                {
                    if (index < lenKey)
                        plMa[j - 1] = (double)(cipherTextExample[index] - 'A');
                    else
                        plMa[j - 1] = 0;

                    if (plMa[j - 1] != -1) plBM[j, i] = new Complex(plMa[j - 1]); else plBM[j, i] = new Complex(0);

                    index++;
                }
            }

            /// Giải mã
            Key = plBR.Inverse() * plBM;


            return decrypt(cirpher, Key);
        }
    }
}
