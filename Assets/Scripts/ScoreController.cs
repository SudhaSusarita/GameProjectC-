using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class ScoreController : MonoBehaviour
{
    public Text scoretext;
    public static int counter = 0;
    public  GameObject panel;
    public  GameObject player;
    public  GameObject Liner,liner2;

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        Liner.SetActive(false);
        liner2.SetActive(false);

      }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = "SCORE : " + counter;

    }
    public void callPanel()
    {
       panel.SetActive(true);
       player.SetActive(false);
    }
}
