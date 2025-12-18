/*************************************************
 * klasa: ToolBox
 * opis: "Biblioteka" funkcji do operacji na łańcuchach tekstowych
 * metody: countVowels(): int
 * <nazwa removeDuplicates(): string
 * autor:  06*******4
 * ************************************************
 */


using System.Runtime.InteropServices;
using System.Text;

abstract class ToolBox
{
    public static int countVowels(string text)
    {
        int vowelsNum = 0;
        string vowelList = "aąeęiouóyAĄEĘIOUÓY";
        foreach (char character in text)
        {
           if (vowelList.Contains(character))
            {
                vowelsNum++;
            }
        }
        return vowelsNum;
    }
    public static string removeDuplicates(string text)
    {
        string newString = "";
        for (int i = 0; i < text.Length; i++)
        {
            if (newString.Contains(text[i]))
            {
                continue;
            }
            else
            {
                newString += text[i];
            }
        }
        return newString; 
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(ToolBox.removeDuplicates("Abba;;;ToZespół"));
        Console.WriteLine(ToolBox.countVowels("Abrakadabra"));
    }
}
