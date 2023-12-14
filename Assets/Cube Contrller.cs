using UnityEngine;

public class CubeController : MonoBehaviour
{
    public GameObject cube; // Reference to the cube GameObject in the Inspector

    // Function to hide the cube
    public void HideCube()
    {
        if (cube != null) // Check if the cube reference is not null
        {
            cube.SetActive(false); // Set the cube's active state to false
        }
    }
}

