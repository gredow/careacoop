
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace CareaBio.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<CareaBio.Models.BioDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    } 
}