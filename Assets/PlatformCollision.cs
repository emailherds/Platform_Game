using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformCollision : MonoBehaviour
{
    public Text score;
    public int times = 0;
    public GameObject winScreen;
    public bool yes = false;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("We Hit Something");
        times++;

        if(other.gameObject.tag == "Rock")
        {
            Destroy(other.gameObject);
        }

        if(times >= 10)
        {
            winScreen.SetActive(true);
            score.text = "";
            Time.timeScale = 0;
            yes = true;
        }
        else
        {
            score.text = "Score: " + times;
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && yes == true)
        {
            score.text = "Score: 0";
            times = 0;
            winScreen.SetActive(false);
            yes = false;
            transform.position = new Vector3(0, 0, 3f);
            Time.timeScale = 1;
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }if (Input.GetKey(KeyCode.Q) == true && yes == true)
        {
            Application.Quit();
        }
    }
}
