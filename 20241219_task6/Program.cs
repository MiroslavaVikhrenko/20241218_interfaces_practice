namespace _20241219_task6
{
    internal class Program
    {
        /*
         Создать интерфейс «ICipher», который определяет методы поддержки шифрования строк. 
        В интерфейсе объявляются два метода Encode() и Decode(), которые используются для шифрования и дешифрования строк, соответственно. 
        Определить класс, реализующий интерфейс, выполнить шифровку и расшифровку одной строки.
         */
        static void Main(string[] args)
        {
            SecretMessage msg = new SecretMessage { Text = "This is a Very Sensitive Data!"};

            Console.WriteLine($"Original message is {msg.Text}");

            string encodedMessage = msg.Encode();

            Console.WriteLine($"\nEncoded message is {encodedMessage}");

            Console.WriteLine($"\nDecoded message is {msg.Decode(encodedMessage)}");

            Console.ReadKey();
        }
    }
}
