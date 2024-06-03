using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;

    List<GameObject> basketList;

    // Start is called before the first frame update
    void Start()
    {
        basketList = new List<GameObject>();
        for (int i = 0; i< numBaskets; i++) {
            GameObject basket = Instantiate(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            basket.transform.position = pos;
            basketList.Add(basket);
        }
    }

    public void AppleDestroyed() {
        GameObject[] apples = GameObject.FindGameObjectsWithTag("Apple");
        foreach (GameObject apple in apples) {
            Destroy(apple);
        }
        GameObject basket = basketList[basketList.Count-1];
        basketList.Remove(basket);
        Destroy(basket);

        if (basketList.Count == 0) {
            SceneManager.LoadScene("MainScene");
        }
    }
}
