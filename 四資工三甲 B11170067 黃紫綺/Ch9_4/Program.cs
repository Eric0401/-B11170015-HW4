using System;
public class PhoneList
{
    public string HomePhone;
    public string BusinessPhone;
    public string CellPhone;

    public PhoneList(string homePhone, string businessPhone, string cellPhone)
    {
        HomePhone = homePhone;
        BusinessPhone = businessPhone;
        CellPhone = cellPhone;
    }
}
public class Cards
{
    private string Name;
    private string Occupation;
    private string Age;
    public PhoneList Phone;
    private string Email;

    public Cards(string name, string occupation, string age, string email, PhoneList phone)
    {
        Name = name;
        Occupation = occupation;
        Age = age;
        Email = email;
        Phone = phone;
    }
    
    public void GetCard()
    {
        Console.WriteLine("Name：" + Name);
        Console.WriteLine("Occupation：" + Occupation);
        Console.WriteLine("Age：" + Age);
        Console.WriteLine("Email：" + Email);
        Console.WriteLine("Phone：");
        Console.WriteLine("  Home：" + Phone.HomePhone);
        Console.WriteLine("  Business：" + Phone.BusinessPhone);
        Console.WriteLine("  Cell：" + Phone.CellPhone);
    }
    public static void Main(string[] args)
    {
        
        Console.Write("輸入住家電話：");
        string homePhone = (Console.ReadLine());
        Console.Write("輸入公司電話：");
        string businessPhone = (Console.ReadLine());
        Console.Write("輸入行動電話：");
        string cellPhone = (Console.ReadLine());
        PhoneList phone = new PhoneList(homePhone, businessPhone, cellPhone);

        Console.Write("輸入姓名：");
        string Name = Console.ReadLine();
        Console.Write("輸入職業：");
        string Occupation = Console.ReadLine();
        Console.Write("輸入年齡：");
        string Age = Console.ReadLine();
        Console.Write("輸入電子郵件：");
        string Email = Console.ReadLine();
        Console.WriteLine();
        Cards card = new Cards(Name,Occupation,Age,Email,phone);
        card.GetCard();
    }
}