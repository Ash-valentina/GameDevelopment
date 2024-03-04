class basicProgram
{
    static void Main()
    {
        int muis, sum, nummer;
        muis = 1;
        sum = muis * 5;
        Console.WriteLine("Mijn nieuwe E-sports ready compatible for PC muis met rgb belichting, 1,4 M lange kabel.");
        Console.WriteLine("hoe duur is ie? " + sum);
        
        Console.WriteLine("hoe duur dacht je dat de muis");
        nummer = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("weet je zeker dat je dat denkt, dat je denkt dat de muis " + nummer + " euro kost?");

        if(nummer != 5)
        {
            Console.WriteLine("jij bent niet rgb belichte muis pc compatible waardig");
        }
        else
        {
            Console.WriteLine("Je hebt het helemaal goed");
        }


    }
}