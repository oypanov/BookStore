using Acme.BookStore.Authors;
using Acme.BookStore.Books;
using MongoDB.Driver;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Acme.BookStore.MongoDB;

[ConnectionStringName("Default")]
public class BookStoreMongoDbContext : AbpMongoDbContext
{


    public IMongoCollection<Author> Authors => Collection<Author>();
    public IMongoCollection<Book> Books => Collection<Book>();
   


}
