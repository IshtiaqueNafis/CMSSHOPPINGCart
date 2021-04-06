using Microsoft.EntityFrameworkCore;

namespace CMSSHOPPINGCart.Models.Data
{
    public class CmShoppingCartContext:DbContext
    {
        public CmShoppingCartContext(DbContextOptions<CmShoppingCartContext> options) : base(options)
        {
        }
    }
}