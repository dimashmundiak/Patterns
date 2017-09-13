using System.Collections.Generic;
using System.Linq;

namespace Proxy
{
    public class BookStoreProxy : IBook
    {
        private readonly List<Page> _pages;
        private BookStore _bookStore;

        public BookStoreProxy()
        {
            _pages = new List<Page>();
        }

        public void Dispose()
        {
            _bookStore?.Dispose();
        }

        public Page GetPage(int number)
        {
            Page page = _pages.FirstOrDefault(p => p.Number == number);
            if (page == null)
            {
                if (_bookStore == null)
                    _bookStore = new BookStore();
                page = _bookStore.GetPage(number);
                _pages.Add(page);
            }
            return page;
        }
    }
}
