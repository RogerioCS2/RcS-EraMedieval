using UnityEngine;

public class Entrada : MonoBehaviour{
    public string transitionName;
    
    void Start()    {
        if (transitionName == ControlePersonagem.instance.areaTransitionName){
            ControlePersonagem.instance.transform.position = transform.position;
            MovimentoMago.instance.transform.position = transform.position;
            MovimentoPrincesa.instance.transform.position = transform.position;
        }
        
        CarregarCena.instance.FadeFromBlack();
        //GameManager.instance.fadingBetweenAreas = false;
    }
    
    void Update(){

    }
}
