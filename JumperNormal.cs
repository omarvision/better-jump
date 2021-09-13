using UnityEngine;

public class JumperNormal : MonoBehaviour
{
    public float Movespeed = 3.5f;
    public float Jumpforce = 7.0f;
    private Rigidbody rb = null;
    private bool onGround = true;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        this.transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Movespeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) == true && onGround == true)
        {
            onGround = false;
            rb.AddForce(Vector3.up * Jumpforce, ForceMode.VelocityChange);
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        onGround = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        onGround = false;
    }
}
