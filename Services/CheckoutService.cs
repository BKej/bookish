using Microsoft.AspNetCore.Mvc;
using bookish;
using bookish.Models;

namespace bookish.Services;

public interface ICheckoutActions
{
    MyViewModel ViewCheckout();
    void Checkout(Checkout check);
}

// Class - To implement the interfaces
public class CheckoutActions : ICheckoutActions
{
    public MyViewModel ViewCheckout()
    {
        using (var context = new BookishContext())
        {
            var booksName = context.Books.Select(p => p.BookName).ToList();
            var membersName = context.Members.Select(p => p.FirstName).ToList();
            var listViewModel = new MyViewModel()
            {
                BookName = booksName,
                MemberName = membersName,

            };
            return listViewModel;
        }
    }
    public void Checkout(Checkout check)
    {
        using (var context = new BookishContext())
        {
            var checkout = new Checkout()
            {
                //context.Books.Select(p=> p.Id).Where(p=> p.BookName = check.BookName);
                MemberId = check.MemberId,
                BookId = check.BookId
            };
            context.Checkout.Add(checkout);
            // context.Update<Books>
            context.SaveChanges();
        }

    }

}