using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Unity.Burst;

public class Coletar : MonoBehaviour
{
    /////////////////////  /////////////////////  /////////////////////  /////////////////////  /////////////////////  /////////////////////  

    public Sprite imagemAcerto;
    public Sprite imagemErro;
    public Image imagemResultado;

   public bool lixo;
   
   public bool organico;
   public bool vidro;
   public bool papel;
   public bool metal;
   public bool plastico;

    public int numorganico;
    public int numvidro;
    public int numpapel;
    public int nummetal;
    public int numplastico;

    private string textoErrado;
    private string anterior;
    public string textoTela;
    public Text texto;
    public Text textoErrado2;

    public Text Textorganico;
    public Text Textvidro;
    public Text Textpapel;
    public Text Textmetal;
    public Text Textplastico;

   /////////////////////


    void Start()
    {


        imagemResultado.enabled = false;
        textoTela = "Rápido! Salve o parque catando os lixos \r\n\r\nespalhados.";

        lixo = false;

        numorganico = 0;
           numvidro = 0;
                numpapel = 0;
                   nummetal = 0;
                       numplastico = 0;


        organico = false;
        vidro = false;
        papel = false;
        metal = false;
        plastico = false;
    }

    /////////////////////

    void Update()
    {
        texto.text = textoTela;
        textoErrado2.text = textoErrado;
        Textorganico.text = numorganico.ToString();
        Textvidro.text = numvidro.ToString();
        Textpapel.text = numpapel.ToString();
        Textmetal.text = nummetal.ToString();
        Textplastico.text = numplastico.ToString();

    }
    ////////////////////  

    //     LIXEIRA     \\  

    private void OnCollisionEnter2D(Collision2D collision2D)
    {


        if (collision2D.gameObject.CompareTag("lixo-organico"))
        {


            

            if (lixo)
            {
                
                if (organico)
                {
                ExibirResultado(true);
                textoTela = "Parabéns! Você colocou o lixo na lixeira certa!";
                textoErrado = "";

                numorganico = numorganico + 1;
                lixo = false;
                organico = false;
                

                } else
                {
                ExibirResultado(false);
                textoTela = "";
                textoErrado = "Você está botando o lixo " + " '' " + anterior +  " '' " +" na lixeira errada.";
                }

            }
        }

        if (collision2D.gameObject.CompareTag("lixo-plastico"))
        {
            if (lixo)
            {

                if (plastico)
                {
                    ExibirResultado(true);
                    textoTela = "Parabéns! Você colocou o lixo na lixeira certa!";
                    textoErrado = "";

                    
                    lixo = false;
                    numplastico = numplastico + 1;
                    plastico = false;

                }
                else
                {
                    ExibirResultado(false);
                    textoTela = "";
                    textoErrado = "Você está botando o lixo " + " '' " + anterior +  " '' " +" na lixeira errada.";
                }

            }
        }

        if (collision2D.gameObject.CompareTag("lixo-vidro"))
        {
            if (lixo)
            {

                if (vidro)
                {
                    ExibirResultado(true);
                    textoTela = "Parabéns! Você colocou o lixo na lixeira certa!";
                    textoErrado = "";

                    numvidro = numvidro + 1;
                    lixo = false;
                    vidro = false;

                }else
                {
                    ExibirResultado(false);
                    textoTela = "";
                    textoErrado = "Você está botando o lixo " + " '' " + anterior +  " '' " +" na lixeira errada.";
                }

            }
        }

        if (collision2D.gameObject.CompareTag("lixo-papel"))
        {
            if (lixo)
            {

                if (papel)
                {
                    ExibirResultado(true);
                    textoTela = "Parabéns! Você colocou o lixo na lixeira certa!";
                    textoErrado = "";

                    lixo = false;
                    papel = false;
                    numpapel = numpapel + 1;
                }else
                {
                    ExibirResultado(false);
                    textoTela = "";
                    textoErrado = "Você está botando o lixo " + " '' " + anterior +  " '' " +" na lixeira errada.";
                }

            }
        }

        if (collision2D.gameObject.CompareTag("lixo-metal"))
        {
            if (lixo)
            {

                if (metal)
                {
                    ExibirResultado(true);
                    textoTela = "Parabéns! Você colocou o lixo na lixeira certa!";
                    textoErrado = "";

                    nummetal = nummetal + 1;
                    lixo = false;
                    metal = false;
                }else
                {
                    ExibirResultado(false);
                    textoTela = "";
                    textoErrado = "Você está botando o lixo " + " '' " + anterior +  " '' " +" na lixeira errada.";
                }

            }
        }
    }

    //////////////////

      //     LIXO       \\ 



    private void OnTriggerEnter2D(Collider2D collision2D)
    {

        if (collision2D.gameObject.CompareTag("organico"))
        {


            if (!lixo)
            {
                textoTela = "Você está segurando um material ''Orgânico''.";
                anterior = "Orgânico";
                lixo = true;
                organico = true;
                Destroy(collision2D.gameObject);
            }


        }

        if (collision2D.gameObject.CompareTag("plastico"))
        {
                if (!lixo)
                {

                    textoTela = "Você está segurando um material de ''Plástico''.";
                    anterior = "Plástico";
                    lixo = true;
                    plastico = true;
                    Destroy(collision2D.gameObject);
                }


            }

        if (collision2D.gameObject.CompareTag("vidro"))
        {
            if (!lixo)
            {
                
                textoTela = "Você está segurando um material de ''Vidro''.";
                anterior = "Vidro";
                lixo = true;
                vidro = true;
                Destroy(collision2D.gameObject);
            }

        }

        if (collision2D.gameObject.CompareTag("papel"))
        {

            if (!lixo)
            {
                
                textoTela = "Você está segurando um material de ''Papel''.";
                anterior = "Papel";
                lixo = true;
                papel = true;
                Destroy(collision2D.gameObject);
            }

        }
        if (collision2D.gameObject.CompareTag("metal"))
        {

            if (!lixo)
            {

                
                textoTela = "Você está segurando um material de ''Metal''.";
                anterior = "Metal";
                lixo = true;
                metal = true;
                Destroy(collision2D.gameObject);
            }

        }


    } 

     public void ExibirResultado(bool acertou)
    {
        imagemResultado.sprite = acertou == true ? imagemAcerto : imagemErro; //muda o sprite da Imagem conforme a bool acertou
        imagemResultado.enabled = true; //Ativa o componente da imagem, deixando-a visível.
        StartCoroutine(Cronometro()); //Inicia a contagem de tempo
    }

    public IEnumerator Cronometro()
    {
        yield return new WaitForSeconds(2); //Aguarda dois segundos, caso queira utilizar uma fração de tempo use o padrão (1.3f);
        imagemResultado.enabled = false; //Após o tempo decorrido, desativa a imagem.
    }

}


