using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;



// O script abaixo e o objeto associado foram baseados no tutorial:
// https://www.youtube.com/watch?v=OKWNXsdFqKU&list=PLQfhTwyAE3ZMRJmgjfpNZAWUIc0-Am4XA&index=7&ab_channel=MAGIC_MDC
public class Countdown : MonoBehaviour
{

    public int timeLeft = 60;

    // UI text object
    public TextMeshProUGUI countdown;

    // Start is called before the first frame update
    void Start()
    {
        // call a coroutine
        StartCoroutine("LoseTime");
    }

    // Update is called once per frame
    void Update()
    {
        // Showing the time on the canvas couting down
        countdown.text = ("Tempo restante: " + timeLeft.ToString());
        
    }

    // Simple Coroutine
    IEnumerator LoseTime()
    {
        while(true)
        {
            // wait each second
            yield return new WaitForSeconds(1);
            // reduce the value
            timeLeft--;
            if (timeLeft < 0)
            {
                // if the time is over, load the lost scene
                SceneManager.LoadSceneAsync(2);
            }
        }
    }
}
