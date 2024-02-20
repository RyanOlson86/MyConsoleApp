string firstName = "Ryan";
int age = 37;
bool isCool = true;

Console.WriteLine(firstName + " is " + age + ". Is he cool? " + isCool);


// if/ else if/ else statement
if (age < 40 && isCool == true)
{
  Console.WriteLine("young and cool");
} 
else if (age < 40 && isCool == false) 
{
  Console.WriteLine("young but not cool");
} 
else
{
  Console.WriteLine("You are Old");
}

//  Make a switch block
switch(age) 
{
  case <40:
    Console.WriteLine("You are young");
    break;
  case >40:
    Console.WriteLine("You are Old");
    break;
  default:
    Console.WriteLine("You are 40");
    break;
}

// Make an array of strings
string[] pets = {"dog", "cat", "iguana"};
Console.WriteLine(pets[0]);
Console.WriteLine(pets[1]);
Console.WriteLine(pets[2]);

// Make a for loop
//  Log each item
for( int i=0; i<pets.Length; i++){
    Console.WriteLine(pets[i]);
}

// Use a foreach loop
foreach( string pet in pets){
    Console.WriteLine(pet);
}