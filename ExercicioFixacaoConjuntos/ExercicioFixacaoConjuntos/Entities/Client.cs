namespace Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Client(string name, string email)
        {
            Name = name;
            Email = email;
        }

        //Aqui eu defino o criterio para entender se meu objeto eh ou nao igual a outr, no caso
        //o parametro escolhido foi o "email"
        public override bool Equals(object? obj)
        {
            if(!(obj is Client))
            {
                return false;
            }

            Client other = (Client)obj;    
            
            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {           
            return Email.GetHashCode();
        }
    }
}
