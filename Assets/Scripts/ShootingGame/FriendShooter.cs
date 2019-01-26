using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendShooter : MonoBehaviour
{
    public Transform[] shootPoints;
    public GameObject friendLaser;
    // Start is called before the first frame update
    void Start()
    {
     StartCoroutine("FriendShoot");   
    }
    private IEnumerator FriendShoot(){
        while(true){
            yield return new WaitForSeconds(1);
            for(int i=0;i<shootPoints.Length;i++){
                Instantiate(friendLaser,shootPoints[i].position,shootPoints[i].rotation);
                yield return new WaitForSeconds(0.2f);
            }
            yield return new WaitForSeconds(4);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
