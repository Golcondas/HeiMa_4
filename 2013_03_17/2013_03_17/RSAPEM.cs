using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace _2013_03_17
{
    public class RSAPEM
    {
        /// <summary>
        /// 用得到的解码值来得到相应的Parameter（BASE64->RSAParameter）
        /// </summary>
        /// <param name="hashKey">源</param>
        /// <param name="type">0私钥1公钥</param>
        /// <returns></returns>
        public RSAParameters getKeyPara(string hashKey, int type)
        {

            RSAParameters rsaP = new RSAParameters();

            byte[] tmpKeyNoB64 = Convert.FromBase64String(hashKey);

            int pemModulus = 128;

            int pemPublicExponent = 3;

            int pemPrivateExponent = 128;

            int pemPrime1 = 64;

            int pemPrime2 = 64;

            int pemExponent1 = 64;

            int pemExponent2 = 64;

            int pemCoefficient = 64;





            byte[] arrPemModulus = new byte[128];

            byte[] arrPemPublicExponent = new byte[3];

            byte[] arrPemPrivateExponent = new byte[128];

            byte[] arrPemPrime1 = new byte[64];

            byte[] arrPemPrime2 = new byte[64];

            byte[] arrPemExponent1 = new byte[64];

            byte[] arrPemExponent2 = new byte[64];

            byte[] arrPemCoefficient = new byte[64];



            if (type == 0)//私钥
            {

                //Modulus

                for (int i = 0; i < pemModulus; i++)
                {

                    arrPemModulus[i] = tmpKeyNoB64[11 + i];

                }

                rsaP.Modulus = arrPemModulus;



                //PublicExponent

                for (int i = 0; i < pemPublicExponent; i++)
                {

                    arrPemPublicExponent[i] = tmpKeyNoB64[141 + i];

                }

                rsaP.Exponent = arrPemPublicExponent;



                //PrivateExponent

                for (int i = 0; i < pemPrivateExponent; i++)
                {

                    arrPemPrivateExponent[i] = tmpKeyNoB64[147 + i];

                }

                rsaP.D = arrPemPrivateExponent;



                //Prime1

                for (int i = 0; i < pemPrime1; i++)
                {

                    arrPemPrime1[i] = tmpKeyNoB64[278 + i];

                }

                rsaP.P = arrPemPrime1;



                //Prime2

                for (int i = 0; i < pemPrime2; i++)
                {

                    arrPemPrime2[i] = tmpKeyNoB64[345 + i];

                }

                rsaP.Q = arrPemPrime2;





                //Exponent1

                for (int i = 0; i < pemExponent1; i++)
                {

                    arrPemExponent1[i] = tmpKeyNoB64[412 + i];

                }

                rsaP.DP = arrPemExponent1;



                //Exponent2

                for (int i = 0; i < pemExponent2; i++)
                {

                    arrPemExponent2[i] = tmpKeyNoB64[478 + i];

                }

                rsaP.DQ = arrPemExponent2;



                //Coefficient

                for (int i = 0; i < pemCoefficient; i++)
                {

                    arrPemCoefficient[i] = tmpKeyNoB64[545 + i];

                }

                rsaP.InverseQ = arrPemCoefficient;

            }

            else//公钥
            {

                for (int i = 0; i < pemModulus; i++)
                {

                    arrPemModulus[i] = tmpKeyNoB64[29 + i];

                }

                rsaP.Modulus = arrPemModulus;



                for (int i = 0; i < pemPublicExponent; i++)
                {

                    arrPemPublicExponent[i] = tmpKeyNoB64[159 + i];

                }

                rsaP.Exponent = arrPemPublicExponent;



            }
            return rsaP;

        }
    }
}
