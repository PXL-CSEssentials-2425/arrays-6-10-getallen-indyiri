
bool isInputValid = false;

double[] numbers = new double[10];

do
{
    Console.WriteLine("=== Getal opvragen uit 10 ===");
    Console.WriteLine();
    Console.Write("Geef 1ste getal: ");
    string inputFirstNumber = Console.ReadLine();
    Console.WriteLine();
    Console.Write("Geef 2de getal: ");
    string inputSecondNumber = Console.ReadLine();
    Console.WriteLine();
    Console.Write("Geef 3de getal: ");
    string inputThirdNumber = Console.ReadLine();
    Console.WriteLine();
    Console.Write("Geef 4de getal: ");
    string inputFourthNumber = Console.ReadLine();
    Console.WriteLine();
    Console.Write("Geef 5de getal: ");
    string inputFifthNumber = Console.ReadLine();
    Console.WriteLine();
    Console.Write("Geef 6de getal: ");
    string inputSixthNumber = Console.ReadLine();
    Console.WriteLine();
    Console.Write("Geef 7ste getal: ");
    string inputSeventhNumber = Console.ReadLine();
    Console.WriteLine();
    Console.Write("Geef 8de getal: ");
    string inputEighthNumber = Console.ReadLine();
    Console.WriteLine();
    Console.Write("Geef 9de getal: ");
    string inputNinthNumber = Console.ReadLine();
    Console.WriteLine();
    Console.Write("Geef 10de getal: ");
    string inputTenthNumber = Console.ReadLine();
    Console.WriteLine();

    bool isFirstNumberValid = double.TryParse(inputFirstNumber, out numbers[0]);
    bool isSecondNumberValid = double.TryParse(inputSecondNumber, out numbers[1]);
    bool isThirdNumberValid = double.TryParse(inputThirdNumber, out numbers[2]);
    bool isFourthNumberValid = double.TryParse(inputFourthNumber, out numbers[3]);
    bool isFifthNumberValid = double.TryParse(inputFifthNumber, out numbers[4]);
    bool isSixthNumberValid = double.TryParse(inputSixthNumber, out numbers[5]);
    bool isSeventhNumberValid = double.TryParse(inputSeventhNumber, out numbers[6]);
    bool isEighthNumberValid = double.TryParse(inputEighthNumber, out numbers[7]);
    bool isNinthNumberValid = double.TryParse(inputNinthNumber, out numbers[8]);
    bool isTenthNumberValid = double.TryParse(inputTenthNumber, out numbers[9]);

    if (!isFirstNumberValid || !isSecondNumberValid || !isThirdNumberValid || !isFourthNumberValid || !isFifthNumberValid || !isSixthNumberValid || !isSeventhNumberValid || !isEighthNumberValid || !isNinthNumberValid || !isTenthNumberValid || numbers[0] == 0.0 || numbers[1] == 0.0 || numbers[2] == 0.0 || numbers[3] == 0.0 || numbers[4] == 0.0 || numbers[5] == 0.0 || numbers[6] == 0.0 || numbers[7] == 0.0 || numbers[8] == 0.0 || numbers[9] == 0.0)
    {
        Console.WriteLine("U moet getallen ingeven die niet gelijk zijn aan 0!");
        Console.ReadKey(true);
        Console.Clear();
    }
    else
    {
        Console.WriteLine("De even getallen worden nu afgedrukt:");

        foreach (double number in numbers)
        {
            if (number % 2 == 0)
            { 
                Console.WriteLine($"Het getal op plaats {Array.IndexOf(numbers, number) + 1} is een even getal, namelijk {number}");
            }
        }

        isInputValid = true;
    }
}
while (isInputValid == false);