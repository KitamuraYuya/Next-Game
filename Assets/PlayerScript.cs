using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody rb;
    private Animator anim = default;
    bool run;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        run = false;
    }


    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float z = Input.GetAxis("Vartical") * Time.deltaTime * speed;
        rb.AddForce(x, 0, z, ForceMode.Impulse);

        if (x > 0 || 0 < z)
        {
            transform.localScale = new Vector3(1, 1, 1);
            anim.SetBool("Walk",true);
        }
        else if (z < 0 || 0 > x)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            anim.SetBool("Walk", true);
        }
        else
        {
            anim.SetBool("Walk", false);
        }

        if (Input.GetKeyDown(KeyCode.Space) && run == false)
        {
            run = true;
            anim.SetBool("Run", true);
        }
        else if (Input.GetKeyDown(KeyCode.Space) && run == true)
        {
            run = false;
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run", false);
        }
    }
}
