using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int berries = 0;

    [SerializeField] private Text berriesText;

    [SerializeField] private AudioSource collectingEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.CompareTag("Strawberry"))
        {
            collectingEffect.Play();
            Destroy(collision.gameObject);
            berries++;
            berriesText.text = "Strawberries: " + berries;

        }
    }
}
