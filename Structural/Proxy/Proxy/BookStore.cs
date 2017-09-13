using System.Linq;

namespace Proxy
{
    public class BookStore : IBook
    {
        private readonly PageContext _context;

        public BookStore()
        {
            _context = new PageContext();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public Page GetPage(int number)
        {
            return _context.Pages.FirstOrDefault(p => p.Number == number);
        }
    }
}
