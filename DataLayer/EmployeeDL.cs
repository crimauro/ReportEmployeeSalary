using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;

namespace DataLayer
{
    public class EmployeeDL
    {
        /// <summary>
        /// Return all employees of web service
        /// </summary>
        /// <returns></returns>
        public List<EmployeeData> GetEmployees()
        {
            List<EmployeeData> employees = new List<EmployeeData>();
            string json = "";

            try
            {
                json = new WebClient().DownloadString(ConfigurationManager.AppSettings["Url"].ToString());
                employees = JsonConvert.DeserializeObject<List<EmployeeData>>(json);
            }
            catch (Exception)
            {
                //return of list empty
            }

            return employees;
        }


    }
}
