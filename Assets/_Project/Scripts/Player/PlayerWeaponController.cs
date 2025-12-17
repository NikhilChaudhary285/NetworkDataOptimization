// STEP 4: Creating PlayerWeaponController

// Specifications or Use Case of PlayerWeaponController:
// 1) Can equip two primary guns and one secondary gun
// 2) Can fire the weapon

// PlayerWeaponController For Player To:
// 1) Manage weapons
// 2) NOT implement firing logic 

public class PlayerWeaponController
{
	// Two primary guns:
	Weapon primary1;
	Weapon primary2;
	// One secondary gun:
	Weapon secondary;
	// CurrentWeapon
	Weapon currentWeapon;

	public void EquipWeapon(Weapon weapon)
	{
		currentWeapon = weapon;
	}

	public void FireCurrent()
	{
		currentWeapon?.Fire();
	}

	public void ReloadCurrent()
	{
		currentWeapon?.Reload();
	}
}