using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy.EntityConfigurations
{
    public class GenreConfiguration : EntityTypeConfiguration<Genre>
    {
        //reformat code ; crtl + a, ctrl + k, ctrl + f
        public GenreConfiguration()
        {
            Property(g => g.Name)
            .IsRequired();
        }
    }
}
