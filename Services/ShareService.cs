using Shareasy.Models;
using Shareasy.Services.Interfaces;

namespace Shareasy.Services
{
    public class ShareService : IShareService
    {
        public ShareService() { 
            
        } 

        public Share CreateNewInstance()
        {
            Share share = new Share();
            share.CreatedAt = DateTime.Now;
            share.generateRandomToken();
            return share;
        }
    }
}
