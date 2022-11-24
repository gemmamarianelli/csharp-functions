using System.Globalization;

int[] arrayNumeri = { 2, 6, 7, 5, 3, 9 };
StampaArrayDiNumeri(arrayNumeri);


 float sum = arrayNumeri.Sum();
Console.WriteLine(sum.ToString());
Console.Write("[");
Console.Write(Math.Pow(sum, 2));
Console.Write("]");

for(int i = 0; i<arrayNumeri.Length; i++)
{
    Console.Write("[");
    Console.Write(Math.Pow(arrayNumeri[i], 2));
    Console.Write("]");
    
}





//--------------------------FUNZIONI-----------------------------

void StampaArrayDiNumeri(int[] arrayNumeri)
{
    Console.Write("[");
    for (int i=0; i<arrayNumeri.Length; i++)
    {
        Console.Write(arrayNumeri[i] + ",");
    }
    Console.Write("]");
   
}

