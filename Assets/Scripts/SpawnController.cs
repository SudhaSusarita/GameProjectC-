using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{

    GameObject[] collectables;
    GameObject[] hazard;
    GameObject panel;

    void Start()
    {

        collectables = GameObject.FindGameObjectsWithTag("Collectable");
        hazard = GameObject.FindGameObjectsWithTag("Hazard");

        InvokeRepeating("RandomCollectables", 10.0f, 1.8f);
        InvokeRepeating("RandomHazard", 10.0f, 3f);

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

    void RandomHazard()
    {

        for (int i = 0; i < hazard.Length; i++)
        {
            hazard[i].SetActive(false);
            int randomCode = Random.Range(0, 1);
            GameObject newObj = hazard[randomCode];
            newObj.SetActive(true);
        }

    }
	public void stopSpawn(){
		Debug.Log("Game stops");
		            CancelInvoke("RandomCollectables");
					CancelInvoke("RandomHazard");
					

	}
}