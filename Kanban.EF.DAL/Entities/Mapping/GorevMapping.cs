using KanbanModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.EF.DAL.Entities.Mapping
{
    class GorevMapping:EntityTypeConfiguration<Gorev>
    {
        public GorevMapping()
        {
            HasKey(a => a.GorevID);

            Property(a => a.Aciklama)
                .HasMaxLength(30)
                .IsRequired();

            HasRequired(a => a.Tahta)
                .WithMany(a => a.Gorevler)
                .HasForeignKey(a => a.BoardID);

        }
    }
}
