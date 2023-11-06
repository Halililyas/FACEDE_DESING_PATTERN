using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facede_Desing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Save();
            Console.ReadLine();
        }
    interface  ILogging
        {
            void Log();
        }
        interface ICaching
        {
            void Caching();
        }
        interface IAuthorize
        {
            void UserCheck();
        }

        class Logging : ILogging
        {
            public void Log()
            {
                Console.WriteLine("Logged");
            }
        }
        class Caching : ICaching
        {
            void ICaching.Caching()
            {
                Console.WriteLine("Caching");
            }
        }
        class Authirize : IAuthorize
        {
            public void UserCheck()
            {
                Console.WriteLine("User Check");
            }
        }

        class Customer
        {
            private CrossCuttongConcreadFacade _concreadFacade;
            public Customer()
            {
                _concreadFacade = new CrossCuttongConcreadFacade();
            }
            public void Save()
            {
                _concreadFacade.Caching.Caching();
                _concreadFacade.Logging.Log();
                _concreadFacade.authorize.UserCheck();
                Console.WriteLine("Save");
            }

        }
        class CrossCuttongConcreadFacade
        {
            public ILogging Logging;
            public ICaching Caching;
            public IAuthorize authorize;

            public CrossCuttongConcreadFacade()
            {
                Logging = new Logging();
                Caching = new Caching();
                authorize = new Authirize();
            }
        }
    }
}
