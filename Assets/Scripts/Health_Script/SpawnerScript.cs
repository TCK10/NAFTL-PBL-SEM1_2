using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnerScript : MonoBehaviour
{
    public GameObject popUpDamagePrefab;
    public Vector2 _spawnPoint;
    public GameObject MainCanvasObj;

    void Start(){}
    void Update(){
        // if(Input.GetKeyDown(KeyCode.Space)){
        //     GameObject popUp = Instantiate(popUpDamagePrefab. transform.position, Quaternion.identity);
        //     popUp.transform.SetParent(MainCanvasObj.transform, false);
        //     popUp.GetComponentInChildren<TMP_Text>().text = amount.ToString();
        // }
    }

    public void PopUpDamageSpawn(int amount)
    {
        // Vector2 spawnLocation = new Vector2(_spawnPoint.x, _spawnPoint.y);

    //     GameObject popUp = Instantiate(popUpDamagePrefab. _spawnPoint, Quaternion.identity);
    //     popUp.GetComponentInChildren<TMP_Text>().text = amount.ToString();
    //     popUp.transform.SetParent(MainCanvasObj.transform, false);
    }

    private void OnDrawGizmos() 
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(_spawnPoint, 100f);
    }
}
