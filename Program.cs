using System;
namespace HashingandBST
{
    public class Program
        {
        static void Main(string[] args)
    { 
 Console.WriteLine(" CASE 1-To find frequency of words in a sentence, CASE 2-To find frequency of words in a paragraph, CASE3-Remove the word in a paragraph");
Console.WriteLine("Enter the option");
int num = Convert.ToInt32(Console.ReadLine());
Frq_Of_Word_in_para<string, int> myMapNode = new Frq_Of_Word_in_para<string, int>(6);
switch (num)
{
    case 1:
        string[] words = { "to", "be", "or", "not", "to", "be" };
        int count = 1;
        foreach (string i in words)
        {
            count = myMapNode.CheckHash(i);
            if (count > 1)
            {
                myMapNode.Add(i, count);
            }
            else
            {
                myMapNode.Add(i, 1);
            }
        }

        IEnumerable<string> uniqueItems = words.Distinct<string>();
        foreach (var i in uniqueItems)
        {
            myMapNode.Display(i);
        }
        break;
    case 2:

        Frq_Of_Word_in_para<string, int> myMap = new Frq_Of_Word_in_para<string, int>(10);
        string[] Paragraph;
        string input = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
        Paragraph = input.Split(' ');
        //Given string input

        int counts = 1;
        foreach (string i in Paragraph)
        {
            counts = myMap.CheckHash(i);
            if (counts > 1)
            {
                myMap.Add(i, counts);
            }
            else
            {
                myMap.Add(i, 1);
            }
        }
        Console.WriteLine("Frequency of words in paragraph");
        IEnumerable<string> distinct = Paragraph.Distinct<string>();
        foreach (var i in distinct)
        {
            myMap.Display(i);
        }

        break;
    case 3:
        MapNode<string, int> myMap1 = new MapNode<string, int>(10);
        string[] paragraph1;
        string input1 = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
        paragraph1 = input1.Split(' ');

        int count1 = 1;
        foreach (string i in paragraph1)
        {
            counts = myMap1.CheckHash(i);
            if (count1 > 1)
            {
                myMap1.Add(i, counts);
            }
            else
            {
                myMap1.Add(i, 1);
            }
        }
        IEnumerable<string> unique = paragraph1.Distinct<string>();
        Console.WriteLine("\nEnter the word which you want to remove in paragraph");
        string removeWord = Console.ReadLine();
        myMap1.Remove(removeWord);
        foreach (var i in unique)
        {
            myMap1.Display(i);
        }
        break;
    default:
        Console.WriteLine("Enter the valid option!!");
        break;

}

Console.ReadLine();
        }
    }
}
