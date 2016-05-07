using UnityEngine;
using System.Collections;

public class CustomClass : BaseCharacterClass {

	public CustomClass(){
		CharacterClassName = "Custom";
		CharacterClassDescription = "The meek shall inherit this hell.";

		//Raw Stat Allotment
		Strength = Endurance = Vitality = Experience = Intelligence = Wisdom = Agility = Charisma = Dexterity = Faith = 0;

		//Resists
		MagicResist = FireResist = LightningResist = WaterResist = DarkResist = PureResist = 0;

		//Defenses
		Wieght = Defense = SlashDefense = BluntDefense = PiercingDefense = VerticalDefense = HorizontalDefense = 0;

		//Actions
		DodgeSpeed = 30;
		DodgeDistance = 30;
		RunSpeed = 100;
		FallAbsorption = 0;
		Stability = 0;
		Fortitude = 0;
		Size = 20;
	}
}