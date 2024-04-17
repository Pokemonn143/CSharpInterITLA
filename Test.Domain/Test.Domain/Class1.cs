namespace Test.Domain
{
    public abstract class Person
    {

        public string? name { get; set; }
        public string? Lastname { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public virtual void Load()

        {
            Console.WriteLine("Cargando datos...");
        }

    }

    
}

public abstract class employee