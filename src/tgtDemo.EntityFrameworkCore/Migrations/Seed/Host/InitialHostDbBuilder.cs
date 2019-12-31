using tgtDemo.EntityFrameworkCore;

namespace tgtDemo.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly tgtDemoDbContext _context;

        public InitialHostDbBuilder(tgtDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
