using UnityEngine;
using UnityEngine.SceneManagement;


public class LoaderScript : MonoBehaviour
{
    // Start is called before the first frame update
	GameObject panel;
    void Start()
    {
        panel =GameObject.Find("Panelp");
		panel.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayGame()
    {
        Debug.Log("plays");
        SceneManager.LoadScene("Scene0");
    }
      
}
