using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadManager : MonoBehaviour

{
    public GameObject loadScreen;
    public Slider slider;
    public Text text;
    public float count = 0;
    public float divisor = 100;
    public float show = 0;
    public GameObject gb_win;
    public GameObject gb_lose;
    public GameObject rule;
    public GameObject end1;
    public GameObject end2;
    public GameObject end1_1;
    long unixTime_start;
    long unixTime_now;
    public int gamenum = 0;
    bool isStarted = false;
    bool isFinished = false;
    bool Win = false;
    bool Lose = false;


    private void Update()
    {       
        Count();

    }

    public void Count()
    {
        if (Input.GetKeyDown(KeyCode.Space) && show < 100)
        {
            count++;
        }
        if (count >= 1 && isStarted == false)
        {
            rule.SetActive(false);
            unixTime_start = System.DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            isStarted = true;
        }

        if (isStarted == true && isFinished == false)
        {
            unixTime_now = System.DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            show = count - (unixTime_now - unixTime_start) * 3;
            if (show <= 0)
            {
                slider.value = 0;
                text.text = "0" + "%";
                isFinished = true;
                Lose = true;
                gamenum++;
            }
            else if (show >= 100)
            {
                slider.value = 1;
                text.text = "100" + "%";
                isFinished = true;
                Win = true;
                gamenum++;
            }
            else
            {
                slider.value = show / divisor;
                text.text = show + "%";
            }
        }


        if (isFinished)
        {
            
            if (Lose)
            {
                slider.value = 0;
                text.text = "0" + "%";
                gb_lose.SetActive(true);
                end1.SetActive(true);
                end2.SetActive(true);
                
            }
            if (Win)
            {
                slider.value = 1;
                text.text = "100" + "%";
                gb_win.SetActive(true);
                end1.SetActive(true);
                end2.SetActive(true);
                end1_1.SetActive(true);
            }

            
            

        }


    }


}
