using Laba9_V5;


List<Rectangle> rectangles = new List<Rectangle>();
List<Parallelogram> parallelograms = new List<Parallelogram>();
List<Square> squares = new List<Square>();
Random random = new Random();
int numberQuadrangle = 10;
double sumArea = 0;
double sumPerimeter = 0;



while (true)
{
    rectangles.Add(new Rectangle(random.Next(10), random.Next(10)));
    --numberQuadrangle;
    if(numberQuadrangle ==  0) break;
    
    parallelograms.Add(new Parallelogram(random.Next(10), random.Next(10), random.Next(10)));
    --numberQuadrangle;
    if(numberQuadrangle == 0) break;
    
    squares.Add(new Square(random.Next(10)));
    --numberQuadrangle;
    if(numberQuadrangle == 0) break;
}

foreach (var item in squares)
{
    sumArea += item.Area();
}

foreach (var item in rectangles)
{
    sumArea += item.Area();
}

foreach (var item in parallelograms)
{
    sumPerimeter += item.Perimeter();
}

Console.WriteLine(sumArea);
Console.WriteLine(sumPerimeter);