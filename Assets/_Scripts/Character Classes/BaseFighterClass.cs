using UnityEngine;
using System.Collections;

public class BaseFighterClass : BaseCharacterClass {

	public BaseFighterClass(){
		CharacterClassName = "Fighter";
		CharacterClassDescription = "Brutal melee in close quarters combat will teach the enemy that you are no pushover.";

		//Raw Stat Allotment
		Strength = Endurance = Vitality = Agility = 5;
		Dexterity = Intelligence = Faith = Wisdom = Experience = Charisma = 0;

		//Resists
		MagicResist = FireResist = LightningResist = WaterResist = DarkResist = PureResist = 0;

		//Defenses
		Wieght = Defense = SlashDefense = BluntDefense = PiercingDefense = VerticalDefense = HorizontalDefense = 3;

		//Actions
		DodgeSpeed = 15;
		DodgeDistance = 5;
		RunSpeed = 100;
		FallAbsorption = 15;
		Stability = 50;
		Fortitude = 50;
		Size = 25;
	}
}
