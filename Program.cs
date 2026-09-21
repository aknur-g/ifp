using static System.Console;

int x;
int y;

x = 3;
y = 2 + ++x;

WriteLine($"x = {x}");
WriteLine($"y = {y}");

x = 3 << 2;
y = 10 >> 1;

WriteLine($"x = {x}");
WriteLine($"y = {y}");


x = 10 & 8;
y = 10 | 7;

WriteLine($"x = {x}");
WriteLine($"y = {y}");