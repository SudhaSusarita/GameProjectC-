
using UnityEngine;

public class Bordercollision : MonoBehaviour
{

    public GameObject panel;
    public GameObject t1, t2, t3, t4, t5;
    
    int count = 5;

    void OnStart()
    {
        panel.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            ScoreController.counter -= 10;

            switch (count)
            {
                case 1:
                    t1.SetActive(false);
                    panel.SetActive(true);

                    break;
                case 2:
                    t2.SetActive(false);
                    break;
                case 3:
                    t3.SetActive(false);
                    break;
                case 4:
                    t4.SetActive(false);
                    break;
                case 5:
                    t5.SetActive(false);

                    break;
            }
            count -= 1;

        }
    }

}
