using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    public GameObject applePrefab;
    public float speed = 10f;
    public float leftAndRightEdge = 20f;
    public float chanceToChangeDirections = 0.1f;
    public float secondsBetweenAppleDrops = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        // Drop a Apple per second
        InvokeRepeating("DropApple", 2f, secondsBetweenAppleDrops);
    }
    void DropApple() {
        GameObject apple = Instantiate(applePrefab);
        apple.transform.position = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Move the AppleTree
        Vector3 pos = this.transform.position;
        pos.x += speed * Time.deltaTime;
        this.transform.position = pos;
        // Changing Direction Randomly
        if (pos.x < -leftAndRightEdge) {
            speed = Mathf.Abs(speed); // Move right
        }
        else if (pos.x > leftAndRightEdge) {
            speed = -Mathf.Abs(speed); // Move left
        }
    }
    void FixedUpdate() {
        if (Random.value < chanceToChangeDirections) {
            speed *= -1; // Change direction
        }
    }
}
