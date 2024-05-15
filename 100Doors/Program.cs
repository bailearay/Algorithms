// See https://aka.ms/new-console-template for more information
//if array[i] has value of 0 indicates closed 1 indicates opened.
int[] OpenDoors(int numDoors)
{

  int[] doors = new int[numDoors];

  //toggles door if visited
  for (int j = 0; j < doors.Length; j++)
  {
    for (int i = j; i < doors.Length; i += j + 1)
    {
      if (doors[i] == 0)
      {
        doors[i] = 1;
      }
      else
      {
        doors[i] = 0;
      }
    }
  }

  List<int> doorNums = new List<int>();
  for (int i = 0; i < doors.Length; i++)
  {
    if (doors[i] == 1)
    {
      doorNums.Add(i + 1);
    }
  }

  return doorNums.ToArray();
}

Console.WriteLine("This app will return an array of the doors that are opened if someone were to toggle each door any time they visit the door. For example, there are 100 doors in a row, all doors are initially closed. A person walks through all doors multiple times and toggle (if open then close, if close then open) them in the following way: In the first walk, the person toggles every door In the second walk, the person toggles every second door, i.e., 2nd, 4th, 6th, 8th, … In the third walk, the person toggles every third door, i.e. 3rd, 6th, 9th, … In the 100th walk, the person toggles the 100th door. \n\n");

int numberOfDoors = 0;


while (true)
{
  try
  {
    Console.Write("Please enter an integer to represent the number of doors: ");
    var userInput = Console.ReadLine();
    numberOfDoors = int.Parse(userInput);
  }
  catch (FormatException e)
  {
    Console.WriteLine("You did not enter an integer. Please try again.\n");

    continue;
  }
  break;
}

if (numberOfDoors < 2)
{
  Console.WriteLine($"You entered {numberOfDoors} door.\n");
}
else
{
  Console.WriteLine($"You entered {numberOfDoors} doors.\n");
}
int[] opened = OpenDoors(numberOfDoors);

if (opened.Length != 1)
{
  Console.Write("Door numbers");
  for (int i = 0; i < opened.Length; i++)
  {
    if (i < opened.Length - 1)
    {
      Console.Write(" " + opened[i] + ",");
    }
    else
    {
      Console.Write(" and " + opened[i]);
    }
  }

  Console.Write(" are open.");
}
else
{
  Console.Write($"Door number {opened[0]} is open");
}
