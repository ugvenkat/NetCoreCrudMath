﻿using System.Collections.Generic;

namespace FirstApp.Models
{
    public static class Repository
    {
        private static List<Employee> allEmpoyees = new List<Employee>();
        public static IEnumerable<Employee> AllEmpoyees
        {
            get { return allEmpoyees; }
        }
        public static void Create(Employee employee)
        {
            allEmpoyees.Add(employee);
        }

        public static void Delete(Employee employee)
        {
            allEmpoyees.Remove(employee);
        }
    }


    public class MathCalculator
    {
        public int AddValues(int valueA, int valueB)
        {
            return valueA + valueB;
        }
        public int SubtractValues(int valueA, int valueB)
        {
            return valueA - valueB;
        }
        public int MultiplyValues(int valueA, int valueB)
        {
            return valueA * valueB;
        }
    }


}