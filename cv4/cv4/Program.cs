// See https://aka.ms/new-console-template for more information
using cv4;
using System.Diagnostics.Tracing;

string string_input = "Toto je retezec predstavovany nekolika radky,\n"
 + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
 + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
 + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
 + "posledni veta!"; 

StringStatistics newStringStatistics = new StringStatistics(string_input);
Console.WriteLine(newStringStatistics.getWordCount());
Console.WriteLine(newStringStatistics.getSentenceCount());
Console.WriteLine(newStringStatistics.getWordLongest());
Console.WriteLine(newStringStatistics.getWordShortest());
Console.WriteLine(newStringStatistics.getWordMostOccuring());
foreach (string word in newStringStatistics.getWordSort())
{
    Console.WriteLine(word);
}