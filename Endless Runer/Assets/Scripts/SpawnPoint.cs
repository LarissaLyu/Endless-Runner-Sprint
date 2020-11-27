using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemy, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy.transform.position.y <= -8f)
        {
            Destroy(gameObject);
        }
    }
}
