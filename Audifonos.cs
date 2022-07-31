class Audifonos : Decorador
{
            public Audifonos(Idispositivo orden) : base(orden)
            {
            }
    
                public override string Hardware()
                {
                    Console.WriteLine("hardware: "+orden);
                    return base.hardware();
                }
}