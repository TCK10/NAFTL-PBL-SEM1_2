using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class XenaCS : MonoBehaviour
{
    public string sceneToLoad = "XenaCS";
    public Transform player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            player = collision.transform;
            SceneManager.LoadScene(sceneToLoad);
            // StartCoroutine(DelayFade());
        }
    }
}
