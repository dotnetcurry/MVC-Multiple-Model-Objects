namespace Multi_model_action.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ApplicationEntities : DbContext
    {
        public ApplicationEntities()
            : base("name=ApplicationEntities")
        {
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItemDetails> OrderItemDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
