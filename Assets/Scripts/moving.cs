using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moving : MonoBehaviour
{
    bool isGround;
    public Rigidbody rig;
    public float moveSpeed;
    public float jumpForce;
    
    void Start()
    {
        
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed;
        float z = Input.GetAxis("Vertical") * moveSpeed;


        Vector3 vel = rig.velocity;
        vel.y = 0;
        rig.velocity = new Vector3(x, rig.velocity.y, z);
        transform.forward = rig.velocity;
        transform.forward = vel;

        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            isGround = false;
            rig.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (transform.position.y < -5)
        {
            GameOver();
        }

    }

    public void GameOver()
    {
        SceneManager.LoadScene(0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.contacts[0].normal == Vector3.up)
        {
            isGround = true;
        }
    }


}

    /*private void OnTriggerEnter(Collider otherplayer)
    {
        if (otherplayer.gameObject.tag == "fall")
        {
            Destroy(gameObject);
        }

    }*/

