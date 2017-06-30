﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Vino.Core.TimedTask.Attribute;

namespace Test
{
    [VinoTimedTask]
    public class TestTask
    {
        [Invoke(Interval = 5000)]
        [SingleTask]
        public void Run()
        {
            Debug.WriteLine(DateTime.Now + " TestTask Run invoke...");
        }

        [SingleTask]
        public void RunForDb()
        {
            Debug.WriteLine(DateTime.Now + " TestTask RunForDb invoke...");
        }
    }
}
