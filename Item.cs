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

    public void CarragaInformacoesDoItem(int use) {
        StatusPersonagens personagemSelecionado = GameManager.instance.playerStats[use];
        if (isItem) {
            if (affectHP) {
                personagemSelecionado.hpAtual += amountTochange;
                if (personagemSelecionado.hpAtual > personagemSelecionado.hpMaximo) {
                    personagemSelecionado.hpAtual = personagemSelecionado.hpMaximo;
                }
            }
            if (affectMP){
                personagemSelecionado.mpAtual += amountTochange;
                if (personagemSelecionado.mpAtual > personagemSelecionado.mpMaximo){
                    personagemSelecionado.mpAtual = personagemSelecionado.mpMaximo;
                }
            }
            if (affectStr){
                personagemSelecionado.forca += amountTochange;                                
            }
        }

        if (isWeapon){
            if (personagemSelecionado.armaEquipada != "") {
                GameManager.instance.AdicionaItemInventario(personagemSelecionado.armaEquipada);
            }
            personagemSelecionado.armaEquipada = itemName;
            personagemSelecionado.forcaArma = weaponStrength;            
        }

        if (isArmour){
            if (personagemSelecionado.armaEquipada != ""){
                GameManager.instance.AdicionaItemInventario(personagemSelecionado.armaduraEquipada);
            }
            personagemSelecionado.armaduraEquipada = itemName;
            personagemSelecionado.forcaArmadura = armorStrength;
        }
        GameManager.instance.RemoveItemInventario(itemName);
    }    
}
