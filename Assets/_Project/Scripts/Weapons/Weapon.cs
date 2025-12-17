// STEP 1: Creating Weapon Base

//Specifications of Weapon: Assumptions about the attributes of a shooter weapon: (Ammo, magazine size, fire rate).
// Abstraction: Hiding Complexity + Shared Base + Implementation

// Creating Weapon Base For:
// 1) Rifle, Shotgun, Sniper can behave differently
// 2) Player code will not change 

public abstract class Weapon
{
	public int currentAmmo;
	public int magazineSize;
	public float fireRate;

	protected WeaponState currentState = WeaponState.Idle;

	public abstract void Fire();
	public abstract void Reload();
}
