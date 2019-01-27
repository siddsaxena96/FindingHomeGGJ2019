using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BarController : MonoBehaviour
{
    public AudioSource barConversation;
    public BasicMovement playerControl;
    public GameObject messageBox;
    public Animator heartAnimator;
    public Rigidbody2D player, friend, girl;
    public Transform takeFriend;
    public Transform takePlayer;
    public Transform takeGirl;
    public GameObject heartTransition;
    private bool spaceDisable = true;

    void Start()
    {
        StartCoroutine("checkPlay");
    }

    IEnumerator checkPlay()
    {
        while (barConversation.isPlaying)
        {
            yield return new WaitForSeconds(0.15f);
        }
        yield return new WaitForSeconds(2);

        while (Vector2.Distance(friend.transform.position, takeFriend.position) > 2)
        {
            friend.velocity = (new Vector2(takeFriend.position.x, takeFriend.position.y) - friend.position).normalized * 3f;
            player.velocity = (new Vector2(takePlayer.position.x, takePlayer.position.y) - player.position).normalized * 3f;
            yield return new WaitForSeconds(0.1f);
        }
        girl.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        while (Vector2.Distance(girl.transform.position, takeGirl.position) > 2)
        {
            girl.velocity = (new Vector2(takeGirl.position.x, takeGirl.position.y) - girl.position).normalized * 3f;
            yield return new WaitForSeconds(0.1f);
        }
        playerControl.move = true;
        messageBox.SetActive(true);
        spaceDisable = false;
        while (true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                heartTransition.SetActive(true);
                heartAnimator.SetBool("EnemiesDefeated", true);
                yield return new WaitForSeconds(2);
                SceneManager.LoadScene("Drugs - Copy");
            }
            yield return new WaitForSeconds(0.1f);
        }
    }
}
