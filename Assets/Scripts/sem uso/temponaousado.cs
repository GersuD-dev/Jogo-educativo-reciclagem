using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tempo : MonoBehaviour
{
    public Text tempoText;
    private float tempo = 11;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tempo > 0)
        { //se o tempo menor que 0 
            tempo -= Time.deltaTime; //subtrai do Time.deltaTime. 

            int tempoTexto = (int)tempo; //converte o valor float para int 

            tempoText.text = "Tempo: " + tempoTexto.ToString(); // configura o text para o texto Tempo: 10 
        }
        if (tempo <= 0)
        { //se o tempo for menor ou igual a 0 

            tempoText.text = "GAME OVER!"; //Mude o texto para GAME OVER! 

            //Application.LoadLevel("nomeDaScene"); //Reinicia o Scene, especificando o nome desta Scene. 

        }

    }

}
