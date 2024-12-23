namespace practica.Data
{
    public class MyDbContext
    {
        public object Clients { get; internal set; }
        public object Works { get; internal set; }
        public object Orders { get; internal set; }
        public object Members { get; internal set; }
        public object Brigade { get; internal set; }
    }
}