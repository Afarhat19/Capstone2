using System;
using System.Collections.Generic;
using TenmoClient.Data;
using TenmoClient.Views;

namespace TenmoClient
{
    class Program
    {

        static void Main(string[] args)
        {
            string baseUrl = "https://localhost:44315/";
            AuthService authService = new AuthService();
            new LoginRegisterMenu(authService).Show();
            

            Console.WriteLine("\r\nThank you for using TEnmo!!!\r\n");
        }
    }
}
