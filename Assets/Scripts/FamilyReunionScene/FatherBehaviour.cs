using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FatherBehaviour : MonoBehaviour
{
    public Transform position;
    public AudioSource dadFinal;
    public Rigidbody2D dadRB;
    public Animator wobble;
    public Image img;
    public bool move = false;
    // Start is called before the first frame update
    void Start()
    {
        move = true;
        StartCoroutine(moveDad());
        wobble.SetBool("isWalking", true);
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator moveDad()
    {

        while (Vector2.Distance(dadRB.position, position.position) > 2)
        {
            dadRB.velocity = (new Vector2(position.position.x, position.position.y) - dadRB.position).normalized * 2f;
            yield return new WaitForSeconds(0.1f);
        }
        wobble.SetBool("isWalking", false);
        dadFinal.Play();
        while (dadFinal.isPlaying)
        {
            yield return new WaitForSeconds(0.1f);
        }

        yield return new WaitForSeconds(2);

        for (float i = 0; i <= 1; i += Time.deltaTime)
        {
            // set color with i as alpha
            img.color = new Color(1, 1, 1, i);
            yield return new WaitForSeconds(0.1f);
        }

        SceneManager.LoadScene("Finale");
    }
}
