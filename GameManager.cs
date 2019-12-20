using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{
    public static GameManager instance;
    public StatusPersonagens[] personagemStatus;
    //public bool gameMenuOpen, dialogActive, fadingBetweenAreas, shopActive, battleActive;
    //public string[] itemsHeld;
    //public int[] numberOfItems;   
    //public int currentGold;
   
    void Start(){
        instance = this;
        DontDestroyOnLoad(gameObject);
        //SortItems();
    }
    
    void Update(){
        /*
        if (gameMenuOpen || dialogActive || fadingBetweenAreas || shopActive || battleActive){
            ControlePersonagem.instance.podeAndar = false;
        }else{
            ControlePersonagem.instance.podeAndar = true;
        }

        if (Input.GetKeyDown(KeyCode.J)){
            AddItem("Iron Armor");
            AddItem("Blabla");
            RemoveItem("Health Potion");
            RemoveItem("Bleep");
        }

        if (Input.GetKeyDown(KeyCode.O)){
            SaveData();
        }

        if (Input.GetKeyDown(KeyCode.P)){
            LoadData();
        }
        */
    }
    /*
    public Item GetItemDetails(string itemToGrab){

        for (int i = 0; i < referenceItems.Length; i++){
            if (referenceItems[i].itemName == itemToGrab){
                return referenceItems[i];
            }
        }
        return null;
    }
    */
    /*
    public void SortItems(){
        bool itemAFterSpace = true;
        while (itemAFterSpace){
            itemAFterSpace = false;
            for (int i = 0; i < itemsHeld.Length - 1; i++){
                if (itemsHeld[i] == ""){
                    itemsHeld[i] = itemsHeld[i + 1];
                    itemsHeld[i + 1] = "";
                    numberOfItems[i] = numberOfItems[i + 1];
                    numberOfItems[i + 1] = 0;
                    if (itemsHeld[i] != ""){
                        itemAFterSpace = true;
                    }
                }
            }
        }
    }
    */
    /*
    public void AddItem(string itemToAdd){
        int newItemPosition = 0;
        bool foundSpace = false;

        for (int i = 0; i < itemsHeld.Length; i++){
            if (itemsHeld[i] == "" || itemsHeld[i] == itemToAdd)
            {
                newItemPosition = i;
                i = itemsHeld.Length;
                foundSpace = true;
            }
        }

        if (foundSpace){
            bool itemExists = false;
            for (int i = 0; i < referenceItems.Length; i++){
                if (referenceItems[i].itemName == itemToAdd){
                    itemExists = true;
                    i = referenceItems.Length;
                }
            }

            if (itemExists){
                itemsHeld[newItemPosition] = itemToAdd;
                numberOfItems[newItemPosition]++;
            }else{
                Debug.LogError(itemToAdd + " Does Not Exist!!");
            }
        }

        GameMenu.instance.ShowItems();
    }
    */
    /*
    public void RemoveItem(string itemToRemove){
        bool foundItem = false;
        int itemPosition = 0;
        for (int i = 0; i < itemsHeld.Length; i++){
            if (itemsHeld[i] == itemToRemove){
                foundItem = true;
                itemPosition = i;
                i = itemsHeld.Length;
            }
        }

        if (foundItem){
            numberOfItems[itemPosition]--;
            if (numberOfItems[itemPosition] <= 0){
                itemsHeld[itemPosition] = "";
            }
            GameMenu.instance.ShowItems();
        }else{
            Debug.LogError("Couldn't find " + itemToRemove);
        }
    }
    */
    /*

    public void SaveData(){
        PlayerPrefs.SetString("Current_Scene", SceneManager.GetActiveScene().name);
        PlayerPrefs.SetFloat("Player_Position_x", ControlePersonagem.instance.transform.position.x);
        PlayerPrefs.SetFloat("Player_Position_y", ControlePersonagem.instance.transform.position.y);
        PlayerPrefs.SetFloat("Player_Position_z", ControlePersonagem.instance.transform.position.z);

        //save character info
        for (int i = 0; i < personagemStatus.Length; i++){
            if (personagemStatus[i].gameObject.activeInHierarchy)
            {
                PlayerPrefs.SetInt("Player_" + personagemStatus[i].nomePersonagem + "_active", 1);
            }
            else
            {
                PlayerPrefs.SetInt("Player_" + personagemStatus[i].nomePersonagem + "_active", 0);
            }

            PlayerPrefs.SetInt("Player_" + personagemStatus[i].nomePersonagem + "_Level", personagemStatus[i].playerLevel);
            PlayerPrefs.SetInt("Player_" + personagemStatus[i].nomePersonagem + "_CurrentExp", personagemStatus[i].currentEXP);
            PlayerPrefs.SetInt("Player_" + personagemStatus[i].nomePersonagem + "_CurrentHP", personagemStatus[i].currentHP);
            PlayerPrefs.SetInt("Player_" + personagemStatus[i].nomePersonagem + "_MaxHP", personagemStatus[i].maxHP);
            PlayerPrefs.SetInt("Player_" + personagemStatus[i].nomePersonagem + "_CurrentMP", personagemStatus[i].currentMP);
            PlayerPrefs.SetInt("Player_" + personagemStatus[i].nomePersonagem + "_MaxMP", personagemStatus[i].maxMP);
            PlayerPrefs.SetInt("Player_" + personagemStatus[i].nomePersonagem + "_Strength", personagemStatus[i].strength);
            PlayerPrefs.SetInt("Player_" + personagemStatus[i].nomePersonagem + "_Defence", personagemStatus[i].defence);
            PlayerPrefs.SetInt("Player_" + personagemStatus[i].nomePersonagem + "_WpnPwr", personagemStatus[i].wpnPwr);
            PlayerPrefs.SetInt("Player_" + personagemStatus[i].nomePersonagem + "_ArmrPwr", personagemStatus[i].armrPwr);
            PlayerPrefs.SetString("Player_" + personagemStatus[i].nomePersonagem + "_EquippedWpn", personagemStatus[i].equippedWpn);
            PlayerPrefs.SetString("Player_" + personagemStatus[i].nomePersonagem + "_EquippedArmr", personagemStatus[i].equippedArmr);
        }

        //store inventory data
        for (int i = 0; i < itemsHeld.Length; i++){
            PlayerPrefs.SetString("ItemInInventory_" + i, itemsHeld[i]);
            PlayerPrefs.SetInt("ItemAmount_" + i, numberOfItems[i]);
        }
    }
    */
    /*
    public void LoadData(){
        ControlePersonagem.instance.transform.position = new Vector3(PlayerPrefs.GetFloat("Player_Position_x"), PlayerPrefs.GetFloat("Player_Position_y"), PlayerPrefs.GetFloat("Player_Position_z"));
        for (int i = 0; i < personagemStatus.Length; i++)
        {
            if (PlayerPrefs.GetInt("Player_" + personagemStatus[i].nomePersonagem + "_active") == 0){
                personagemStatus[i].gameObject.SetActive(false);
            }else{
                personagemStatus[i].gameObject.SetActive(true);
            }

            personagemStatus[i].playerLevel = PlayerPrefs.GetInt("Player_" + personagemStatus[i].nomePersonagem + "_Level");
            personagemStatus[i].currentEXP = PlayerPrefs.GetInt("Player_" + personagemStatus[i].nomePersonagem + "_CurrentExp");
            personagemStatus[i].currentHP = PlayerPrefs.GetInt("Player_" + personagemStatus[i].nomePersonagem + "_CurrentHP");
            personagemStatus[i].maxHP = PlayerPrefs.GetInt("Player_" + personagemStatus[i].nomePersonagem + "_MaxHP");
            personagemStatus[i].currentMP = PlayerPrefs.GetInt("Player_" + personagemStatus[i].nomePersonagem + "_CurrentMP");
            personagemStatus[i].maxMP = PlayerPrefs.GetInt("Player_" + personagemStatus[i].nomePersonagem + "_MaxMP");
            personagemStatus[i].strength = PlayerPrefs.GetInt("Player_" + personagemStatus[i].nomePersonagem + "_Strength");
            personagemStatus[i].defence = PlayerPrefs.GetInt("Player_" + personagemStatus[i].nomePersonagem + "_Defence");
            personagemStatus[i].wpnPwr = PlayerPrefs.GetInt("Player_" + personagemStatus[i].nomePersonagem + "_WpnPwr");
            personagemStatus[i].armrPwr = PlayerPrefs.GetInt("Player_" + personagemStatus[i].nomePersonagem + "_ArmrPwr");
            personagemStatus[i].equippedWpn = PlayerPrefs.GetString("Player_" + personagemStatus[i].nomePersonagem + "_EquippedWpn");
            personagemStatus[i].equippedArmr = PlayerPrefs.GetString("Player_" + personagemStatus[i].nomePersonagem + "_EquippedArmr");
        }
                
        for (int i = 0; i < itemsHeld.Length; i++){
            itemsHeld[i] = PlayerPrefs.GetString("ItemInInventory_" + i);
            numberOfItems[i] = PlayerPrefs.GetInt("ItemAmount_" + i);
        }        
    }
    */
}
