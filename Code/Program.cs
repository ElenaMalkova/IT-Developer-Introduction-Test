// See https://aka.ms/new-console-template for more information
string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
string[] new_array = new string[4];
int new_index = 0;
for (int index = 0; index < 4; index++)
{
    if (cars[index].Length <= 3) new_array[new_index] = cars[index];
    Console.WriteLine(new_array[new_index]);
    new_index++;
}

