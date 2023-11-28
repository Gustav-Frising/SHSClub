using SHSClub.Models;

namespace SHSClub.Database
{

    internal class SuperheroRepository
    {
        private readonly SHSClubDbContext _context;
        public SuperheroRepository(SHSClubDbContext context)
        {
            _context = context;
        }
        public List<SuperheroModel> GetAll()
        {
            return _context.Superheroes.ToList();

        }

        public SuperheroModel? GetById(int id)
        {
            return _context.Superheroes.FirstOrDefault(p => p.SuperheroId == id);
        }

        public void Add(SuperheroModel superheromodel)
        {
            _context.Superheroes.Add(superheromodel);
        }
        public void Update(int id, SuperheroModel superheromodel)
        {
            SuperheroModel? superheroToUpdate = GetById(id);

            if (superheroToUpdate != null)
            {
                superheroToUpdate.Name = superheromodel.Name;
                superheroToUpdate.SecretIdentity = superheromodel.SecretIdentity;
                superheroToUpdate.ImageUrl = superheromodel.ImageUrl;
                superheroToUpdate.SuperpowerId = superheromodel.SuperpowerId;
            }
        }
        public void Delete(int id)
        {
            SuperheroModel? superheroToDelete = GetById(id);

            if (superheroToDelete != null)
            {
                _context.Superheroes.Remove(superheroToDelete);
            }
        }
        public void Complete()
        {
            _context.SaveChanges();
            //_context.Dispose();
        }
    }
}
