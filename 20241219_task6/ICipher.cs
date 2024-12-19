using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241219_task6
{
    /*
 Создать интерфейс «ICipher», который определяет методы поддержки шифрования строк. 
В интерфейсе объявляются два метода Encode() и Decode(), которые используются для шифрования и дешифрования строк, соответственно. 
Определить класс, реализующий интерфейс, выполнить шифровку и расшифровку одной строки.
 */
    internal interface ICipher
    {
        string Encode();
        string Decode(string str);
    }
}
