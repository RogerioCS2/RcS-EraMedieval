﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotaoItem : MonoBehaviour{
    public Image imagemBotao;
    public Text quantitativoTexto;
    public int botao;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pressionar() {
        if (GameManager.instance.itensAdquiridos[botao] != "") {
            MenuJogo.instance.SelecionaItem(GameManager.instance.CarregandoItens(GameManager.instance.itensAdquiridos[botao]));
        }
    }
}
