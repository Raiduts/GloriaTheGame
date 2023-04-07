using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToLevel1 : MonoBehaviour
{
    public int levelIndeks;

    private void OnTriggerEnter2D(Collider2D player){
        if(player.tag == "Player"){
            SceneManager.LoadScene(levelIndeks, LoadSceneMode.Single);
        }
    }
}
