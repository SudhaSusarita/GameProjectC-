using UnityEngine;
using UnityEngine.UI;

public class SphereScorer : MonoBehaviour
{
    public Text scoreText;
    public static int counter = 1360;
    public AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE " + counter;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player2")
        {
            sound.Play();
            counter++;
            Destroy(this.gameObject);
        }
    }
}

