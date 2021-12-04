using BlazorBattles.Shared;

namespace BlazorBattles.Client.Services
{
    public interface IUnitService
    {
        IList<Unit> Units { get;}

        IList<UserUnit> MyUnits { get; }

        void AddUnit(int unitId);
    }
}