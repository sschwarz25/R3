using UnityEngine;
using System.Collections;

public class BaseEquipment : BaseStatItem {

	public enum EquipmentTypes{
		HEAD,
		CHEST,
		HANDS,
		LEGS,
		FEET,
		RING1,
		RING2,
		RING3,
		RING4
	}

	private EquipmentTypes equipmentType;
	private int passiveEffectID;
	private int activeEffectID;

	public EquipmentTypes EquipmentType {
		get{ return equipmentType; }
		set{ equipmentType = value; }
	}
	public int PassiveEffectID {
		get{ return passiveEffectID; }
		set{ passiveEffectID = value; }
	}
	public int ActiveEffectID {
		get{ return activeEffectID; }
		set{ activeEffectID = value; }
	}
}
