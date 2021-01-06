using System.Collections.Generic;

namespace Loader.Data
{
	public class StandardisedWeapon
	{
		public StandardisedAmmunition Ammunition { get; set; }
		public List<StandardisedWeaponMode> Modes { get; set; }
	}
}
