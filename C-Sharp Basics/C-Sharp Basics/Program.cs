// See https://aka.ms/new-console-template for more information
using gamesProgram;
using System.Collections;
/*
Console.WriteLine("Hello, World!");

Console.WriteLine("How are you \nJhon\"");


string name = "Arif";
Console.WriteLine(name);
int number = 347832784;
Console.WriteLine(number);

double number2 = 32.43;
Console.WriteLine(number2);
char c = 'a';
Console.WriteLine(c);





var a = 7.6;

const int b = 3;



Console.WriteLine(b);

Console.WriteLine(a);


*/
/*

string name = "Arif";
string lastname = "Alvi";

Console.WriteLine("Hello " + "klfkdslakf");
Console.WriteLine("Hello " + name + "jfkjdskf" + lastname);
Console.WriteLine($"Hello {name} how's your father {lastname}");

*/




/*

string a = "34";

var b = Convert.ToInt32(a);


Console.WriteLine(b.GetType());


*/

/*

Console.WriteLine(2+4);
Console.WriteLine(2*4);
Console.WriteLine(Math.Abs(2-4));
Console.WriteLine(2/4);
Console.WriteLine(4/2);



*/


/*

Console.WriteLine(Math.Pow(2,3));
Console.WriteLine(Math.Sqrt(144));
Console.WriteLine(Math.Abs(-5));
Console.WriteLine(Math.Round(3.4));
Console.WriteLine(Math.Round(3.9));
Console.WriteLine(Math.Ceiling(3.1));
Console.WriteLine(Math.Floor(3.9));
Console.WriteLine(Math.Min(30,40));
Console.WriteLine(Math.Max(30,40));


*/




/*
Random random = new Random();

Console.WriteLine(random.Next(1, 3));

Console.WriteLine(Math.Round(random.NextDouble() * 100));

*/



/*
string str = "This is my House";

Console.WriteLine(str.ToUpper());
Console.WriteLine(str.ToLower());
Console.WriteLine(str.Replace("is","are"));
Console.WriteLine(str.Insert(16,"!"));
Console.WriteLine(str.Substring(4,5));
Console.WriteLine(str.Length);

*/


/*

var age = 18;

if(age < 18)
{
    Console.WriteLine("You are too young to vote");
}
else if(age > 18)
{
    Console.WriteLine("You are able to vote");
}
else
{
    Console.WriteLine("You are unable to vote");
}


int days = 2;

switch(days)
{
    case 1:
    Console.WriteLine("Today is Monday!");
    break;
    case 2:
    Console.WriteLine("Today is Tuesday!");
    break;
    case 3:
    Console.WriteLine("Today is Wednesday!");
    break;
    case 4:
    Console.WriteLine("Today is Thursday!");
    break;
    case 5:
    Console.WriteLine("Today is Friday!");
    break;
    case 6:
    Console.WriteLine("Today is Saturday!");
    break;
    case 7:
        Console.WriteLine("Today is Sunday!");
    break;
    default:
        Console.WriteLine("You Entered wrong day");
        break;
}

*/



//try
//{
//    Console.WriteLine("Enter your name: ");
//    int name = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine($"Hello {name.GetType()}");

//}
//catch(FormatException)
//{
//    Console.WriteLine("Kindly enter numbers only!");
//}




//var age = 97;

//if (age < 18)
//{
//    Console.WriteLine("You are too young to vote");
//}
//else if (age > 18 || age < 80)
//{
//    Console.WriteLine("You are able to vote");
//}
//else
//{
//    Console.WriteLine("You are unable to vote");
//}


//var age = 97;

//if (age < 18)
//{
//    Console.WriteLine("You are too young to vote");
//}
//else if (age > 18 && age < 80)
//{
//    Console.WriteLine("You are able to vote");
//}
//else
//{
//    Console.WriteLine("You are unable to vote");
//}






//int a = Convert.ToInt32(Console.ReadLine());





//Console.WriteLine(a);

//int c = 1;


//while (c <= 10)
//{
//    Console.WriteLine(c);
//    c++;
//}


//Console.WriteLine("Enter your name: ");
//string name = Console.ReadLine();

//while(name == "")
//{
//    Console.WriteLine("Enter your name: ");
//    name = Console.ReadLine();
//}

//Console.WriteLine($"Hello {name}");



//for(int i = 0; i <= 10; i++)
//{
//    Console.WriteLine(i);

//}


//for (int i = 0; i <= 5; i++)
//{
//    for(int j = 0;  j <= 6; j++)
//    {
//        Console.Write(j);
//        Console.Write("|");
//    }
//    Console.WriteLine();
//}






//int[] numbers = { 1, 2, 34, 5, 7, 8, 98, 9 };



//Console.WriteLine(numbers[3]);


//for(int i = 0; i <= numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

//foreach(int items in numbers)
//{
//    Console.WriteLine(items);
//}




//int[,] numbers =
//{
//    {1,2,4},
//    {3,4,5},
//    {6,7,8},
//    {45,56,7}
//};


//foreach(int number in numbers)
//{
//    Console.WriteLine(number);
//}

//Jagged Array


//int[][] numbers = new int[4][];

//numbers[0] = [1, 2, 3, 5, 6, 8, 9];
//numbers[1] = [34,45,6,788,87,546,345,43,434,65,7,76,87];
//numbers[2] = [1, 2];
//numbers[3] = [34, 56, 77];

//Console.WriteLine(numbers[1][3]);


//foreach(var n in numbers)
//{
//    foreach(int m in n)
//    {
//    Console.WriteLine(m);

//    }
//    Console.WriteLine("_____________________________");
//}




//string[] title = { "10 Best Habbits", "3 ways to make money", "Introd to JS"};





//List<string> movies = new List<string>();


//movies.Add("A");
//movies.Add("B");
//movies.Add("C");
//movies.Add("D");
//movies.Add("E");

//movies.Add("F");
//movies.Add("G");
//movies.Add("E");

//movies.Remove("D");



//movies.Insert(3, "Zoom");
//Console.WriteLine("index of : "+movies.IndexOf("E"));
//Console.WriteLine("Contains : "+movies.Contains("fdsfsa"));
//Console.WriteLine($"Count : {movies.Count}");
//Console.WriteLine($"Last index of: {movies.LastIndexOf("E")}");




////Console.WriteLine(movies);

//Console.WriteLine("Before Sort: ");
//foreach (string movie in movies)
//{
//    Console.WriteLine(movie);
//}


//movies.Sort();
//movies.Reverse();
////movies.Clear();


//Console.WriteLine("After Sort: ");


//foreach (string movie in movies)
//{
//    Console.WriteLine(movie);
//}


//string[] moviesArray = movies.ToArray();

//Console.WriteLine(movies);
//Console.WriteLine(moviesArray);

//foreach(string movie in moviesArray)
//    {
//    Console.WriteLine(movie);
//}







//Games gta = new Games();

//gta.gameName = "GTA 5";
//gta.gameVersion = 5;
//gta.companyName = "Rockstar";
//gta.rating = 5.0;


//Games supermario = new()
//{
//    gameName = "Super Mario 4",
//    gameVersion = 4,
//    rating = 3.4,
//    companyName = "Nintendo"
//};



//Console.WriteLine($"The game name is: {supermario.gameName}");

//Console.WriteLine(gta.gameName);
//Console.WriteLine(gta);

//Car mehran = new("Mehran Euro","Suzuki",1990);

//mehran.brand = "Honda";

//Console.WriteLine(mehran.carName);
//Console.WriteLine(mehran.brand);

//Car alto = new("Alto VXR");

//alto.carName = "Alto Japan";

//Console.WriteLine(alto.carName);






//class Car
//{
//    public string carName { get; }
//    public string brand {  get; set; }
//    public int model;
//    //public int MyProperty { get; set; }
//    public Car(string carName, string brand, int model)
//    {
//        this.carName = carName;
//        this.brand = brand;
//        this.model = model;
//    }
//    public Car(string carName, string brand)
//    {
//        this.carName = carName;
//        this.brand = brand;
//    }
//    public Car(string carName)
//    {
//       this.carName = carName;

//    }

//}






















//Game supermario = new()
//{
//    gameName = "Super Mario 6",
//    gameVersion = 6,
//    company = "Nintendo"
//};


//Console.WriteLine("The name of the game is: {0} and the versio of game is: {1} and compnay name is: {2}",
//    supermario.gameName,
//    supermario.gameVersion,
//    supermario.company);


//Console.WriteLine($"The name of the game is: {supermario.gameName} and the versio of game is: " +
//    $"{supermario.gameVersion} and compnay name is: {supermario.company}");



//string userinput = Console.ReadLine();

//supermario.isGameAvailable(userinput.ToUpper());


//string userinput1 = Console.ReadLine();

//Game.isWebsiteDown(userinput1);

//Nintendo flagman = new()
//{
//    gamesName = "Flag man 1980",
//    gameVersion = 1,
//    company = "Nintendo.org"
//};


//Console.WriteLine(flagman.gameName);

//flagman.gameNamePrint();






/*class Game
{
    private string gameName;
    public int gameVersion;
    public string company;



    public void isGameAvailable(string a)
    {
        if (a == "yes")
        {
            Console.WriteLine("You can download this game");
        }
        else if(a == "No")
        {
            Console.WriteLine("You can not download this game");
        }
        else
        {
            Console.WriteLine("Kindly enter valid input");
        }

    }

    public static int isWebsiteDown(string c)
    {
       if (c == "404")
        {
            Console.WriteLine("Sorry for inconvenience!");
        }
        else if(c == "200")
        {
           Console.WriteLine("The website is running successfully");
        }
        else {
            Console.WriteLine("Kindly enter valid value");
        }
        return 0;
    }







}


class Nintendo : Game
{



    //for private and inheritance
    //public void gameNamePrint()
    //{
    //   this.gameName = "Flagman 1970";
    //    Console.WriteLine(this.gameName);
    //}


}
*/







/*

Nintendo supermario = new()
{
    gameName = "Super Mario 8",
    gameVersion = 3.4,
    company = "Ninetndo Corp."
};


Console.WriteLine($"Nintendo Super Mario Price: $.{supermario.gamePrice(2)}");


Ubisoft supermarioUbi = new()
{
    gameName = "Super Mario 8",
    gameVersion = 3.4,
    company = "Ninetndo Corp."
};

Console.WriteLine($"Ubisoft Super Mario Price: $.{supermarioUbi.gamePrice(2)}");

Console.WriteLine(supermario.ToString());


Console.ReadKey();

abstract class Game
{
    public string gameName; 
    public double gameVersion;
    public string company;

    public virtual double gamePrice(int quantity) { return 0; }

}


class Nintendo : Game
{

    public override double gamePrice(int quantity)
    {
        return (quantity * 20) + 40;
    }
    public override string ToString()
    {
        return $"Game Name: {this.gameName} \nGame Version: {this.gameVersion} \nCompany Name: {this.company}";
    }
}

class Ubisoft : Game
{
    public override double gamePrice(int quantity)
    {
        return (quantity * 20) + 10 + 50;
    }
}*/


/*Audionic headphone = new()
{
    prodName = "Max Pro 5 Earphone",
    grossPrice = 534.99,
    prodRating = 3.4
};

Console.WriteLine(headphone.prodDesc());
Console.WriteLine(headphone.salePrice(56));

Audionic speaker = new()
{
    prodName = "Max Pro 5 Speaker",
    grossPrice = 1000.99,
    prodRating = 4.5
};

Console.WriteLine(speaker.prodDesc());
Console.WriteLine(speaker.salePrice(80));
//Console.WriteLine(speaker.colors());


Cosmetics lipstick = new()
{
    prodName = "5 shades Lipstick",
    prodRating = 3.4,
    grossPrice = 3400
};

Console.WriteLine(lipstick.prodDesc());
Console.WriteLine(lipstick.salePrice(45));
Console.WriteLine(lipstick.colors());







interface IElectronics
{
    string prodDesc();
    double salePrice(double taxAmount);
}

interface ICosmetics
{
    string colors();
}



class Audionic : IElectronics
{

    public string prodName;
    public double grossPrice;
    public double prodRating;

    public string prodDesc()
    {
        return $"\nProduct Name: {this.prodName} \nGross Price: {this.grossPrice} \nProduct Rating: {this.prodRating}";
    }

    public double salePrice(double taxAmount)
    {
        return this.grossPrice + taxAmount;
    }
}




class Cosmetics : IElectronics, ICosmetics
{

    public string prodName;
    public double grossPrice;
    public double prodRating;

    public string prodDesc()
    {
        return $"\nProduct Name: {this.prodName} \nGross Price: {this.grossPrice} \nProduct Rating: {this.prodRating}";
    }

    public double salePrice(double taxAmount)
    {
        return this.grossPrice + taxAmount;
    }

    public string colors()
    {
        return "Red, Pink, Orange, RedishPink";
    }
}*/



/*Console.WriteLine(weekDays.Saturday);
Console.WriteLine((int)weekDays.Thursday);

Console.WriteLine((int)employee.Arif * 12);

enum employee
{
    Arif = 8900,
    Zahid = 6700,
    Amir = 5600,
    Haris = 12000,
    GhafoorKhan = 450000,
    GhafoorAkmal = 23000
}

enum weekDays
{
    Monday = 67,
    Tuesday = 90,
    Wednesday = 89,
    Thursday = 76,
    Friday = 54,
    Saturday = 89,
    Sunday = 45
}*/










string[] names = ["Lahore", "Karachi", "Faislabad", "Islamabad", "Multan"];

/*foreach (string name in names)
{
    Console.WriteLine(name);
}*/

int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 11];

/*foreach (int num in nums)
{
    Console.WriteLine(num);
}*/

/*displayElement(nums);
displayElement(names);



static void displayElement<A>(A[] values)
{
    foreach (A value in values)
    {
        Console.WriteLine(value);
    }
}*/

/*static void displayElement(string[] values)
    {
        foreach(string value in values)
        {
            Console.WriteLine(value);
        }
    }*/


















/*Products headphone = new()
{
    Id = 90
};*/
/*headphone[0] = 4.4;
headphone[1] = 6.4;*/

//Console.WriteLine(headphone.Id);
//Console.WriteLine(headphone[0]);
//Console.WriteLine(headphone[1]);


/*for (int i =0; i <= 1; i++)
{
    Console.WriteLine(headphone[i]);
}    




class Products
{

    public int Id { get; set; }
    private double[] ratings = new double[10];

    public double this[int index]
    {
        get { return ratings[index]; }
        set 
        {
           if(value >= 0 && value <= 5)
            {
                ratings[index] = value;  
            }
           else
            {
                Console.WriteLine("Kindly enter values in the range of 0 to 5");
            }
        }
    }



}*/



//Timer.timer1();
//Timer.timer2();
//Timer.timer3();

//Thread t1 = new(Timer.timer1);
//Thread t2 = new(Timer.timer2);
//Thread t3 = new(Timer.timer3);
//t1.Name = "timer 1";

//Console.WriteLine(t1.Name);
//Console.WriteLine(t2.Name);


//t1.Start();
//t3.Start();
//t2.Start();
//t1.Abort();




/*
class Timer
{
    public static void timer1()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{i} second of timer 1");
            Thread.Sleep(1000);
        }
    }

    public static void timer2()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"{i} second of timer 2");
            Thread.Sleep(2000);
        }
    }


    public static void timer3()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{i} second of timer 3");
            Thread.Sleep(3000);
        }
    }
}*/












//await Task.WhenAll(Timer.timer1(), Timer.timer2(), Timer.timer3());
/*
await Timer.timer1();
await Timer.timer2();

Console.WriteLine("All timers run successfully");





class Timer
{
    public static async Task timer1()
    {
        await Task.Run(() => 
        {
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{i} second of timer 1");
                Thread.Sleep(1000);
            }
        });
    }

    public static async Task timer2()
    {
        await Task.Run(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"{i} second of timer 2");
                Thread.Sleep(2000);
            }
        });
    }


    public static async Task timer3()
    {
        await Task.Run(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"{i} second of timer 3");
                Thread.Sleep(3000);
            }
        });
    }
}
*/









/*
Persons p1 = new("Zahid", "Khan", 22);

Console.WriteLine(p1);


public record Persons(string firstName, string lastName, int age);*/













/*Person p1 = new()
{
    firstName = "Zahid",
    lastName = "Khan",
    age = 19
};

Console.WriteLine(p1);*/



/*List<Person> persons = new List<Person>()
{
    new()
    {
        firstName = "Zahid",
        lastName = "Khan",
        age = 10
    },
    new()
    {
        firstName = "Ajmal",
        lastName = "Hanif",
        age = 20
    },
    new()
    {
        firstName = "Haris",
        lastName = "Naeem",
        age = 23
    },
    new()
    {
        firstName = "Zafar",
        lastName = "Akmal",
        age = 34
    },
    new()
    {
        firstName = "Hina",
        lastName = "Zara",
        age = 45
    }

};*/



/*var ageAbove23 = 
    from a in persons
    where a.age > 23
    orderby a.age descending
    select a;

*/

/*foreach (var d in ageAbove23)
{
    Console.WriteLine(d);
}*/

/*var ageAbove23 = persons.Where(p => p.age > 23);

foreach(var d in ageAbove23)
{
    Console.WriteLine(d);
}
*/


/*foreach (var person in persons)
{
    Console.WriteLine(person);
}
*/

/*public record Person
{
    public required string firstName;
    public string lastName;
    public int age;
}*/




















Products headphone = new();
headphone.color = "Blue";
headphone[0] = 2.3;
headphone[1] = 4.3;
headphone[2] = 1.3;
headphone[3] = 3.3;
//Console.WriteLine(headphone.color);


foreach(var rating in headphone)
{
    Console.WriteLine(rating);
}


class Products :IEnumerable
{
    public string? color;
    public double[] ratings = new double[4];

    public double this[int index]
    {
        get { return ratings[index]; }
        set 
        {
            ratings[index] = value;
        }
    }

    public IEnumerator GetEnumerator()
    {
        return ratings.GetEnumerator();
    }
    

}


















