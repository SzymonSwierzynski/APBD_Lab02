// See https://aka.ms/new-console-template for more information

String course = "APBD";
String semester = "4";
Console.WriteLine("Hello, " + course + " semester: " + semester + "!!!");

double CalculateAverage(int[] values)
{
    if (values.Length < 1)
    {
        throw new InvalidDataException();
    }
    {
        
    }
    double avg = 0;
    for (int i = 0; i < values.Length; i++)
    {
        avg += values[i];
    }

    return avg / values.Length;
}

int CalculateMax(int[] values)
{
    int max = values[0];
    foreach (var i in values)
    {
        if (i > max)
        {
            max = i;
        }
    }

    return max;
}

int CalculateMin(int[] values)
{
    int min = values[0];

    foreach (var i in values)
    {
        if (i < min)
        {
            min = i;
        }
    }

    return min;
}
