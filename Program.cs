using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using LinqBasic.Abstract;
using Microsoft.VisualBasic.FileIO;

namespace LinqBasic
{
    class Program
    {
            static void Main(string[] args)
            {
            IEnumerable<Person> persons = new List<Person>()
                {
                    new Person()
                    {
                        Id = 1,
                        Name = "Tomer",
                        PersonGender = Gender.Male
                    },

                    new Person()
                    {
                        Id = 2,
                        Name = "Tami",
                        PersonGender = Gender.Female
                    },
                    new Person()
                    {
                        Id = 3,
                        Name = "Nadav",
                        PersonGender = Gender.Male
                    }
                };

            }

    public class PersonFunc : IPersonRetriver
        {
            public IEnumerable<int> GetMalesId(IEnumerable<Person> persons)
            {
                var malePerson = persons.Where(person => person.PersonGender == Gender.Male)
                   .Select(person => person.Id);
                return (IEnumerable<int>)malePerson;
            }

            public IEnumerable<Person> OrderById(IEnumerable<Person> persons)
            {
                var orderPerson = persons.OrderByDescending(person => person.Id);
                return orderPerson;
            }


            public IEnumerable<Person> GetOddIds(IEnumerable<Person> persons)
            {
                var dividedPerson = persons.Where(person => person.Id % 2 != 0);
                return dividedPerson;
            }
           
        }
    }
}
