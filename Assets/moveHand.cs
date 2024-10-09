using UnityEngine;
using UnityEngine.Animations;

public class moveHand : MonoBehaviour
{
    public Animator animator;
    private int handRandNum;

    private bool animPlaying;

    private void Awake()
    {
        animPlaying = false;
    }

    private void Start()
    {
        if (!animPlaying)
        {
            InvokeRepeating("generateRandom", 1f, 1f);
        }
    }

    private void Update()
    {
        
    }

    void generateRandom()
    {
        handRandNum = Random.Range(0, 100);

        if (handRandNum >= 50)
        {
            animPlaying = true;
            gameObject.transform.localScale = gameObject.transform.localScale + new Vector3(0.02f, 0, 0);
            resetBool();
        }

        animator.SetInteger("activateHand", handRandNum);
    }

    void resetBool()
    {
        animPlaying = false;
    }

    void testInvoke()
    {
        Debug.Log("Test");
    }
}
