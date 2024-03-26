namespace ContactManagementApp.Repositories
{
    public interface IContactRepository
    {
        Contact GetContactById(int id);
        void UpdateContact(Contact contact);
        // Outros métodos da interface, se houver
    }
}
