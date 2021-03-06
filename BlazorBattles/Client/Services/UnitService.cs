using BlazorBattles.Shared;
using Blazored.Toast.Services;

namespace BlazorBattles.Client.Services
{
    public class UnitService : IUnitService
    {
        private readonly IToastService toastService;

        public UnitService(IToastService toastService)
        {
            this.toastService = toastService;
        }

        public IList<Unit> Units { get; set; } = new List<Unit>()
        {
            new Unit { Id = 1, Title = "Knight", Attack = 10, Defense = 10, BananaCosts = 100 },
            new Unit { Id = 2, Title = "Archer", Attack = 15, Defense = 5, BananaCosts = 150 },
            new Unit { Id = 3, Title = "Mage", Attack = 20, Defense = 1, BananaCosts = 200 },
        };

        public IList<UserUnit> MyUnits { get; set; } = new List<UserUnit>();

        public void AddUnit(int unitId)
        {
            var unit = Units.First(u => u.Id == unitId);
            var userUnit = new UserUnit { UnitId = unit.Id, HitPoints = unit.HitPoints };
            this.MyUnits.Add(userUnit);

            this.toastService.ShowSuccess($"{unit.Title} has been build", "Unit built!");
        }
    }
}