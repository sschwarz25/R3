using UnityEngine;
using System.Collections;

public class BaseSupportClass : BaseCharacterClass {

	public BaseSupportClass(){
		CharacterClassName = "Support";
		CharacterClassDescription = "Make your foes tremble, crumble, and rot.";

		//Raw Stat Allotment
		Strength = Experience = Wisdom = Agility = Dexterity = Faith = 0;
		Intelligence = Vitality = Endurance = Charisma = 5;

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