// Найти расстояние между точками в пространстве 2D/3D

int x1 = new Random().Next(1, 10);
int x2 = new Random().Next(1, 10);
int y1 = new Random().Next(1, 10);
int y2 = new Random().Next(1, 10);
int z1 = new Random().Next(1, 10);
int z2 = new Random().Next(1, 10);
Console.WriteLine($"Координаты первой точки ({x1}, {y1}, {z1})");
Console.WriteLine($"Координаты второй точки ({x2}, {y2}, {z2})");

double d = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));

Console.WriteLine($"Расстояние между точками: {d}");