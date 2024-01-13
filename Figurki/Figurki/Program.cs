using Figurki;

Point point = new Point(1,2,3);
Console.WriteLine("Point: " + point.GetSize());

Okrug okrug = new Okrug(2, 1, 2, 3);
Console.WriteLine("Okrug: " + okrug.GetSize());

Krug krug = new Krug(3, 1, 2, 3);
Console.WriteLine("Krug: " + krug.GetSize());

Shar shar = new Shar(2, 1, 2, 3);
Console.WriteLine("Shar: " + shar.GetSize());

PointOkrug pointokrug = new PointOkrug(1, point);
Console.WriteLine("PointOkrug: " + pointokrug.GetSize());

PointKrug pointkrug = new PointKrug(pointokrug);
Console.WriteLine("PointKrug: " + pointkrug.GetSize());

PointShar pointshar = new PointShar(pointkrug);
Console.WriteLine("PointShar: " + pointshar.GetSize());


