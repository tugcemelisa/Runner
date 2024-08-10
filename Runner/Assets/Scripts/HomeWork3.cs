using UnityEngine;
public class HomeWork3 : MonoBehaviour
{
    [SerializeField] int hw;
    void Start()
    {
        if(hw < 5)
        {
            print("Homework");
        }
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            print("Complete");
        }
    }
}
