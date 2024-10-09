using UnityEngine;

public class wallManager : MonoBehaviour
{
    [SerializeField] private Vector3 wallIncrease;

    private void Start()
    {
        InvokeRepeating("sizeIncrease", 1f, 1f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Dead");
        }
    }

    void sizeIncrease()
    {
        gameObject.transform.localScale = gameObject.transform.localScale + wallIncrease;
    }
}
