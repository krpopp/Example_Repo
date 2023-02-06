using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceScript : MonoBehaviour
{

    public Rigidbody2D torso;

    float power = 3f;

    public AudioSource mySource;
    public AudioClip jumpSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.W)){
            mySource.clip = jumpSound;
            mySource.Play();
        }


        if(Input.GetKey(KeyCode.W)){
            torso.velocity = new Vector3(0, power, 0);
        }
        if(Input.GetKey(KeyCode.S)){
            torso.velocity = new Vector3(0, -power, 0);
        }
        if(Input.GetKey(KeyCode.A)){
            torso.velocity = new Vector3(-power, 0, 0);
        }
        if(Input.GetKey(KeyCode.D)){
            torso.velocity = new Vector3(power, 0, 0);
        }
    }
}
