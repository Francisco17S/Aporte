public class Tablet:dispositivos, Idispositivo
{
                public Tablet(string funci1,string funci2,string funci3):base(funci1,funci2,funci3)
                {
                }

                        public string Reparar()
                            {
                                return "TABLET";
                            }

                                    public string Hardware()
                                    {
                                        Console.WriteLine();
                                        return "";
                                    } 
                                }