using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    GameObject cyG, cyO, cyP, cyB, cyP2, cyB2; // cyP2,cyB2 Arena 2 cylinders
  
  

    private IEnumerator OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        Color green = new Color32(146, 226, 59, 255);
        Color blue = new Color32(15, 238, 238, 255);
        Color purple = new Color32(195, 153, 224, 255);
        Color orange = new Color32(248, 103, 11, 255);
        Color h_green = new Color32(166, 226, 59, 255);
        Color h_blue = new Color32(50, 238, 238, 255);
        Color h_purple = new Color32(146, 28, 236, 255);
        Color h_orange = new Color32(248, 151, 11, 2);

        cyG = GameObject.Find("Cylinder_g");
        cyO = GameObject.Find("Cylinder_o");
        cyP = GameObject.Find("Cylinder_p");
        cyB = GameObject.Find("Cylinder_b");
        cyP2 = GameObject.Find("Cylinder_p2");
        cyB2 = GameObject.Find("Cylinder_b2");
  


        if (collisionInfo.gameObject.name == "Cylinder_g")
        {
            collisionInfo.gameObject.GetComponent<Renderer>().material.color = h_green;
            yield return new WaitForSeconds(0.2F);
            cyG.gameObject.GetComponent<Renderer>().material.color = green;
        }
        else if (collisionInfo.gameObject.name == "Cylinder_p")
        {
            collisionInfo.gameObject.GetComponent<Renderer>().material.color = h_purple;
            yield return new WaitForSeconds(0.2F);
            cyP.gameObject.GetComponent<Renderer>().material.color = purple;
            
        } else if (collisionInfo.gameObject.name == "Cylinder_p2")
        {
            collisionInfo.gameObject.GetComponent<Renderer>().material.color = h_purple;
            yield return new WaitForSeconds(0.2F);
            cyP2.gameObject.GetComponent<Renderer>().material.color = purple;
            
        }else if (collisionInfo.gameObject.name == "Cylinder_b")
        {
            collisionInfo.gameObject.GetComponent<Renderer>().material.color = h_blue;
            yield return new WaitForSeconds(0.2F);
            cyB.gameObject.GetComponent<Renderer>().material.color = blue;
            
        }else if (collisionInfo.gameObject.name == "Cylinder_b2")
        {
            collisionInfo.gameObject.GetComponent<Renderer>().material.color = h_blue;
            yield return new WaitForSeconds(0.2F);
            cyB2.gameObject.GetComponent<Renderer>().material.color = blue;
            
        }else if (collisionInfo.gameObject.name == "Cylinder_o")
        {
            collisionInfo.gameObject.GetComponent<Renderer>().material.color = h_orange;
            yield return new WaitForSeconds(0.2F);
            cyO.gameObject.GetComponent<Renderer>().material.color = orange;
         }
        

    }

}
