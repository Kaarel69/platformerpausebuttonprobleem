using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillBlock : MonoBehaviour
{
    public GameObject youLost;

    private void Start()
    {
        youLost.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            youLost.SetActive(true);
            Time.timeScale = 3;
            SceneManager.LoadScene(1);
        }
    }

}