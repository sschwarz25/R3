using UnityEngine;
using System.Collections;

public class BaseScroll : BaseItem {
	private int activeEffectID;

	public int ActiveEffectID {
		get{ return activeEffectID; }
		set{ activeEffectID = value; }
	}
}
