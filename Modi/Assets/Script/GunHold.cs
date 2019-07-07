
using UnityEngine;

public class GunHold : MonoBehaviour
{
    [SerializeField] Transform hand;

    // Start is called before the first frame update
    private void Awake()
    {
        transform.SetParent(hand);
    }

  
}
