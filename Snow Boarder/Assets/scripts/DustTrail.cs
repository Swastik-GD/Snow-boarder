using UnityEngine;

public class DustTrail : MonoBehaviour
{

    [SerializeField] ParticleSystem dustPartical;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            dustPartical.Play();
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            dustPartical.Stop();
        }
    }
}
