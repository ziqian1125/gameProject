using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterDialog : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enter;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Player")
        {
            enter.SetActive(true);
        }
    }
}
