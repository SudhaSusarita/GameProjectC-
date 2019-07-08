using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Scorer : MonoBehaviour

{
    GameObject[] collectables;
    void Start()
    {
        collectables = GameObject.FindGameObjectsWithTag("collect_b");
        InvokeRepeating("RandomCollectables", 10.0f, 1.8f);

    }
    
    void RandomCollectables()
    {

        for (int i = 0; i < collectables.Length; i++)
        {
            collectables[i].SetActive(false);
            int randomCode = Random.Range(0, collectables.Length);
            GameObject newObj = collectables[randomCode];
            newObj.SetActive(true);
        }

    }
}
