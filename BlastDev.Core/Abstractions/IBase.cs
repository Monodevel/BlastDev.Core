namespace BlastDev.Core.Abstractions
{
    public interface IBase
    {
    }

    public interface IBase<TKey, TUserKey> : IBase
    {
        public TKey Id { get; set; }
        public bool State { get; set; }
        public TUserKey IdUserCreator { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
