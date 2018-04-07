using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    interface IO
    {
        void save(string fileName, Student[] students);

        Student[] load(string fileName);
    }
}
