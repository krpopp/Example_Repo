using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer myRenderer = gameObject.GetComponent<SpriteRenderer>();
        myRenderer.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // void OnCollisionEnter2D(Collision2D col)
    // {

    // }
}
