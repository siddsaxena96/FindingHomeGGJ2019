using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameManager gameManagerObj;
    public Camera mainCameraObj;
    public Camera secondCameraObj;
    public PlayerIdleAnim playerIdleAnim;
    public float jumpPadThrust;
    public float jumpThrust;
    public float gravity;
    public bool disableDown = false;
    public Rigidbody2D playerRb;
    public PlatformMove platformObj;
    public CameraFollowPlayer cameraFollowObj;
    public GameObject heartObj;

    void Start()
    {
        playerIdleAnim = GetComponent<PlayerIdleAnim>();
    }

    void Update()
    {
        if (Input.GetKeyDown("down") && disableDown == false)
        {
            playerIdleAnim.UpdateAnimState(false);
            playerRb.transform.eulerAngles = new Vector3(0f, 0f, 90f);

            playerRb.gravityScale = 10f;
        }
        if (Input.GetKeyUp("down") && disableDown == false)
        {
            playerIdleAnim.UpdateAnimState(true);
            playerRb.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            playerRb.gravityScale = gravity;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        //Debug.LogFormat("<color=blue> tag name = {0} and player velocity = {1}</color>", collision.gameObject.tag, playerRb.velocity);
        if (collision.gameObject.tag == "Floor" && Input.GetKey("up"))
        {
            Debug.Log("player velocity" + playerRb.velocity);

            if (playerRb.velocity == Vector2.zero)
            {
                //playerIdleAnim.UpdateAnimState(false);
                Debug.Log("player velocity 0");
                playerRb.AddForce(Vector2.up * jumpThrust, ForceMode2D.Impulse);
            }
            //playerRb.gravityScale = 1f;
        }
        if (collision.gameObject.tag == "Hurdle")
        {
            gameManagerObj.ReloadCurrentScene();
        }
        if (collision.gameObject.tag == "JumpPad")
        {
            disableDown = true;
            playerRb.AddForce(Vector2.up * jumpPadThrust, ForceMode2D.Impulse);
        }

        if (collision.gameObject.tag == "EndLevel")
        {
            Debug.Log("Endlevel reached");
            platformObj.levelEnd = true;
            playerIdleAnim.StopAllCoroutines();
            playerRb.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            heartObj.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "NewCam")
        {
            cameraFollowObj.DisableFollow = true;
        }
    }
}
