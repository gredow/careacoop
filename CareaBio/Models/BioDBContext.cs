using System.Data.Entity;

namespace CareaBio.Models
{
    public class BioDBContext : DbContext
    {
        public BioDBContext() : base("BioDB")
        {
            
        }
        
    }
}