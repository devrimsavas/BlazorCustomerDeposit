namespace BlazorTiles1.Models
{
    public class Customers 
    {
        public static Random random=new Random();
        public List<Person> People {get;set;}=new List<Person>();
        
        public void AddPerson(NewPersonInput newPersonInput) 
        {
            int id=People.Count+1;
            int accountNo=random.Next(0,99999);
            if (newPersonInput.Name.Length<5)
            {
                throw new Exception("Not valid UserName ");
            }
            if (newPersonInput.Deposit<0)
            {
                throw new Exception("Deposit cannot be below Zero");
            }
            string name=newPersonInput.Name;
            decimal deposit=newPersonInput.Deposit;
           
            People.Add(new Person(id,accountNo,name,deposit));
        }
        public void UpdatePerson(int id,PersonUpdateInput personUpdateInput)
        {
            var existedPerson= People.FirstOrDefault(p=>p.Id==id) ?? throw new Exception("Person does not exist");
            existedPerson.Name=personUpdateInput.Name;
            
        }
    }

     public record NewPersonInput (string Name,decimal Deposit);
     public record PersonUpdateInput (string Name);
    
}