using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4_Vigener
{
    public class Vigener
    {
        //ключ-слово
        //шифрование текста
        public string Encrypt(Language language, string clearMessage, string key)
            => VigenerEncoderText(language, clearMessage, key, 1, 0);
        //дешифрование текста
        public string Decrypt(Language language, string encryptedMessage, string key)
            => VigenerEncoderText(language, encryptedMessage, key, -1, 1);

        //ключ - числа
        //шифрование текста
        public string Encrypt(Language language, string clearMessage, int[] key)
            => VigenerEncoderNums(language, clearMessage, key, 1, 0);
        //дешифрование текста
        public string Decrypt(Language language, string encryptedMessage, int[] key)
            => VigenerEncoderNums(language, encryptedMessage, key, -1, 1);
        
        //ключ-слово
        public string VigenerEncoderText(Language language, string message, string key, int kf1, int kf2)
        {
            message = message.ToUpper().Replace(" ", "");
            key = key.ToUpper().Replace(" ", "");

            string result = "";
            int key_index = 0;
            string alphBig;
            string alphSmall;
            Alphabet.GetAlphabet(language, out alphBig, out alphSmall);

            foreach (char symbol in message)
            {
                int c = (alphBig.IndexOf(symbol) + kf1*alphBig.IndexOf(key[key_index]) + kf2*Alphabet.GetAlphabetLength(language)) 
                            % Alphabet.GetAlphabetLength(language);
                result += alphBig[c];
                key_index++;
                //если дошли до конца ключа - запускаем ключ по новой
                if (key_index == key.Length)
                    key_index = 0;
            }
            return result;
        }

        //ключ-числа
        public string VigenerEncoderNums(Language language, string message, int[] key, int kf1, int kf2)
        {
            message = message.ToUpper().Replace(" ", "");

            string result = "";
            int key_index = 0;
            string alphBig;
            string alphSmall;
            Alphabet.GetAlphabet(language, out alphBig, out alphSmall);

            foreach (char symbol in message)
            {
                int c = (alphBig.IndexOf(symbol) + kf1*key[key_index] + kf2*Alphabet.GetAlphabetLength(language))
                            % Alphabet.GetAlphabetLength(language);

                result += alphBig[c];
                key_index++;

                //если дошли до конца ключа - запускаем ключ по новой
                if (key_index == key.Length)
                    key_index = 0;
            }
            return result;
        }

    }
}
