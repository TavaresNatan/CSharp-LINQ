//HOW TO DO LINQ SEARCHS IN C#

//we will need this for now
int index = 1;
var show_results = (IEnumerable<dynamic> list) => 
{
    Console.WriteLine("Results of the search " + index + ":");
    foreach(var p in list)
    {
        Console.WriteLine(p);
    }
    index++;
};



//first lets declare our target:
var list = new List<dynamic>
    {
        new { Name = "Ana", Age = 28},
        new { Name = "Natan", Age = 18},
        new { Name = "Amanda", Age = 14 },
        new { Name = "James", Age = 23 }
    };


//then do a simple search:
var search1 = from person in list select person; //easy to read, right?
show_results(search1); //and see the result


//but, what if i want only +18 people?
var search2 = from person in list
              where person.Age >= 18 //the 'where' keyword can help us with that! it works just like an 'if'
              select person;
show_results(search2);


//now lets sort them by the youngest to the oldest
var search3 = from person in list
              where person.Age >= 18
              orderby person.Age //baam, use this guy lol
              select person;
show_results(search3);


//and what if i wanted to limit an age?
var search4 = from person in list
              where person.Age >= 18 && person.Age <= 25
              select person;
show_results(search4);


//one more. How do i look for an specific name?
var search5 = from person in list
              where person.Name == "Natan" //got it? 'where' is aways an boolean
              select person;
show_results(search5);


Console.WriteLine("PRESS [ENTER] TO CLOSE.");
Console.ReadLine();