﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSongsView.Interfaces
{
    public interface IMenuDisplay
    {
        void ClearScreen();
        void PrintMany<T>(List<T> entities);
        void PrintMessage(string content);
        void PrintOptions(List<string> options);
        void PrintAndWaitForKey(string content);
    }
}
