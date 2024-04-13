using Microsoft.EntityFrameworkCore;

namespace lab_4_5.Models
{
    public class ClientFileManagerVm //1. Class implementation
    {
        public ClientManagerVm ClientManager { get; set; }
        public ClientFileManagerVm(ref ClientManagerVm clientManager) //4. Constructor with parameters
        {
            ClientManager = clientManager;
        }

        public bool IsAllClientAuthorizationDataCorrect()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                List<ClientVm> clients = db.Clients.ToList();

                bool thisClientExist = false;

                for (int i = 0; i < clients.Count; i++)
                {
                    if (clients[i].Name == ClientManager.Client.Name && clients[i].Surname == ClientManager.Client.Surname && clients[i].Patronymic == ClientManager.Client.Patronymic && clients[i].Password == ClientManager.Client.Password)
                    {
                        thisClientExist = true;
                    }
                }

                if (thisClientExist == false)
                {
                    return false;
                }

                return true;
            }
        }

        public ClientVm LoadClient() //11. Method that reads from a class object's data field file (the entire object)
        {
            ClientVm ? client = new ClientVm();
            int clientId;
            using (ApplicationContext db = new ApplicationContext())
            {
                List<ClientVm> clients = db.Clients.ToList();

                for (int i = 0; i < clients.Count; i++)
                {
                    if (clients[i].Name == ClientManager.Client.Name && clients[i].Surname == ClientManager.Client.Surname && clients[i].Patronymic == ClientManager.Client.Patronymic && clients[i].Password == ClientManager.Client.Password)
                    {
                        clientId = clients[i].Id;
                        clients = db.Clients.Include(x => x.Request).Include(y => y.Request.Apartment).ToList();
                        client = clients.Find(x => x.Id == clientId);
                    }
                }
            }
            return client;
        }

        public void SaveClient() //11. Method that writes to the file the data fields of the class object (the entire object)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Update(ClientManager.Client);
                db.SaveChanges();
            }
        }

        public bool CreateProfile() //11. Method that writes to the file the data fields of the class object (the entire object)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                List<ClientVm> clients = db.Clients.ToList();
               
                for (int i = 0; i < clients.Count; i++) 
                {
                    if (clients[i].Name == ClientManager.Client.Name && clients[i].Surname == ClientManager.Client.Surname && clients[i].Patronymic == ClientManager.Client.Patronymic) 
                    {
                        return false;
                    }
                }
                db.Add(ClientManager.Client);
                db.SaveChanges();
            }
            return true;
        }
    }
}

