using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter mass in earth: ");
        /*
        การชั่งน้ำหนักจากเครื่องชั่งน้ำหนักนั้นเป็นการชั่งมวล ไม่ใช่น้ำหนักจริงๆบนโลก
        การหาน้ำหนักบนโลก จะเป็น W = mg ตามกฎของนิวตัน
        W คือน้ำหนัก(N)
        m คือมวล(kg)
        g คือแรงดึงดูดของโลก มีค่า = 9.81 m/s^2
        */
        float m = float.Parse(Console.ReadLine());

        weigth_Moon(m);
        Console.ReadKey();
    }

    static void weigth_Moon(float mass)
    {
        //ค่า g บนโลกจะมากกว่าบนดวงจันทร์ 6 เท่า
        Console.WriteLine("Weigth in moon is {0:F1}", mass * (9.8 / 6));
    }
}