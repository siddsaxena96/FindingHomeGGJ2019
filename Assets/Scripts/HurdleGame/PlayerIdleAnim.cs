using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleAnim : MonoBehaviour
{

    private bool doAnim = true;

    private Coroutine cor;
    // Use this for initialization
    void Start()
    {
        if (cor == null)
        {
            cor = StartCoroutine(MoveMe());
        }
    }

    private IEnumerator MoveMe()
    {
        float z = 0;
        bool check = false;

        while (doAnim)
        {
            yield return new WaitForEndOfFrame();

            if (z > 10 && !check)
            {
                check = true;
            }
            else
            {
                if (check)
                {
                    if (z > -10)
                    {
                        transform.eulerAngles = new Vector3(0f, 0f, z--);
                    }
                    else
                    {
                        check = false;
                        z = 0;
                    }
                }
                else
                {
                    transform.eulerAngles = new Vector3(0f, 0f, z++);
                }
            }
        }
    }

    public void UpdateAnimState(bool doAnim)
    {
        this.doAnim = doAnim;

        if (doAnim)
        {
            if (cor == null)
            {
                cor = StartCoroutine(MoveMe());
            }
        }
        else
        {
            if (cor != null)
            {
                StopCoroutine(cor);
                cor = null;
            }
        }
    }
}
