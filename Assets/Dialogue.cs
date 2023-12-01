using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public GameObject FrogMinion;
    public TextMeshProUGUI text;
    public Transform spawnPosition;
    public int count;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            text.text = "..." + "Prepare for a froggy death!";

            for(int i = 0; i < count; i++)
            {
                Instantiate(FrogMinion, spawnPosition.position, transform.rotation);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
