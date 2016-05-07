using UnityEngine;
using System.Collections;

public class Profile{
	private string profileName;
	private int characterSlots;
	private BaseCharacterClass[] characters;

	public Profile(){
		characterSlots = 3;
		characters = new BaseCharacterClass[characterSlots];
	}

	public string ProfileName {
		get{ return profileName; }
		set{ profileName = value; }
	}

	public int CharacterSlots {
		get{ return characterSlots; }
		set{ characterSlots = value; }
	}

	public void UpdateCharacterSlots(){
		BaseCharacterClass[] temp = characters;
		characters = new BaseCharacterClass[characterSlots];
		for (int i = 0; i < temp.Length; i++) {
			characters [i] = temp [i];
		}
	}
}
