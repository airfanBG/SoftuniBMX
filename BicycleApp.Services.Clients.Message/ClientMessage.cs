namespace BicycleApp.Services.Clients.Message
{
    using BicycleApp.Data;
    using BicycleApp.Services.Clients.Message.Contracts;

    public class ClientMessage : IClientMessage
    {

        private readonly BicycleAppDbContext _db;

        public ClientMessage(BicycleAppDbContext db)
        {
            _db = db;
        }


    }
}
