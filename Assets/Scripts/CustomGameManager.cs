using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGameManager : MonoBehaviour
{
    public static CustomGameManager Instance;
    public GameObject menuView;
    // Start is called before the first frame update

    public bool isPaused;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Fail()
    {
        isPaused = true;
        //MenuView.fail
    }
}
