using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {
    [Header ("Tipos de Itens")]
    public bool isItem;
    public bool isWeapon;
    public bool isArmour;
    [Header ("Caracteristicas Itens")]
    public string itemName;
    public string description;
    public int value;
    public Sprite itemSprite;
    [Header ("Beneficios Itens")]
    public int amountTochange;
    public bool affectHP, affectMP, affectStr;
    [Header ("Detalhes Armas/Armaduras")]
    public int weaponStrength;
    public int armorStrength;
       
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
}
