using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject PipePrefab;
    public float timer;
    public float height;
    public IEnumerator SpawnPipe()
    {
        while (true) 
        {
            Instantiate(PipePrefab, new Vector3(1.3f, Random.Range(-height, +height),0), Quaternion.identity); // spawns the pipes on x = 1.3f, y = (it will random from +height to - height)-height,+height , z = 0
            yield return new WaitForSeconds(timer); // waits for a second
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnPipe());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
