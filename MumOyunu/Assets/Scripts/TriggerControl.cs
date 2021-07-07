using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag.Equals("Ground")) //Mum yolun ustunde mi?
        {
            CandleScale.instance.OnGround = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag.Equals("Ground")) //Mum yolun ustunde mi?
        {
            CandleScale.instance.OnGround = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag.Equals("Yem")) //Mum yem'e carpti mi?
        {
            Destroy(other.gameObject); // yem'i yok et
            CandleScale.instance.GetPartOfMum(); //fonk. cagir
        }
    }
}