using SHSClub.Models;

namespace SHSClub.Database
{
    internal class SuperpowerRepository
    {
        private readonly SHSClubDbContext _context;
        public SuperpowerRepository(SHSClubDbContext context)
        {
            _context = context;
        }
        public List<SuperpowerModel> GetAll()
        {
            return _context.Superpowers.ToList();

        }

        public SuperpowerModel? GetById(int id)
        {
            return _context.Superpowers.FirstOrDefault(p => p.SuperpowerId == id);
        }

        public void Add(SuperpowerModel superpowermodel)
        {
            _context.Superpowers.Add(superpowermodel);
        }
        public void Update(int id, SuperpowerModel superpowermodel)
        {
            SuperpowerModel? superpowerToUpdate = GetById(id);

            if (superpowerToUpdate != null)
            {
                superpowerToUpdate.SuperpowerId = superpowermodel.SuperpowerId;
                superpowerToUpdate.Name = superpowermodel.Name;
                superpowerToUpdate.Description = superpowermodel.Description;

            }
        }
        public void Delete(int id)
        {
            SuperpowerModel? superpowerToDelete = GetById(id);

            if (superpowerToDelete != null)
            {
                _context.Superpowers.Remove(superpowerToDelete);
            }
        }
    }
}
