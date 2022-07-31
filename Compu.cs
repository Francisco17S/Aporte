public class Compu:dispositivos, Idispositivo
{
            public Compu(string funci1,string funci2,string funci3):base(funci1,funci2,funci3)
            {
            }

                public string Reparar()
                {
                    return "COMPUTADORA";
                }

                    public string Hardware()
                    {
                        Console.WriteLine();
                        return "";
                    } 
}