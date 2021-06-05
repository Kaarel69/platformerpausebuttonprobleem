using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour
{
    void Start()
    {
        if (PlayerPrefs.GetInt("PositionPlayer") == 1)
        {
            transform.position = new Vector3(PlayerPrefs.GetFloat("xPosition"), PlayerPrefs.GetFloat("yPosition"), PlayerPrefs.GetFloat("zPosition"));
        }
        else if (PlayerPrefs.GetInt("PositionPlayer") == 0)
        {
            transform.position = new Vector3(-6.02f, -1f, 51.57452f);
        }

        if (PlayerPrefs.GetInt("PositionPlayer") == 2)
        {
            transform.position = new Vector3(PlayerPrefs.GetFloat("xPosition"), PlayerPrefs.GetFloat("yPosition"), PlayerPrefs.GetFloat("zPosition"));
        }

        if (PlayerPrefs.GetInt("PositionPlayer") == 3)
        {
            transform.position = new Vector3(PlayerPrefs.GetFloat("xPosition"), PlayerPrefs.GetFloat("yPosition"), PlayerPrefs.GetFloat("zPosition"));
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        if (collision.CompareTag("Checkpoint"))
        {
            PlayerPrefs.SetInt("PositionPlayer", 1);
            PlayerPrefs.SetFloat("xPosition", transform.position.x);
            PlayerPrefs.SetFloat("yPosition", transform.position.y);
            PlayerPrefs.SetFloat("zPosition", transform.position.z);
        }
        
        if (collision.CompareTag("Checkpoint2"))
        {
            PlayerPrefs.SetInt("PositionPlayer", 2);
            PlayerPrefs.SetFloat("xPosition", transform.position.x);
            PlayerPrefs.SetFloat("yPosition", transform.position.y);
            PlayerPrefs.SetFloat("zPosition", transform.position.z);
        }
       
        if (collision.CompareTag("Checkpoint3"))
        {
            PlayerPrefs.SetInt("PositionPlayer", 3);
            PlayerPrefs.SetFloat("xPosition", transform.position.x);
            PlayerPrefs.SetFloat("yPosition", transform.position.y);
            PlayerPrefs.SetFloat("zPosition", transform.position.z);
        }
    }

    public void Reset()
    {
        PlayerPrefs.SetInt("PositionPlayer", 0);
        Time.timeScale = 3;
        SceneManager.LoadScene(1);

    }
}