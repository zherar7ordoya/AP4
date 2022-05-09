﻿using System.Configuration;

namespace BLLInsumosOficina
{
    public static class DALConector
    {
        public static string GetSQLConnection(string name)
        {
            // Assume failure.
            string returnValue = null;

            // Look for the name in the connectionStrings section.
            ConnectionStringSettings settings
                = ConfigurationManager.ConnectionStrings[name];

            // If found, return the connection string.
            if (settings != null)
            {
                returnValue = settings.ConnectionString;
            }
            return returnValue;
        }
    }
}