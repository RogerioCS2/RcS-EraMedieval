﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuJogo : MonoBehaviour {  

    public GameObject menuJogo;
    public GameObject[] janelas;
    private StatusPersonagens[] situacaoPersonagem;
    public Text[] nomeTexto, hpTexto, mpTexto, lvlTexto, expTexto;
    public Slider[] expSlider;
    public Image[] imagemPersonagem;
  
    public GameObject[] pseronagenCaracteristicas;
    public GameObject[] botoesDeStatus;
  
    public Text nomePersonagem, situacaoHP, situacaoMP, situacaoForca, sutuacaoDefesa, situacaoArmaEquipada, sitacaoForcaArma, situacaoArmaduraEquipada, situacaoForcaArmadura, situacaoExp;
    public Image situacaoImagem;
  
    //public ItemButton[] itemButtons;
    //public string selectedItem;
    //public Item activeItem;
    // public Text itemName, itemDescription, useButtonText;

    public GameObject itemMenuPersonagem;
    //public Text[] itemCharChoiceNames;
    //public static MenuJogo instance;
    //public Text ouroTexto;
    //public string mainMenuName;

    // Use this for initialization
    void Start()
    {
        //instance = this;
    }

    // Update is called once per frame
    void Update(){        
        if (Input.GetButtonDown("Fire2")){
            if (menuJogo.activeInHierarchy){                          
                FecharMenu();
            } else {
                menuJogo.SetActive(true);
                AtualizandoStatus();
                GameManager.instance.menuEstaAberto = true;
            }

            //AudioManager.instance.PlaySFX(5);
        }        
    }
    
    public void AtualizandoStatus(){
        situacaoPersonagem = GameManager.instance.playerStats;

        for (int i = 0; i < situacaoPersonagem.Length; i++) {
            if (situacaoPersonagem[i].gameObject.activeInHierarchy) {
                pseronagenCaracteristicas[i].SetActive(true);                
                nomeTexto[i].text = situacaoPersonagem[i].nomePersonagem;
                hpTexto[i].text = "HP: " + situacaoPersonagem[i].hpAtual + "/" + situacaoPersonagem[i].hpMaximo;
                mpTexto[i].text = "MP: " + situacaoPersonagem[i].mpAtual + "/" + situacaoPersonagem[i].mpMaximo;
                lvlTexto[i].text = "Lvl: " + situacaoPersonagem[i].personagemLevel;
                expTexto[i].text = "" + situacaoPersonagem[i].experienciaAtual + "/" + situacaoPersonagem[i].experienciaProximoLevel[situacaoPersonagem[i].personagemLevel];
                expSlider[i].maxValue = situacaoPersonagem[i].experienciaProximoLevel[situacaoPersonagem[i].personagemLevel];
                expSlider[i].value = situacaoPersonagem[i].experienciaAtual;
                imagemPersonagem[i].sprite = situacaoPersonagem[i].imagemPersonagem;                
            }  else {
                pseronagenCaracteristicas[i].SetActive(false);
            }
        }

        //goldText.text = GameManager.instance.currentGold.ToString() + "g";
    }   
  
    public void AlterandoJoanelasMenu(int numeroJanela){
        //AtualizandoStatus();
        for (int i = 0; i < janelas.Length; i++){
            if (i == numeroJanela){
                janelas[i].SetActive(!janelas[i].activeInHierarchy);
            }else{
                janelas[i].SetActive(false);
            }
        }
        //itemMenuPersonagem.SetActitemCharChoiceMenuive(false);
    }  
    
    public void FecharMenu(){
        for (int i = 0; i < janelas.Length; i++){
            janelas[i].SetActive(false);
        }
        menuJogo.SetActive(false);
        GameManager.instance.menuEstaAberto = false;
        //itemMenuPersonagem.SetActive(false);
    }  
    
    public void AbrindoStatusPersonagens(){
        AtualizandoStatus();
        //update the information that is shown
        SituacaoAtualPersonagem(0);
        for (int i = 0; i < botoesDeStatus.Length; i++) {
            botoesDeStatus[i].SetActive(situacaoPersonagem[i].gameObject.activeInHierarchy);
            botoesDeStatus[i].GetComponentInChildren<Text>().text = situacaoPersonagem[i].nomePersonagem;
        }
    }
    
    ///*
    public void SituacaoAtualPersonagem(int perosnagemSelecionado){        
        nomePersonagem.text = situacaoPersonagem[perosnagemSelecionado].nomePersonagem;
        situacaoHP.text = "" + situacaoPersonagem[perosnagemSelecionado].hpAtual + "/" + situacaoPersonagem[perosnagemSelecionado].hpMaximo;
        situacaoMP.text = "" + situacaoPersonagem[perosnagemSelecionado].mpAtual + "/" + situacaoPersonagem[perosnagemSelecionado].mpMaximo;
        situacaoForca.text = situacaoPersonagem[perosnagemSelecionado].forca.ToString();
        sutuacaoDefesa.text = situacaoPersonagem[perosnagemSelecionado].defesa.ToString();
        if (situacaoPersonagem[perosnagemSelecionado].armaEquipada != "")
        {
            situacaoArmaEquipada.text = situacaoPersonagem[perosnagemSelecionado].armaEquipada;
        }
        sitacaoForcaArma.text = situacaoPersonagem[perosnagemSelecionado].forcaArma.ToString();
        if (situacaoPersonagem[perosnagemSelecionado].armaduraEquipada != "")
        {
            situacaoArmaduraEquipada.text = situacaoPersonagem[perosnagemSelecionado].armaduraEquipada;
        }
        situacaoForcaArmadura.text = situacaoPersonagem[perosnagemSelecionado].forcaArmadura.ToString();
        situacaoExp.text = (situacaoPersonagem[perosnagemSelecionado].experienciaProximoLevel[situacaoPersonagem[perosnagemSelecionado].personagemLevel] - situacaoPersonagem[perosnagemSelecionado].experienciaAtual).ToString();
        situacaoImagem.sprite = situacaoPersonagem[perosnagemSelecionado].imagemPersonagem;
    }
    //*/
    /*
    public void ShowItems()
    {
        GameManager.instance.SortItems();

        for (int i = 0; i < itemButtons.Length; i++)
        {
            itemButtons[i].buttonValue = i;

            if (GameManager.instance.itemsHeld[i] != "")
            {
                itemButtons[i].buttonImage.gameObject.SetActive(true);
                itemButtons[i].buttonImage.sprite = GameManager.instance.GetItemDetails(GameManager.instance.itemsHeld[i]).itemSprite;
                itemButtons[i].amountText.text = GameManager.instance.numberOfItems[i].ToString();
            }
            else
            {
                itemButtons[i].buttonImage.gameObject.SetActive(false);
                itemButtons[i].amountText.text = "";
            }
        }
    }
    */
    /*
    public void SelectItem(Item newItem)
    {
        activeItem = newItem;

        if (activeItem.isItem)
        {
            useButtonText.text = "Use";
        }

        if (activeItem.isWeapon || activeItem.isArmour)
        {
            useButtonText.text = "Equip";
        }

        itemName.text = activeItem.itemName;
        itemDescription.text = activeItem.description;
    }
    */
   /*
    public void DiscardItem()
    {
        if (activeItem != null)
        {
            GameManager.instance.RemoveItem(activeItem.itemName);
        }
    }
   */
    /*
    public void OpenItemCharChoice()
    {
        itemMenuPersonagem.SetActive(true);

        for (int i = 0; i < itemCharChoiceNames.Length; i++)
        {
            itemCharChoiceNames[i].text = GameManager.instance.playerStats[i].charName;
            itemCharChoiceNames[i].transform.parent.gameObject.SetActive(GameManager.instance.playerStats[i].gameObject.activeInHierarchy);
        }
    }
    */
    /*
    public void CloseItemCharChoice()
    {
        itemMenuPersonagem.SetActive(false);
    }
    */
    /*
    public void UseItem(int selectChar)
    {
        activeItem.Use(selectChar);
        CloseItemCharChoice();
    }
    */
    /*
    public void SaveGame()
    {
        GameManager.instance.SaveData();
        QuestManager.instance.SaveQuestData();
    }
   */
    /*
    public void PlayButtonSound()
    {
        AudioManager.instance.PlaySFX(4);
    }
    */
    /*
    public void QuitGame()
    {
        SceneManager.LoadScene(mainMenuName);

        Destroy(GameManager.instance.gameObject);
        Destroy(PlayerController.instance.gameObject);
        Destroy(AudioManager.instance.gameObject);
        Destroy(gameObject);
    }*/
}
