﻿namespace GoldJewelry.IO
{
    using System;

    using Contracts;

    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string value)
        {
            Console.Write(value);
        }

        public void Clear()
        {
            Console.Clear();
        }
    }
}