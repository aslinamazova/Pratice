using System.ComponentModel.DataAnnotations;

namespace Pratice_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userPhones = new int[0];
            string[] userEmails = new string[0];
            Console.WriteLine("Would you like to register 1.Phone Number or 2.Email ?");
            string answer = Console.ReadLine();
   
            if (answer == "1")
            {
                Console.WriteLine("Enter phone number");
                int userPhone =Convert.ToInt32(Console.ReadLine());
                if (userPhones.Contains(userPhone))
                {
                    Console.WriteLine("user with this phone number already exists! Enter new Phone" );
                }
                else
                {
                    Array.Resize(ref userPhones, userPhones.Length +1);
                    
                }
              
            }

            else if(answer == "2")
            {
                Console.WriteLine("Enter email");
                string userEmail=Console.ReadLine();
                Array.Resize(ref userEmails, userEmails.Length +1);
                for (int i = 0; i < userEmails.Length; i++)
                {
                    if (userEmails[i]== userEmail)
                    {
                        Console.WriteLine("user email exists!");
                    }
                    else
                    {
                        userEmails[i] = userEmail;

                    }
                }




                //if (useremails.contains(useremail))
                //{
                //    console.writeline("user with this user email already exists! ");
                //}
                //else {
                //    array.resize(ref useremails, useremails.length + 1);
                //    useremails[0] = useremail;
                  
                //}

            }
            //else
            //{
            //    Console.WriteLine("Choose properly!");
            //}
            for (int i = 0;i<userEmails.Length;i++)
            {
                Console.WriteLine(userEmails[i]);
            }

        }


        //static string Register(string username,string email, string password)
        //{
        //    return username+email+password; 
        //}
        //static string Register(int phoneNumber,string username,string password)
        //{
        //    return phoneNumber+ username+ password; 
        //}

    }
}