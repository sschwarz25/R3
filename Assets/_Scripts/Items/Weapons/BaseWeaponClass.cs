using UnityEngine;
using System.Collections;

public class BaseWeaponClass : BaseStatItem{	//BaseWeaponClass <-- BaseStatItem <-- BaseItem

	public enum WeaponTypes{
		SWORD_AND_KITE_SHIELD,
		GREAT_SWORD,
		DUAL_SCYTHES,
		GREAT_SCYTHE,
		WHIP_AND_DAGGER,
		PIKE_AND_TOWER_SHIELD,
		AXE_AND_OVAL_SHIELD,
		GREAT_AXE,
		SCEPTER,
		STAFF,
		CANE_AND_ROUND_SHIELD,
		SWORD_AND_TOME,
		TOME_AND_TOWER_SHIELD,
		TOME_AND_KITE_SHIELD,
		GREAT_BOOK_OF_NECROMANCY,
		GREAT_BOOK_OF_THE_ELEMENTS,
		GREAT_BOOK_OF_THE_PURE,
		GREAT_BOOK_OF_LESSER_TRICKS,
		TELEKINESIS_ARMLETS,
		CHARMERS_WHISTLE,
		LONG_BOW,
		CROSSBOW_AND_DAGGER
	}

	private WeaponTypes weaponType;
	private int mainHandAlphaID;
	private int mainHandBetaID;
	private int offHandAlphaID;
	private int offHandBetaID;

	public WeaponTypes WeaponType {
		get{ return weaponType; }
		set{ weaponType = value; }
	}
	public int MainHandAlphaID {
		get{ return mainHandAlphaID; }
		set{ mainHandAlphaID = value; }
	}
	public int MainHandBetaID {
		get{ return mainHandBetaID; }
		set{ mainHandBetaID = value; }
	}
	public int OffHandAlphaID {
		get{ return offHandAlphaID; }
		set{ offHandAlphaID = value; }
	}
	public int OffHandBetaID {
		get{ return offHandBetaID; }
		set{ offHandBetaID = value; }
	}
}