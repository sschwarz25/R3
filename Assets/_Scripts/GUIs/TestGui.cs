using UnityEngine;
using System.Collections;

public class TestGui : MonoBehaviour {
	
	private BaseCharacterClass class1 = new BaseFighterClass();
	private BaseCharacterClass class2 = new BaseMageClass();

	void OnGUI(){
		GUILayout.Label (class1.CharacterClassName);
		GUILayout.Label (class1.CharacterClassDescription);

		GUILayout.Label (class2.CharacterClassName);
		GUILayout.Label (class2.CharacterClassDescription);
	
	}
}
