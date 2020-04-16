using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    float XPosInput;

    public GameObject DestroyPrefab;

    public restartGame rsg;

    void Update()
    {
        XPosInput = SimpleInput.GetAxis("Horizontal");
        if (XPosInput < 0)
        {
            transform.Translate(XPosInput * Time.deltaTime * speed, 0f, 0f);
        }
        if (XPosInput > 0)
        {
            transform.Translate(XPosInput * Time.deltaTime * speed, 0f, 0f);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            Destroy(gameObject);
            GameObject effect = Instantiate(DestroyPrefab, transform.position, Quaternion.identity);
            Destroy(effect, 1f);

            rsg.enabled = true;
        }
    }

}
