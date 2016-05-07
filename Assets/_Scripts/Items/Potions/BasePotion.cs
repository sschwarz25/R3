using UnityEngine;
using System.Collections;

public class BasePotion : BaseStatItem {
	public enum PotionTypes{
		HEALTH,
		MANA,
		STAMINA,
		SIZE,
		MELEE,
		CASTER,
		TANK
	}

	private PotionTypes potionType;
	private int passiveEffectID;

	public PotionTypes PotionType {
		get{ return potionType; }
		set{ potionType = value; }
	}

	public int PassiveEffectID {
		get{ return passiveEffectID; }
		set{ passiveEffectID = value; }
	}
}