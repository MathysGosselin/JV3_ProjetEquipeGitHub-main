using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.MiniJSON;

public class collisionsObjet : MonoBehaviour
{
    [SerializeField]
    private AudioSource _son;

    [SerializeField] private TMP_Text _points;

    private float points = 0;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Point")
        {

            points++;

            AjoutPoint();


            Destroy(other.gameObject);

            _son.PlayOneShot(_son.clip);


        }
    }

    private void AjoutPoint()
    {
        
        _points.text = points.ToString();
    }
}
