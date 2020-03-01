using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {
    
    [Header("Tipo do Item")]
    public bool eUmItem;
    public bool eUmaArma;
    public bool eUmaArmadura;    
    [Header("Detalhes do Item")]
    public string itemNome;
    public string descricao;
    public int valor;
    public Sprite imagemItem;    
    [Header("Efeitos do Item")]
    public int quantidadeRecuperada;
    public bool aumentaHP, aumentaMp, aumentaForca;    
    [Header("Detalhes de Arma/Armaduras")]
    public int forcaArma;
    public int forcaArmadura;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    /*
        public void Use(int charToUseOn)
        {
            CharStats selectedChar = GameManager.instance.playerStats[charToUseOn];

            if(eUmItem)
            {
                if(affectHP)
                {
                    selectedChar.currentHP += amountToChange;

                    if(selectedChar.currentHP > selectedChar.maxHP)
                    {
                        selectedChar.currentHP = selectedChar.maxHP;
                    }
                }

                if(affectMP)
                {
                    selectedChar.currentMP += amountToChange;

                    if (selectedChar.currentMP > selectedChar.maxMP)
                    {
                        selectedChar.currentMP = selectedChar.maxMP;
                    }
                }

                if(affectStr)
                {
                    selectedChar.strength += amountToChange;
                }
            }

            if(eUmaArma)
            {
                if(selectedChar.equippedWpn != "")
                {
                    GameManager.instance.AddItem(selectedChar.equippedWpn);
                }

                selectedChar.equippedWpn = itemName;
                selectedChar.wpnPwr = weaponStrength;
            }

            if(eUmaArmadura)
            {
                if (selectedChar.equippedArmr != "")
                {
                    GameManager.instance.AddItem(selectedChar.equippedArmr);
                }

                selectedChar.equippedArmr = itemName;
                selectedChar.armrPwr = armorStrength;
            }

            GameManager.instance.RemoveItem(itemName);
        }
        */
}
