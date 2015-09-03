using System;
using System.Text;
class PrintTheAsciiTable
{
    static void Main()
    {
        /*The first 32 characters are unprintable control codes.-> We will skip them.
          Codes 32-127 are called printable characters and represent letters, digits, puntuation marks and a few miscellaneous
          symbols. We will print them. The characters with codes from 128 to 255 are part of the extended ASCII table.*/
        Console.OutputEncoding = Encoding.UTF8;
        int counter = 0;
        for (int i = 33; i <= 255; i++)
        {
            if (counter == 7)
            {
                Console.WriteLine();
                counter = 0;
            }
            Console.Write("{0} => {1}  ", i, (char)i);
            counter++;
        }

    }
}