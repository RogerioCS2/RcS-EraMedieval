using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarregarCena : MonoBehaviour{

    public static CarregarCena instance;
    public Image fadeScreen;
    public float fadeSpeed;
    public bool shouldFadeToBlack;
    public bool shouldFadeFromBlack;
    public GameObject carregaPagina;
   
    void Start(){
        instance = this;
        DontDestroyOnLoad(gameObject);
    }       

    void Update(){
        
        if (shouldFadeToBlack){
            carregaPagina.SetActive(true);
            fadeScreen.color = new Color(fadeScreen.color.r, fadeScreen.color.g, fadeScreen.color.b, 
                                   Mathf.MoveTowards(fadeScreen.color.a, 1f, fadeSpeed * Time.deltaTime));            
            if (fadeScreen.color.a == 1f){
                shouldFadeToBlack = false;
            }            
        }        
        
        if (shouldFadeFromBlack){
            carregaPagina.SetActive(false);
            fadeScreen.color = new Color(fadeScreen.color.r, fadeScreen.color.g, fadeScreen.color.b, 
                                   Mathf.MoveTowards(fadeScreen.color.a, 0f, fadeSpeed * Time.deltaTime));            
            if (fadeScreen.color.a == 0f){
                shouldFadeFromBlack = false;
            }            
        }        
    }
    
    public void FadeToBlack(){
        shouldFadeToBlack = true;
        shouldFadeFromBlack = false;
    }

    public void FadeFromBlack(){
        shouldFadeToBlack = false;
        shouldFadeFromBlack = true;
    }    
}
