namespace BlastDev.Core.Abstractions
{
    public interface IDtoBase : IBase
    {
    }

    public interface IDtoBase<Tkey, TUserKey> : IBase<Tkey, TUserKey>, IDtoBase
    { }
}
