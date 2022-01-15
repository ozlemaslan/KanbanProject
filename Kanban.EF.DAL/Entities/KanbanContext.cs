using Kanban.EF.DAL.Entities.Mapping;
using KanbanModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.EF.DAL.Entities
{
    class KanbanContext:DbContext
    {
        public KanbanContext():base("name=KanbanBoard")
        {

        }
        public DbSet<Board> Tahtalar { get; set; }
        public DbSet<Gorev> Gorevler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new BoardMapping());
            modelBuilder.Configurations.Add(new GorevMapping());
        }
    }
}
