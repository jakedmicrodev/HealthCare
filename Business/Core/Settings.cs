using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Business.Core
{
    public static class Settings
    {
        private static string medicalConnectionString = string.Empty;

        public static string MedicalConnectionString
        {
            get
            {
                if (String.IsNullOrWhiteSpace(medicalConnectionString))
                {
                    medicalConnectionString = ConfigurationManager.ConnectionStrings["MEDICAL"].ToString();
                }
                return medicalConnectionString;
            }
        }
    }
}