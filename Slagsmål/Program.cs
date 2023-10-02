
Random generator = new Random();


int round = 1;

int dmg = generator.Next(9, 201);
int dmg2 = generator.Next(9, 201);


int verahp = 450;
int sattarhp = 450;








while (round == 1)
{
    Console.WriteLine("-------:Runda 1:-------");
    sattarhp -= dmg;
    Console.WriteLine($"Sattar har tagit {dmg} skada! Han har {sattarhp}hp kvar.");
    Thread.Sleep(2000);
    verahp -=dmg2;
    Console.WriteLine($"Vera har tagit {dmg2} skada! Hon har {verahp}hp kvar.");
    round++;
    Thread.Sleep(2000);
}

dmg = generator.Next(9, 201);
dmg2 = generator.Next(9, 201);



while (round == 2)
{
    Console.WriteLine("-------:Runda 2:-------");
    sattarhp -= dmg;
    Console.WriteLine($"Sattar har tagit {dmg} skada! Han har {sattarhp}hp kvar.");
    Thread.Sleep(2000);
    verahp -= dmg2;
    Console.WriteLine($"Vera har tagit {dmg2} skada! Hon har {verahp}hp kvar.");
    round++;
    Thread.Sleep(2000);
}

dmg = generator.Next(9, 201);
dmg2 = generator.Next(9, 201);



while (round == 3)
{ 
    
    Console.WriteLine("-------:Runda 3:-------");

    if (sattarhp <= 0)
        {
            Console.WriteLine("Veras Mumin-rage var för mycket för Sattar. Sattar dör och Vera vinner!");
            round = 0;
            verahp = 1000;
            Thread.Sleep(2000);
            Console.WriteLine("Tryck på 'Enter' för att avsluta.");
        if ( Console.ReadKey().Key == ConsoleKey.Enter) {
            System.Environment.Exit(0);
        }
        }

        if (verahp <= 0)
        {
            Console.WriteLine("Sattar skriver in Veras namn i HTML Death Note. Vera dör av hjärtattack och Sattar vinner!");
            round = 0;
            sattarhp = 0;
            Thread.Sleep(2000);
            Console.WriteLine("Tryck på 'Enter' för att avsluta.");
        if ( Console.ReadKey().Key == ConsoleKey.Enter) 
        {
            System.Environment.Exit(0);
        }
        }

    if (sattarhp <= 175)
    {
        Console.WriteLine("Sattar och Vera utbyter slag. Det ser ut som om Sattar är snabbare och Veras liv är hotat.");
        Thread.Sleep(2000);
        Console.WriteLine("Vera inser att hon måste sin specialattack 'Erebos Barrage'. Hon hoppar bakåt och laddar upp sin attack. Erebos Barrage genomborrar Sattars hjärta.");
        sattarhp = 0;
        Thread.Sleep(2000);
        Console.WriteLine($"Sattar tittar ner på hålet i bröstkorgen orsakat av Erebos Barrage. 'Du kommer alltid vara min fina vän' lyckas Sattar få ur sig innan han faller till marken. Vera vinner!");
        round = 0;
        verahp = 0;
        Thread.Sleep(2000);
        Console.WriteLine("Tryck på 'Enter' för att avsluta.");
        if ( Console.ReadKey().Key == ConsoleKey.Enter) 
        {
            System.Environment.Exit(0);
        }
    }

    if (verahp <= 175)
    {
        Console.WriteLine("Sattar och Vera utbyter slag i rasande fart. Vera aktiverar Mumin-rage och hennes styrka och uthållighet boostas med 100%.");
        Console.WriteLine("Sattar inser att han kommer förlora om det fortsätter såhär. Han sparkar upp sand i Veras ögon och hoppar bakåt. Han tar snabbt ut sin dator och kallar på HTML-draken.");
        Console.WriteLine("HTML-draken använder CSS Slash som delar Vera itu.");
        Console.WriteLine("'Du har blivit stark Sattar. Jag trodde aldrig att du hade blivit stark nog för att kunna kalla på HTML-draken, bra kämpat' säger Vera tyst innan hon dör. Sattar vinner!");
        round = 0;
        sattarhp = 0;  
        verahp = 0;
        Thread.Sleep(2000);
        Console.WriteLine("Tryck på 'Enter' för att avsluta.");
        if ( Console.ReadKey().Key == ConsoleKey.Enter) 
        {
            System.Environment.Exit(0);
        }  
    }
    else 
    {
    sattarhp -= dmg;
    Console.WriteLine($"Sattar har tagit {dmg} skada! Han har {sattarhp}hp kvar.");
    Thread.Sleep(2000);
    verahp -= dmg2;
    Console.WriteLine($"Vera har tagit {dmg2} skada! Hon har {verahp}hp kvar.");
    round++;
    Thread.Sleep(2000);
    }
}

dmg = generator.Next(9,201);
dmg2 = generator.Next(9,201);


while (round == 4)
{
    Console.WriteLine("-------:Runda 4:-------");
    if (sattarhp <= 150)
    {
        if (verahp > sattarhp)
        {
        Console.WriteLine("Sattar och Vera utbyter slag. Det ser ut som om Sattar är snabbare och Veras liv är hotat.");
        Thread.Sleep(2000);
        Console.WriteLine("Vera inser att hon måste sin specialattack 'Erebos Barrage'. Hon hoppar bakåt och laddar upp sin attack. Erebos Barrage genomborrar Sattars hjärta.");
        sattarhp = 0;
        verahp = 0;
        Thread.Sleep(2000);
        Console.WriteLine($"Sattar tittar ner på hålet i bröstkorgen orsakat av Erebos Barrage. 'Du kommer alltid vara min fina vän' lyckas Sattar få ur sig innan han faller till marken. Vera vinner!");
        round = 0;
        Thread.Sleep(2000);
        Console.WriteLine("Tryck på 'Enter' för att avsluta.");
        if ( Console.ReadKey().Key == ConsoleKey.Enter) 
        {
            System.Environment.Exit(0);
        }
        }
    }
    if (verahp <= 150)
    {
        if (sattarhp > verahp)
        {
        Console.WriteLine("Sattar använder Javaescript och ändrar Veras kroppsuppbyggnad så att hon ramlar ihop och dör. Sattar vinner!");
        verahp = 0;
        sattarhp = 0;
        round = 0;
        Thread.Sleep(2000);
        Console.WriteLine("Tryck på 'Enter' för att avsluta.");
        if ( Console.ReadKey().Key == ConsoleKey.Enter) 
        {
            System.Environment.Exit(0);
        }

        }
    }

    if (sattarhp != 0) 
    {
        sattarhp -= dmg;
    Console.WriteLine($"Sattar har tagit {dmg} skada! Han har {sattarhp}hp kvar.");
    Thread.Sleep(2000);
    round = 5;
    }
     if (verahp != 0) 
    {
    verahp -= dmg2;
    Console.WriteLine($"Vera har tagit {dmg2} skada! Hon har {verahp}hp kvar.");
    Thread.Sleep(2000);
    round = 5;
    }
}

dmg = generator.Next(9, 201);
dmg2 = generator.Next(9,201);

while (round == 5) 
{
    
    Console.WriteLine("-------:Runda 5:-------");

if (sattarhp <= 125)
        {
            Console.WriteLine("Veras Mumin-rage var för mycket för Sattar. Sattar dör och Vera vinner!");
            verahp = 0;
            round = 0;
            Thread.Sleep(2000);
            Console.WriteLine("Tryck på 'Enter' för att avsluta.");
        if ( Console.ReadKey().Key == ConsoleKey.Enter) 
        {
            System.Environment.Exit(0);
        }
        }

        if (verahp <= 0)
        {
            Console.WriteLine("Sattar skriver in Veras namn i HTML Death Note. Vera dör av hjärtattack och Sattar vinner!");
            sattarhp = 0;
            round = 0;
            Thread.Sleep(2000);
            Console.WriteLine("Tryck på 'Enter' för att avsluta.");
        if ( Console.ReadKey().Key == ConsoleKey.Enter) 
        {
            System.Environment.Exit(0);
        }
        }

    if (sattarhp <= 125)
    {
        Thread.Sleep(2000);
        Console.WriteLine("Vera använder Erebos Barrage och knockar Sattar. Game over!");
        sattarhp = 0;
        verahp = 0;
        round = 0;
        Thread.Sleep(2000);
            Console.WriteLine("Tryck på 'Enter' för att avsluta.");
        if ( Console.ReadKey().Key == ConsoleKey.Enter) 
        {
            System.Environment.Exit(0);
        }
    }
    else
    {
        Thread.Sleep(2000);
        sattarhp -= dmg;
        Console.WriteLine($"Sattar har tagit {dmg} skada! Han har {sattarhp}hp kvar.");
        Thread.Sleep(2000);
        verahp -= dmg2;
        Console.WriteLine($"Vera har tagit {dmg2} skada! Hon har {verahp}hp kvar.");
        round++;
        Thread.Sleep(2000);
    }
}

while (round == 6)
{
    Console.WriteLine("-------:Runda 6:-------");

if (sattarhp <= 125)
    {
        Thread.Sleep(2000);
        Console.WriteLine("Vera använder Erebos Barrage och knockar Sattar. Game over!");
        sattarhp = 0;
        verahp = 0;
        round = 0;
        
        Console.WriteLine("Tryck på 'Enter' för att avsluta.");
        if ( Console.ReadKey().Key == ConsoleKey.Enter) 
        {
            System.Environment.Exit(0);
        }
    }
    if (verahp <= 125)
    {
        Thread.Sleep(2000);
        Console.WriteLine("Sattar använder Javaescript och knockar Vera. Game over!");
        verahp = 0;
        sattarhp = 0;
        round = 0;
        Thread.Sleep(2000);
        Console.WriteLine("Tryck på 'Enter' för att avsluta.");
        if ( Console.ReadKey().Key == ConsoleKey.Enter) 
        {
            System.Environment.Exit(0);
        }
    }
}
Console.ReadLine();