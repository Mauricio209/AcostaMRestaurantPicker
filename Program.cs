//Mauricio Acosta
//10-19-22
//GitChallange Restaurant Picker

Console.Clear();

string playAgain = "yes";
while (playAgain == "yes")
{

string usersAnswer = "";

Console.WriteLine("Today you want to go somewhere to eat but dont know where to go well im here to help!");
while(usersAnswer != "df" && usersAnswer != "sf" && usersAnswer != "ff") 
{
    Console.WriteLine("what would you like to eat today, type sf for street food, ff for Fast food or df   for Dine in Food? ");
usersAnswer = Console.ReadLine();
if (usersAnswer != "df" && usersAnswer != "sf" && usersAnswer != "ff")
{    
    Console.WriteLine("Invalid Answer");
}


}

if(usersAnswer == "df")
{

Random rnd = new Random();

 string[] resturants =  {"IHop","Texas Road House","Apple Bees","Bob's Cafe","Red Lobster","Arbys","Chillys","Dennys","Olive Garden","Quiznos"};
 int index = rnd.Next(resturants.Length);
 Console.WriteLine(resturants[index]);


 
}




else if(usersAnswer == "sf")
{
    Random rnd = new Random();

 string[] resturants =  {"Taco Truck","Beni Hibachi","Mongolian","Little Ceasers","PizzaHut","Jessicas Mexican food","Armandos Birria Tacos","Smokey BBQ","Testys Sea Food","Tacos Chapala"};
 int index = rnd.Next(resturants.Length);
 Console.WriteLine(resturants[index]);
}

else if(usersAnswer == "ff")
{
    Random rnd = new Random();

 string[] resturants =  {"In n out","Mcdonalds","Jack in the box","burger king","","Wings and rings","Taco Bell","starbucks","Crumbl Cookies","Hot Rods"};
 int index = rnd.Next(resturants.Length);
 Console.WriteLine(resturants[index]);
}
Console.WriteLine("Type yes to play again");
playAgain = Console.ReadLine();
}