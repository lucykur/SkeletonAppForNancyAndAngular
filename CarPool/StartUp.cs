﻿using System;
using Nancy.Hosting.Self;

namespace CarPool
{
    class StartUp
    {
        static void Main(string[] args)
        {
            using (var host = new NancyHost(new Uri("http://localhost:9000")))
            {
                host.Start();
                Console.WriteLine("Starting car pool application on port 9000");
                Console.ReadLine();
            }
        }
    }
}