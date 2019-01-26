using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAlternator : MonoBehaviour
{
   public GameObject[] bg;
   int check=0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("BackgroundChanger");
    }
    
    IEnumerator BackgroundChanger(){
        while(true){
            bg[check].SetActive(false);
            bg[1-check].SetActive(true);
            check=1-check;
            yield return new WaitForSeconds(0.3f);
        }        
    }
}
