namespace BlazorTiles1.Models
{
    public class Person
    {
        public int Id {get;set;}
        public int AccountNo {get;set;}
        public string Name {get;set;}=string.Empty;
        public decimal Deposit {get;set;}
        public Person(int id,int accountNo,string name,decimal deposit=0)
        {   
            Id=id;
            AccountNo=accountNo;         
            Name=name;
            Deposit=deposit;            
        }
    }
}