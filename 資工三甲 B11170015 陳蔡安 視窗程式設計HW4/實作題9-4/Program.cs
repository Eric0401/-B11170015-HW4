public class PhoneList
{
    public string HomePhone;
    public string BusinessPhone;
    public string CellPhone;
    public PhoneList(string home, string business, string cell)
    {
        HomePhone = home;
        BusinessPhone = business;
        CellPhone = cell;
    }
}
public class Cards
{
    public string Name = " ";
    public string Occupation = " ";
    public int Age;
    public PhoneList phone = new PhoneList(" ", " ", " ");
    public string Email = " ";

    public void GetCard()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Occupation: " + Occupation);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Home Phone: " + phone.HomePhone);
        Console.WriteLine("Business Phone: " + phone.BusinessPhone);
        Console.WriteLine("Cell Phone: " + phone.CellPhone);
        Console.WriteLine("Email: " + Email);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        PhoneList phone = new PhoneList("123-456-7890", "098-765-4321", "555-555-5555");
        Cards card = new Cards();

        card.Name = "John";
        card.Occupation = "Engineer";
        card.Age = 22;
        card.phone = phone;
        card.Email = "abc@gmail.com";

        card.GetCard();
    }
}
