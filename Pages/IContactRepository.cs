namespace ContactManagementApp.Repositories
{
    public interface IContactRepository
    {
        Contact GetContactById(int id);
        void UpdateContact(Contact contact);
        void DeleteContact(int id); // Método para excluir um contato
        // Outros métodos da interface, se houver
    }
}
