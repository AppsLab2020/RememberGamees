using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RememberGamees.Model
{
    interface INoteRepository
    {
        Task Initialize();
        Task<List<Experiences>> GetExperiences();
    }
}
