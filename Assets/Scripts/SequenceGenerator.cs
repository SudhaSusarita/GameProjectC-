using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceGenerator : MonoBehaviour
{
    GameObject cyG, cyO, cyP, cyB,cyP2, cyB2,liner;
  
    public GameObject panel;
 

    // Start is called before the first frame update
    IEnumerator Start()
    {
        int life = 1;
        float x = 1;

        cyG = GameObject.Find("Cylinder_g");
        cyO = GameObject.Find("Cylinder_o");
        cyP = GameObject.Find("Cylinder_p");
        cyB = GameObject.Find("Cylinder_b");
        liner = GameObject.Find("Liner");

        while (life == 1)
        {

            int diceroll = Random.Range(1, 8);

            if ((cyP.gameObject.GetComponent<Renderer>().material.color == Color.red) &&
                (cyB.gameObject.GetComponent<Renderer>().material.color == Color.red) && 
                (cyG.gameObject.GetComponent<Renderer>().material.color == Color.red) && 
                (cyO.gameObject.GetComponent<Renderer>().material.color == Color.red) &&
                (cyP.activeSelf))
            {
                life = 0;
                ScoreController sc = panel.GetComponent<ScoreController>();
                sc.callPanel();
            }

            if (diceroll == 1)
            {
                    cyG.gameObject.GetComponent<Renderer>().material.color = Color.red;
                    
            }else if (diceroll == 2)
             {
                    cyO.gameObject.GetComponent<Renderer>().material.color = Color.red;
       

            }else if (diceroll == 3)
            {
                    cyB.gameObject.GetComponent<Renderer>().material.color = Color.red;

            } else if (diceroll == 4)
            {
                    cyP.gameObject.GetComponent<Renderer>().material.color = Color.red;
            
            }
            
            /* To organise time*/ 
            if (x >= 10F)
            {
                x -= 5F;
            }
            yield return new WaitForSeconds(x);
            }
        
    }
}
