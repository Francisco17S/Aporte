class Cargador : Decorador
{
        public Cargador(decorador orden): base(orden)
        {
        }

            public override string Hardware()
            {
                Console.WriteLine("hardware: "+orden);
                return base.hardware();
            }

    
}