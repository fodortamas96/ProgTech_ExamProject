﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Interfaces
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}
