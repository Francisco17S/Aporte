public class Celular:Dispositivos, Dispositivo
{
            public Celular(string funci1,string funci2,string funci3):base(funci1,funci2,funci3)
            {
            }

                public string Reparar()
                {
                    return "CELULAR";
                }

                    public string Hardware()
                    {
                        Console.WriteLine();
                        return "";
                    } 

}