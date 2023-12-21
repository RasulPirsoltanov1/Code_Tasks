
namespace RabbitMq;

internal class Program
{
    static void Main(string[] args)
    {
        List<string> animals = new List<string>();
    
        bool chck = true;
        do
        {
            Console.WriteLine(@$"



ender the process num : 
1-get animals
2-find animal
3-add animal
4-delete animal
5-uopdate animal 
6-press any key for exit 


");
            try
            {
                int procces = Convert.ToInt32(Console.ReadLine());
                switch (procces)
                {
                    case 1:
                        GetAnimals();
                        break;
                    case 2:
                        Console.WriteLine("animal name : ");
                        GetAnimal(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("animal name : ");
                        CreateAnimal(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("animal name : ");
                        DeleteAnimal(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("animal oldanem name : ");
                        string oldName = Console.ReadLine();
                        Console.WriteLine("animal new  name : ");
                        string newName = Console.ReadLine();
                        UpdateAnimal(oldName, newName);
                        break;
                    default:
                        chck = false;
                        break;
                }
                Console.Clear();
            }
            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
        }
        while (chck);



        void CreateAnimal(string name)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(name))
                {
                    animals.Add(name);
                }
                else
                {
                    throw new Exception("name field is required.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        void GetAnimals()
        {
            Console.WriteLine("\n");
            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }
        }
        void GetAnimal(string name)
        {
            try
            {
                if (animals.Contains(name))
                {
                    Console.WriteLine(name);
                }
                else
                {
                    throw new Exception("data not found");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        void UpdateAnimal(string name, string newName)
        {
            try
            {
                var animal = animals.FirstOrDefault(name => name.Equals(name));

                if (animal != null)
                {
                    animal = newName;
                }
                else
                {
                    throw new Exception("data not found");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        void DeleteAnimal(string name)
        {
            try
            {
                var animal = animals.FirstOrDefault(name => name.Equals(name));

                if (animal != null)
                {
                    animals.Remove(animal);
                }
                else
                {
                    throw new Exception("data not found");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}