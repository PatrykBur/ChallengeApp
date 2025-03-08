var name = "Ewa";
var sex = "female";
var age = 30;

if (sex == "female" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa lat 30");
}
else if (sex != "female" && age < 18)
{
    Console.WriteLine("Niepenoletni mężczyzna");
}