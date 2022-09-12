namespace Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public DateTime Log { get; set; }

        public Client(string name, DateTime log)
        {
            Name = name;
            Log = log;
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is Client))
            {
                throw new ArgumentException("Invalid type");
            }
            
            Client other = obj as Client;
            if(Name.Equals(other.Name))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override string ToString()
        {
            return Name + ", " + Log.
                ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
