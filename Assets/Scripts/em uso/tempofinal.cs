using UnityEngine;
using UnityEngine.UI;
public class tempofinal : MonoBehaviour
{
    public float timer = 5;
    private string timerFormatted;



    bool isRunning = true;
    //
    void Start()
    {
        
    }


    void Update()
    {



        if (isRunning)
        {
            timer -= Time.deltaTime;
       
            System.TimeSpan t = System.TimeSpan.FromSeconds(timer);
            timerFormatted = string.Format("{0:D1}:{1:D2}", t.Minutes, t.Seconds);

            if (timer < 0)

            {
                isRunning = false;
            }


            GetComponent<Text>().text = timerFormatted;
        }

        if (timer < 0)
        //Application.LoadLevel("nomeDaScene");
        GetComponent<Text>().text = "FIM";
    }

}