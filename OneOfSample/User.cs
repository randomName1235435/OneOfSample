namespace OneOfSample
{
    public class User
    {
        public int Id { get; set; }
        public int Name { get; set; }

        public override int GetHashCode() => Id;
    }
}
