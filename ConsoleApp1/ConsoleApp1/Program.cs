namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var balance = 1000;
            var op = 0;
            Console.WriteLine("Menu : \n\n" +"1-pul cix\n"+
                "2-pul yatir\n" +
                "3-budce sorgulma\n" + "4-cix\n");
        x:
            var contrl = true;
            do
            {
                try
                {
                    op = Convert.ToInt32(Console.ReadLine());
              
                    switch (op)
                    {
                        case 1:
                            Console.WriteLine("CIXARMAQ ISTEDIYINIZ PULUN MIQDARUI : ");
                            var minuse = Convert.ToInt32(Console.ReadLine());
                            if (balance - minuse >= 0)
                            {
                                balance = balance - minuse;
                            }
                            else
                            {
                                throw new Exception("please enter valid value");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Elave etmek ISTEDIYINIZ PULUN MIQDARUI : ");
                            var pluse = Convert.ToInt32(Console.ReadLine());
                            if (pluse > 0)
                            {
                                balance = balance + pluse;
                            }
                            else
                            {
                                throw new Exception("xais edirik musbet eded girin");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Budce : " + balance.ToString());
                            break;
                        case 4:
                            contrl = false;
                            break;
                        default:
                            goto x;
                    }
                }
                catch (Exception ex)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                    goto x;
                }
            }
            while (contrl);
          

        }
    }
}