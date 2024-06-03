using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    private ApplePicker applePicker;
    public static float bottomY = -20f;
    
    void Start()
    {
        applePicker = Camera.main.GetComponent<ApplePicker>();
    }

    void Update()
    {
        if (this.transform.position.y < bottomY) {
            Destroy(this.gameObject);

            applePicker.AppleDestroyed();
        }
    }
}
