using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using Vector3 = UnityEngine.Vector3;

public class PlayerScript : MonoBehaviour
{
    public float speed = 0.05f;
    public Text scoreCount;

    private CharacterController controller;

    private Vector3 dir;

    private Camera worldCamera;

    private Vector3 camToPlay;

    private int coinsCollected = 0;
    // Start is called before the first frame update
    void Start()
    {
        worldCamera = Camera.main;
        controller = gameObject.GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        dir = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

        controller.Move(dir * speed);
    }

    private void OnTriggerEnter(Collider collide)
    {
        if (collide.gameObject.tag == "Coin")
        {
            Destroy(collide.gameObject);
            coinsCollected += 1;
            scoreCount.text ="Coins:\n"+ coinsCollected + "/10";

        }
    }
}
