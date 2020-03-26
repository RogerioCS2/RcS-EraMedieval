using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {
    public bool isItem;
    public bool isWeapon;
    public bool isArmour;

    public string itemName;
    public string description;
    public int value;
    public Sprite itemSprite;

    public int amountTochange;
    public bool affectHP, affectMP, affectStr;

    public int weaponStrength;
    public int armorStrength;
       
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
}
