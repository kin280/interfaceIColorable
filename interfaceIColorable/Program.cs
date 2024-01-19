using System;

public interface IColorable
{
    void HowToColor();
}


public class HinhVuong : IColorable
{
    public double Canh { get; set; }

    public HinhVuong(double canh)
    {
        Canh = canh;
    }

    public void HowToColor()
    {
        Console.WriteLine("Tô màu cho hình vuông");
    }
}


public class ChuongTrinh
{
    public static void Main()
    {
        HinhVuong hinhVuong = new HinhVuong(4);

        Console.WriteLine("Hướng dẫn cách tô màu cho hình vuông:");
        hinhVuong.HowToColor();
    }
}
