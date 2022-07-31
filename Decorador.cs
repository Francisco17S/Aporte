class Decorador:Idispositivo
{
    protected  Idispositivo orden;

            public Decorador(Idispositivo orden)
            {
                this.orden = orden;
            }
                public virtual string Hardware()
                {
                    Console.WriteLine("decorador");
                    return orden.hardware();
                }
                    public virtual string Reparar()
                    {
                        return "";
                    }

    
    
}
