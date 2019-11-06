using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnCube : MonoBehaviour
{
    private Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = transform.transform;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Respawn"))
        {
            this.transform.position = spawnPoint.position;
        }
    }
}
