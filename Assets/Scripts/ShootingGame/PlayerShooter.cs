using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public Rigidbody2D crosshairRb;
    public Transform shootingPoint;
    private float nextFire;
    private float fireRate=0.35f;
    public GameObject shot;
    // Start is called before the first frame update
    void Start()
    {
        
    }	
        
    // Update is called once per frame
    void Update()
    {
        // Crosshair movement controls
        crosshairRb.position = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        if(Time.time >= nextFire) {
            if(Input.GetKeyDown (KeyCode.Space)) {
                Fire();
                Debug.Log ("Shoot");
            }
        }
        
    }

    // Fire a bullet
    void Fire() {
        Instantiate(shot, shootingPoint.position,crosshairRb.transform.rotation);        
        nextFire = Time.time + fireRate;
    }
    
}
