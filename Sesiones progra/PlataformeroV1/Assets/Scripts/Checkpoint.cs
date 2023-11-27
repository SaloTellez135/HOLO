using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Vector2 checkpoint;
    public Transform respawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D entrar)
    {
        Vector2 pointupdate;
        GameObject otro = entrar.gameObject;
        if (otro.CompareTag("Player"))
        {
            //pointupdate == new Vector2(transform.position.x, transform.position.y);
            //GameController.GetComponent<GameController>().respawnPoint == pointupdate;
        }
    }
}
