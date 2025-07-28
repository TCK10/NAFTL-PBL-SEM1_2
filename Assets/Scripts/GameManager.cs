using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    [Header("Persistent Objects")]
    public GameObject[] persistanceObjects;

    void Awake()
    {
        if(Instance != null )
        {
            CleanUpAndDestroy();
            return;
        }

        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            MarkPersistentObjects();
        }
    }

    public void MarkPersistentObjects()
    {
        foreach(GameObject obj in persistanceObjects )
        {
            if(obj != null)
            {
                DontDestroyOnLoad(obj);
            }
        }
    }
    
    private void CleanUpAndDestroy()
    {
        foreach(GameObject obj in persistanceObjects)
        {
            Destroy(obj);
        }

        Destroy(gameObject);
    }
}
