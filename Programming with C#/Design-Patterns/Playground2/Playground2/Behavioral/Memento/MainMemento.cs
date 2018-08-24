﻿using System;

namespace Playground2.Behavioral.Memento
{
    public static class MainMemento
    {
        public static void Run()
        {
            var sale = new SalesProspect { Name = "Noel van Halen", Phone = "(412) 256-0990", Budget = 25000.0 };

            // Store internal state
            var memory = new ProspectMemory();
            Console.WriteLine("\nSaving state --\n");
            memory.Memento = sale.SaveMemento();

            // Continue changing originator
            sale.Name = "Leo Welch";
            sale.Phone = "(310) 209-7111";
            sale.Budget = 1000000.0;

            // Restore saved state
            Console.WriteLine("\nRestoring state --\n");
            sale.RestoreMemento(memory.Memento);
        }
    }
}
