using Data.Models;

namespace Data.Repository
{
    public interface IMerchantRepository
    {
        Merchant GetById(long id);

        //Merchant create(Merchant item);
    }
}