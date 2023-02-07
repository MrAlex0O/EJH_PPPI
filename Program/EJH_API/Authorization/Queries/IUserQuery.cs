namespace API.Authorization.Queries
{
    public interface IUserQuery
    {
        public List<string> GetRolesByUser(Guid id);
    }
}
