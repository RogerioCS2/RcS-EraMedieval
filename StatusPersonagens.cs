using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusPersonagens : MonoBehaviour{
    public string nomePersonagem;
    public int personagemLevel = 1;
    public int experienciaAtual;
    public int[] experienciaProximoLevel;
    public int levelMaximo = 100;
    public int experienciaBase = 30;
    public int hpAtual;
    public int hpMaximo = 30;
    public int mpAtual;
    public int mpMaximo = 30;
    public int[] mpLevelBonus;
    public int forca;
    public int defesa;
    public int forcaArma;
    public int forcaArmadura;
    public string armaEquipada;
    public string armaduraEquipada;
    public Sprite imagemPersonagem;
   
    void Start(){
        experienciaProximoLevel = new int[levelMaximo];
        experienciaProximoLevel[1] = experienciaBase;
        for (int i = 2; i < experienciaProximoLevel.Length; i++){
            experienciaProximoLevel[i] = Mathf.FloorToInt(experienciaProximoLevel[i - 1] * 1.05f);
        }
    }
  
    void Update(){        
        if (Input.GetKeyDown(KeyCode.K)){
            AddExp(1000);
        }        
    }
        
    public void AddExp(int expToAdd){
        experienciaAtual += expToAdd;
        if (personagemLevel < levelMaximo){
            if (experienciaAtual > experienciaProximoLevel[personagemLevel]){
                experienciaAtual -= experienciaProximoLevel[personagemLevel];
                personagemLevel++;
                if (personagemLevel % 2 == 0)                {
                    forca++;
                }else{
                    defesa++;
                }
                hpMaximo = Mathf.FloorToInt(hpMaximo * 1.05f);
                hpAtual = hpMaximo;
                mpMaximo += mpLevelBonus[personagemLevel];
                mpAtual = mpMaximo;
            }
        }

        if (personagemLevel >= levelMaximo){
            experienciaAtual = 0;
        }
    }    
}

