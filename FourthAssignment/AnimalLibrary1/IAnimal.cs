﻿//Programming using .NET advanced course
//Code Example : Animal Motel
//Haris Kljajic June 2012
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalMotel
{
    /// <summary
    ///     This is the interface, it holds the most common properties and methods, decleared without a body
    /// </summary>
    public interface IAnimal
    {
        //Interface för Animal
        int Age { get; set; }

        CategoryType Category { get; set; }

        GenderType Gender { get; set; }

        int ID { get; set; }

        string GetAnimalSpecificData();
    }
}
