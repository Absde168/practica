using practica.Models;

namespace practica.Data;
public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Brigade> GetServices(PractDbContext context) => context.brigades;

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Client> GetClients(PractDbContext context) => context.clients;
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Member> GetReceptionits(PractDbContext context) => context.members;
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Order> GetMasters(PractDbContext context) => context.orders;
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Work> GetEquipment(PractDbContext context) => context.works;
    }

internal class UseSortingAttribute : Attribute
{
}

internal class UseFilteringAttribute : Attribute
{
}

internal class UseProjectionAttribute : Attribute
{
}