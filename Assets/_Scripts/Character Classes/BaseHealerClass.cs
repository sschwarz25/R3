using UnityEngine;
using System.Collections;

public class BaseHealerClass : BaseCharacterClass {

	public BaseHealerClass(){
		CharacterClassName = "Healer";
		CharacterClassDescription = "While you cannot take many hits, you can allow someone else to take many more.";

		//Raw Stat Allotment
		Strength = Endurance = Vitality = Agility = Dexterity = Intelligence = 0;
		Faith = Wisdom = Experience = Charisma = 5;

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