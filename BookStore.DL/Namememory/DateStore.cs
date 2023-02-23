using BookStore.Models.Data;

namespace BookStore.DL.Namememory
{
    public static class DateStore
    {
        public static List<Author> Authors = new List<Author>()
        {
            new Author()
            {
                Id=1,
                Name = "Gosho",
                Bio= "Gosho bio"
            },
            new Author()
            {
                Id=2,
                Name= "Ginka",
                Bio= "Ginka bio"
            }

        };

    }
}
