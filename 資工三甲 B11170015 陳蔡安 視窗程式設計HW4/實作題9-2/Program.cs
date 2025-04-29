public class Box 
{
    private double Width;
    private double Height;
    private double Length;
    public Box(double width, double height, double length)
    {
        Width = width;
        Height = height;
        Length = length;
    }
    public double Volume()
    {
        return Width * Height * Length;
    }
    public double Area()
    {
        return Width * Length;
    }

}
public static class Program
{
    public static void Main(string[] args)
    {
        Box box = new Box(2, 3, 4);
        Console.WriteLine("Volume: " + box.Volume());
        Console.WriteLine("Area: " + box.Area());
        Console.WriteLine(
            "+----------------------------------------------+\r\n" +
            "|                     Box                      |\r\n" +
            "+----------------------------------------------+\r\n" +
            "| - Width:  double                             |\r\n" +
            "| - Height: double                             |\r\n" +
            "| - Length: double                             |\r\n" +
            "+----------------------------------------------+\r\n" +
            "| + Box(width: double, height: double,         |\r\n" +
            "|       length: double)                        |\r\n" +
            "| + Volume(): double                           |\r\n" +
            "| + Area(): double                             |\r\n" +
            "+----------------------------------------------+"
        );
    }
}