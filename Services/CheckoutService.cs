using Microsoft.AspNetCore.Mvc;
using bookish;
using bookish.Models;

namespace bookish.Services;

public interface ICheckoutActions
{
    MyViewModel ViewCheckout();
    //void Checkout(Checkout check);
    void Checkout(int bookId, int memberId);
}

// Class - To implement the interfaces
public class CheckoutActions : ICheckoutActions
{
    public MyViewModel ViewCheckout()
    {
        using (var context = new BookishContext())
        {
            var booksName = context.Books.ToList();
            var membersName = context.Members.ToList();
            var listViewModel = new MyViewModel()
            {
                Books = booksName,
                Members = membersName,

            };
            return listViewModel;
        }
    }
    public void Checkout(int bookId, int memberId)
    {
        using (var context = new BookishContext())
        {
            var selectedBook = context.Books.FirstOrDefault(x => x.Id == bookId);
            if (selectedBook != null)
            {
                selectedBook!.TotalNoOfCopies -= 1;

            }
            var checkout = new Checkout()
            {
                //context.Books.Select(p=> p.Id).Where(p=> p.BookName = check.BookName);
                MemberId = memberId,// check.MemberId,
                BookId = bookId// check.BookId
            };
            context.Checkout.Add(checkout);
            // context.Update<Books>
            context.SaveChanges();
        }

    }

}