using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControleDialogo : MonoBehaviour{
    public Text textoDialogo;
    public Text textoNome;
    public GameObject caixaDialogo;
    public GameObject caixaNome;
    public string[] linhasDialogo;
    public int linhaDialogoAtual;
    private bool dialogoIniciadoAgora;
    public static ControleDialogo instance;   
    
    void Start(){       
        instance = this;
    }
       
    void Update(){
        if (caixaDialogo.activeInHierarchy){
            if (Input.GetButtonUp("Fire1")){
                if (!dialogoIniciadoAgora){
                    linhaDialogoAtual++;
                    if (linhaDialogoAtual >= linhasDialogo.Length){
                        caixaDialogo.SetActive(false);
                    }else{
                        textoDialogo.text = linhasDialogo[linhaDialogoAtual];
                    }
                }else {
                    dialogoIniciadoAgora = false;
                }                   
            }
        }
           
    }    
    
    public void AtivadorDialogo(string[] novaLinha, bool umaPessoa) {
        linhasDialogo = novaLinha;
        linhaDialogoAtual = 0;        
        textoDialogo.text = linhasDialogo[0];
        caixaDialogo.SetActive(true);
        dialogoIniciadoAgora = true;
        caixaNome.SetActive(umaPessoa);       
    }
    
    /*
    public void CheckIfName(){
        if (dialogLines[currentLine].StartsWith("n-")){
            nameText.text = dialogLines[currentLine].Replace("n-", "");
            currentLine++;
        }
    }
    */

    /*
    public void ShouldActivateQuestEnd(string questName, bool markComplete){
        questToMark = questName;
        markQuestComplete = markComplete;
        shouldMarkQuest = true;
    }
    */
}
