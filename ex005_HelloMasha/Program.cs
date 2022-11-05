// Программа 5. Приветствовать Машу и прочих юзеров 
Console.WriteLine("Введите имя пользователя:");//ввод любого имени, включая Маша
string username=Console.ReadLine(); 
if (username=="Маша")
    { 
        Console.WriteLine("Ура, это же Маша!");    
    }
        
else
    {
        Console.Write("Привет, ");
        Console.WriteLine(username);        
    }
        
    
