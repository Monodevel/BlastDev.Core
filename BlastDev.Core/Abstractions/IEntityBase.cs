namespace BlastDev.Core.Abstractions
{
    public interface IEntityBase : IBase
    {
    }

    public interface IEntityBase<TKey, TUserKey> : IBase<TKey, TUserKey>, IEntityBase { }
}
