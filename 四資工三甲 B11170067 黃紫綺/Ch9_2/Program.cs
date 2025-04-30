using System;

public class Box //這裡是類別
{
    private double Width;
    private double Height;
    private double Length;

    public Box(double width, double height,double length) //建構子 
    {
        Width = width; 
        Height = height; 
        Length = length;
    }
    public double Volume() //計算體積
    {
        return Width * Height * Length;
    }
    public double Area() //計算面積
    {
        return 2 * (Width * Height + Height * Length + Width * Length);
    }
    
}
public class Program //主程式 類別
{
    public static void  Main(string[] args) //函數
{
    Console.WriteLine("輸入長度：");
    double length = double.Parse(Console.ReadLine());  
    Console.WriteLine("輸入寬度：");
    double width = double.Parse(Console.ReadLine());
    Console.WriteLine("輸入高度：");
    double height = double.Parse(Console.ReadLine());

    Box box = new Box(length,width,height); //將Box類別中的資料呼叫出來並套用主程式的長寬高
    
    Console.WriteLine("Volume: " + box.Volume()); 
    Console.WriteLine("Area: " + box.Area());
    }
}
