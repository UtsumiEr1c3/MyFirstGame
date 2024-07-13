using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static AllControl;

public class item_collector : MonoBehaviour
{
    int cherries = GameManager.Instance.score;
    [SerializeField] private Text cherriesText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            Destroy(collision.gameObject);
            cherries++;
            cherriesText.text = "Cherries:" + cherries;
            GameManager.Instance.score = cherries;
        }
    }
}