using UnityEngine;
using System.Collections;

public class BaseTankClass : BaseCharacterClass {

	public BaseTankClass(){
		CharacterClassName = "Tank";
		CharacterClassDescription = "An onslaught of damage is nothing to you. Lead your team to victory!";

		//Raw Stat Allotment
		Strength = Endurance = Vitality = 5;
		Experience = Intelligence = Wisdom = Agility = Charisma = Dexterity = Faith = 0;

		//Resists
		MagicResist = FireResist = LightningResist = WaterResist = DarkResist = PureResist = 3;

		//Defenses
		Wieght = Defense = SlashDefense = BluntDefense = PiercingDefense = VerticalDefense = HorizontalDefense = 3;

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