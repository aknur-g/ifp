using static System.Console;

int max = 500;

for (byte i = 0; i < max; i++)
{
if (i == byte.MaxValue)
{
    WriteLine("WARNING: i is about to overflow.");
    break;
}
}
