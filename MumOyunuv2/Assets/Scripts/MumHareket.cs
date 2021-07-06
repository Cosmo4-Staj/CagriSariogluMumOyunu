using UnityEngine;

public class MumHareket : MonoBehaviour
{
    private Touch touch;
    private float speedModifier;
    public float speed = 5;

    void Start()
    {
        speedModifier = 0.01f;
    }
    private void Update()
    {
        transform.Translate(Vector3.forward * (speed) * Time.deltaTime);// İleri doğru hareket
        
        if (Input.touchCount > 0) // Dokunma varsa;
        {
            touch = Input.GetTouch(0); // Değişkeni atama

            if (touch.phase == TouchPhase.Moved) // Dokunma başladığında;
            {
                //Yeni koordinatlar bunlar olsun.
                transform.position = new Vector3(
                    transform.position.x + touch.deltaPosition.x * speedModifier,
                    transform.position.y,
                    transform.position.z);
            }
        }

    }
}
