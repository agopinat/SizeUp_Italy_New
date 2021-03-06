﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.DataLayer
{
    public class IndustryAttribute
    {
        public static string TotalRevenue { get { return "TotalRevenue"; } }
        public static string AverageRevenue { get { return "AverageRevenue"; } }
        public static string RevenuePerCapita { get { return "RevenuePerCapita"; } }
        public static string TotalEmployees { get { return "TotalEmployees"; } }
        public static string AverageEmployees { get { return "AverageEmployees"; } }
        public static string EmployeesPerCapita { get { return "EmployeesPerCapita"; } }
        public static string AverageAnnualSalary { get { return "AverageAnnualSalary"; } }
        public static string CostEffectiveness { get { return "CostEffectiveness"; } }
    }
}