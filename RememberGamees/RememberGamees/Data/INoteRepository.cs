using System.Collections.Generic;
using System.Threading.Tasks;

namespace RememberGamees.Model
{
    public interface INoteRepository
    {
        Task AddExperience(Experiences experiences);
        Task<List<Experiences>> GetExperience();
        Task Initialize();
    }
}
