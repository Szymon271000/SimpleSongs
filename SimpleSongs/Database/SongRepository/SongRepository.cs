using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.SongRepository
{
    public class SongRepository: GenericRepository<Song>, IGenericRepository<Song>
    {

    }
}
