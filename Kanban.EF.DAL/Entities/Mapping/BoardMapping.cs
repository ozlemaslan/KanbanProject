using KanbanModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.EF.DAL.Entities.Mapping
{
    class BoardMapping:EntityTypeConfiguration<Board>
    {
        public BoardMapping()
        {
            HasKey(a => a.BoardID);

            Property(a => a.BoardName)
                .HasMaxLength(25)
                .IsRequired();

            
        }
    }
}
