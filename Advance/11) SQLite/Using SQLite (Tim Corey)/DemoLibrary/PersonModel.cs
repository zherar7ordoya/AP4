﻿namespace DemoLibrary
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return $"{ FirstName } { LastName }"; }
        }
    }
}
