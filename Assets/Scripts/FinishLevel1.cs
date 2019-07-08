using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel1 : MonoBehaviour
{
   public GameObject finishLine;
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player") {
            Destroy(finishLine);
        }
    }
}
