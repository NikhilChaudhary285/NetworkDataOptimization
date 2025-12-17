// Step 6: Creating Weapon state management

// Specifications or Use Case of WeaponState:
// WeaponState ensures valid behavior transitions (e.g. cannot fire while reloading)

public enum WeaponState
{
	Idle,
	Firing,
	Reloading,
	Empty
}