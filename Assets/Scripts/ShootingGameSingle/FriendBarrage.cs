using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendBarrage : MonoBehaviour
{
    public GameObject laser;
    public Transform[] shootPoints;

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag=="Platform"){
            StartCoroutine("Barrage");
        }
    }
    
    IEnumerator Barrage(){
      Debug.Log("TEST");
      yield return new WaitForSeconds(2);
      for(int i=0;i<shootPoints.Length;i++){
          Instantiate(laser,shootPoints[i].position,shootPoints[i].rotation);    
          Debug.Log("Spawn");      
          yield return new WaitForSeconds(0.01f);
      }  
    }
}
