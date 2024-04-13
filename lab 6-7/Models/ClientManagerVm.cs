namespace lab_4_5.Models
{
    public class ClientManagerVm //1. Class implementation
    {
        public ClientVm ? Client {  get; set; } //3. Implementing a data field using properties { get; set; }
        public ClientManagerVm() //4. Constructor without parameters
        {
            Client = null;
        }
        public ClientManagerVm(ClientVm client) //4. Constructor with parameters
        {
            Client = client;
        }
        public ClientManagerVm(ref ClientVm client) //4. Constructor with parameters
        {
            Client = client;
        }
        public ClientManagerVm(string clinetName, string clientSurname, string clientPatronymic, string clientPassword) //4. Constructor with parameters
        {
            Client = new ClientVm(clinetName, clientSurname, clientPatronymic, clientPassword);
        }
    }
}
