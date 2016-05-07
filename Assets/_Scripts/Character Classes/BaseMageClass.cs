using UnityEngine;
using System.Collections;

public class BaseMageClass : BaseCharacterClass {

	public BaseMageClass(){
		CharacterClassName = "Mage";
		CharacterClassDescription = "Conjuring the Elements allows you to defeat foes of all sizes, even the Old Giants";

		//Raw Stat Allotment
		Strength = Endurance = Vitality = Agility = Dexterity = Faith = 0;
		Intelligence = Wisdom = Experience = Charisma = 5;

		//Resists
		MagicResist = FireResist = LightningResist = WaterResist = DarkResist = PureResist = 3;

		//Defenses
		Wieght = Defense = SlashDefense = BluntDefense = PiercingDefense = VerticalDefense = HorizontalDefense = 0;

		//Actions
		DodgeSpeed = 25;
		DodgeDistance = 10;
		RunSpeed = 100;
		FallAbsorption = 5;
		Stability = 15;
		Fortitude = 15;
		Size = 20;
	}
}