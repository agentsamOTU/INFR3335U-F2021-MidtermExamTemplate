using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    private float elapsed = 0.0f;
    void Update()
    {
        elapsed += Time.deltaTime*180;
        transform.rotation = Quaternion.Euler(90, elapsed, 0.0f);
    }
}
