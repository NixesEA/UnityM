using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpForce = 12f;


    public GameObject platformPrefab;

    public float levelWidth = 6f;


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.relativeVelocity.y <= 0f)
        { 

            Rigidbody2D rb = other.collider.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
            }
            //gen();
        }
    }

    void Update()
    {
        GameObject player = GameObject.FindGameObjectsWithTag("Player")[0];

        if (transform.position.y - player.transform.position.y < -15f)
        {
            Destroy(gameObject);
        }
    }

    //TODO
    void gen()
    {
        platformPrefab = GameObject.FindGameObjectsWithTag("Platform_prefab")[0];

        Vector3 spawnPosition = new Vector3();

        int randAdd = Random.Range(2,5);
        spawnPosition.y = transform.position.y + 13f + randAdd;
        LevelGenerator.endY = transform.position.y + 16f;

        spawnPosition.x = Random.Range(-levelWidth, levelWidth);

        Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
    }

}

