using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseController : MonoBehaviour
{
    public Animator playerAnim;
    public Animator fallingPainting;
    public GameObject sceneChanger;
    public AudioSource rant;
    public Transform arrow;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            StartCoroutine(LaunchSequence(col.gameObject.GetComponent<BasicMovement>()));
            sceneChanger.SetActive(true);
        }
    }

    IEnumerator LaunchSequence(BasicMovement movementControl)
    {
        movementControl.move = false;
        Debug.Log("Move Disabled");
        GetComponent<BoxCollider2D>().enabled = false;
        yield return new WaitForSeconds(1);
        fallingPainting.Play("PhotoFalling");
        Debug.Log("Painting Falls");
        yield return new WaitForSeconds(1);
        playerAnim.SetTrigger("SadHead");
        rant.Play();
        yield return new WaitForSeconds(5);
        arrow.rotation = Quaternion.identity;
        movementControl.move = true;
    }


}
