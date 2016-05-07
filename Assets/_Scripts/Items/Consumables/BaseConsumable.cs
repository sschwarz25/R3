using UnityEngine;
using System.Collections;

public class BaseConsumable : MonoBehaviour {
	private int passiveEffectID;
	private int activeEffectID;

	public int PassiveEffectID {
		get{ return passiveEffectID; }
		set{ passiveEffectID = value; }
	}
	public int ActiveEffectID {
		get{ return activeEffectID; }
		set{ activeEffectID = value; }
	}
}
