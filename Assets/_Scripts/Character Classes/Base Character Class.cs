using UnityEngine;
using System.Collections;

public class BaseCharacterClass {
	//Main Info
	private string characterName;
	private int characterLevel;
	private string characterClassName;
	private string characterClassDescription;

	//Direct Stats
	private int strength;
	private int dexterity;
	private int agility;
	private int endurance;
	private int vitality;
	private int intelligence;
	private int faith;
	private int wisdom;
	private int experience;
	private int charisma;

	//Resists
	private float magicResist;
	private float fireResist;
	private float lightningResist;
	private float waterResist;
	private float darkResist;
	private float pureResist;

	//Defenses
	private float wieght;
	private float defense;
	private float slashDefense;
	private float bluntDefense;
	private float piercingDefense;
	private float horizontalDefense;
	private float verticalDefense;

	//Action Modifiers
	private float dodgeSpeed;
	private float dodgeDistance;
	private float runSpeed;
	private float fallAbsorption;
	private float stability;
	private float fortitude;
	private float size;

	public string CharacterName{
		get{ return characterName; }
		set{ characterName = value; }
	}
	public int CharacterLevel{
		get{ return characterLevel; }
		set{ characterLevel = value; }
	}
	public string CharacterClassName{
		get{ return characterClassName; }
		set{ characterClassName = value; }
	}
	public string CharacterClassDescription{
		get{ return characterClassDescription; }
		set{ characterClassDescription = value; }
	}
	public int Strength{
		get{ return strength; }
		set{ strength = value; }
	}
	public int Dexterity{
		get{ return dexterity; }
		set{ dexterity = value; }
	}
	public int Agility{
		get{ return agility; }
		set{ agility = value; }
	}
	public int Endurance{
		get{ return endurance; }
		set{ endurance = value; }
	}
	public int Vitality{
		get{ return vitality; }
		set{ vitality = value; }
	}
	public int Intelligence{
		get{ return intelligence; }
		set{ intelligence = value; }
	}
	public int Faith{
		get{ return faith; }
		set{ faith = value; }
	}
	public int Wisdom{
		get{ return wisdom; }
		set{ wisdom = value; }
	}

	public int Experience{
		get{ return experience; }
		set{ experience = value; }
	}

	public int Charisma{
		get{ return charisma; }
		set{ charisma = value; }
	}
	public float MagicResist {
		get{ return magicResist; }
		set{ magicResist = value; }
	}
	public float FireResist {
		get{ return fireResist; }
		set{ fireResist = value; }
	}
	public float LightningResist {
		get{ return lightningResist; }
		set{ lightningResist = value; }
	}
	public float WaterResist {
		get{ return waterResist; }
		set{ waterResist = value; }
	}
	public float DarkResist {
		get{ return darkResist; }
		set{ darkResist = value; }
	}
	public float PureResist {
		get{ return pureResist; }
		set{ pureResist = value; }
	}
	public float Wieght {
		get{ return wieght; }
		set{ wieght = value; }
	}
	public float Defense {
		get{ return defense; }
		set{ defense = value; }
	}
	public float SlashDefense {
		get{ return slashDefense; }
		set{ slashDefense = value; }
	}
	public float BluntDefense {
		get{ return bluntDefense; }
		set{ bluntDefense = value; }
	}
	public float PiercingDefense {
		get{ return piercingDefense; }
		set{ piercingDefense = value; }
	}
	public float HorizontalDefense {
		get{ return horizontalDefense; }
		set{ horizontalDefense = value; }
	}
	public float VerticalDefense {
		get{ return verticalDefense; }
		set{ verticalDefense = value; }
	}
	public float DodgeSpeed {
		get{ return dodgeSpeed; }
		set{ dodgeSpeed = value; }
	}
	public float DodgeDistance {
		get{ return dodgeDistance; }
		set{ dodgeDistance = value; }
	}
	public float RunSpeed {
		get{ return runSpeed; }
		set{ runSpeed = value; }
	}
	public float FallAbsorption {
		get{ return fallAbsorption; }
		set{ fallAbsorption = value; }
	}
	public float Stability {
		get{ return stability; }
		set{ stability = value; }
	}
	public float Fortitude {
		get{ return fortitude; }
		set{ fortitude = value; }
	}
	public float Size {
		get{ return size; }
		set{ size = value; }
	}


}
