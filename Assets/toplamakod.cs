using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class toplamakod : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remaningTime;

    private void Update()
    {
        if (remaningTime > 0)
        {
            remaningTime -= Time.deltaTime;


        }
        else if (remaningTime < 0)
        {
            remaningTime = 0;
            timerText.color = Color.red;

        }






        remaningTime -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(remaningTime / 60);
        int seconds = Mathf.FloorToInt(remaningTime % 60);
        timerText.text = string.Format("{0:00} :{1:00}", minutes, seconds);



    }
}
