using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

class Laptop
{
    public string merk;
    public string tipe;
    public Vga vga;
    public Processor processor;

    public Laptop(string merk, string tipe, Vga vga, Processor processor)
    {
        this.merk = merk;
        this.tipe = tipe;
        this.vga = vga;
        this.processor = processor;
    }
    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {this.merk} {this.tipe} menyala");
    }
    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {this.merk} {this.tipe} mati");
    }
    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }

}

class ASUS : Laptop
{
    public string merk = "ASUS";

    public ASUS(string merk, string tipe, Vga vga, Processor processor) : base("ASUS", tipe, vga, processor)
    { }
}

class ACER : Laptop
{
    public string merk = "ACER";

    public ACER(string merk, string tipe, Vga vga, Processor processor) : base("ACER", tipe, vga, processor)
    { }
}

class Lenovo : Laptop
{
    public string merk = "Lenovo";

    public Lenovo(string merk, string tipe, Vga vga, Processor processor) : base("Lenovo", tipe, vga, processor)
    { }
}

class ROG : ASUS
{
    public string tipe = "ROG";

    public ROG(string merk, string tipe, Vga vga, Processor processor) : base(merk, "ROG", vga, processor)
    { }

}

class Vivobook : ASUS
{
    public string tipe = "Vivobook";

    public Vivobook(string merk, string tipe, Vga vga, Processor processor) : base(merk, "Vivobook", vga, processor)
    { }

    
}

class Swift : ACER
{
    public string tipe = "Swift";

    public Swift(string merk, string tipe, Vga vga, Processor processor) : base(merk, "Swift", vga, processor)
    { }
}

class Predator : ACER
{
    public string tipe = "Predator";

    public Predator(string merk, string tipe, Vga vga, Processor processor) : base(merk, "Predator", vga, processor)
    { }

    public void BermainGame()
    {
        Console.WriteLine($"Laptop {merk} {tipe}  game");
    }
}

class IdeaPad : Lenovo
{
    public string tipe = "IdeaPad";

    public IdeaPad(string merk, string tipe, Vga vga, Processor processor) : base(merk, "IdeaPad", vga, processor)
    { }
}

class Legion : Lenovo
{
    public string tipe = "Legion";

    public Legion(string merk, string tipe, Vga vga, Processor processor) : base(merk, "Legion", vga, processor)
    { }
}

class Processor
{
    public string merk;
    public string tipe;
    public Processor(string merk, string tipe)
    {
        this.merk = merk;
        this.tipe = tipe;
    }
}
class Intel : Processor
{
    public Intel(string merk, string tipe) : base("Intel", tipe)
    { }

}

class AMD : Processor
{
    public AMD(string merk, string tipe) : base("AMD", tipe)
    { }
}

class CoreI3 : Intel
{
    public CoreI3(string merk, string tipe) : base(merk, "Core I3")
    { }
}

class CoreI5 : Intel
{
    public CoreI5(string merk, string tipe) : base(merk, "Core I5")
    { }
}

class CoreI7 : Intel
{
    public CoreI7(string merk, string tipe) : base(merk, "Core I7")
    { }
}

class Ryzen : AMD
{
    public Ryzen(string merk, string tipe) : base(merk, "RAYZEN")
    { }
}

class Athlon : AMD
{
    public Athlon(string merk, string tipe) : base(merk, "ATHLON")
    { }
}

class Vga
{
    public string merk;

    public Vga(string merk)
    {
        this.merk = merk;
    }
}

class Nvidia : Vga
{
    public Nvidia(string merk) : base("Nvidia")
    { }
}

class Amd : Vga
{
    public Amd(string merk) : base("Amd")
    { }
}




class Program
{
    static void Main()
    {
        Vga vgaN = new Vga ("Vga            : Nvidia");
        Vga vgaA = new Vga("Vga : AMD");

        Processor processorA = new Processor("Merk Processor : Intel", "Tipe Processor : Core I5");
        Processor processorB = new Processor("Merk Processor  : Intel", "Tipe Processor : Core I7");
        Processor processorC = new Processor("Vga : AMD", " Tipe Processor : Ryzen");

        Laptop laptop1 = new Vivobook("ASUS", "Vivobook", vgaN, processorA);
       

        Laptop laptop2 = new IdeaPad("Lenovo", "IdeaPad", vgaA, processorB);
        

        Predator predator = new Predator("ACER", "Predator", vgaN, processorB);
        
        ACER acer = new Predator("ACER", "Predator", vgaA, processorB);






        //                                                           SOAL NOMOR 1
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();


        //                                                          SOAL NOMOR 2

         laptop1.Ngoding(); 

        //                                                          SOAL NOMOR 3
        Console.WriteLine("SPESFIKASI LAPTOP1"); 
        Console.WriteLine(laptop1.vga.merk);
        Console.WriteLine(laptop1.processor.merk);
        Console.WriteLine(laptop1.processor.tipe); 

        //                                                         SOAL NOMOR 4

        ((Predator)acer).BermainGame();

        //                                                          SOAL NOMOR 5
        ((Predator)acer).BermainGame();


    }


}
