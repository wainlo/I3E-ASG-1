using UnityEngine;

public class chessbehaviour : MonoBehaviour
{
    MeshRenderer myMeshRenderer;
    [SerializeField] Material highlightMaterial; // Material to highlight the chess piece
    [SerializeField] Material originalMaterial; // Default material for the chess piece

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();

        originalMaterial = myMeshRenderer.material; // Store the original material
    }
    public void Highlight()
    {
        // Logic to highlight the chess piece (e.g., change color, add visual effects)
        myMeshRenderer.material = highlightMaterial; // Change the material to highlight
    }
    public void Unhighlight()
    {
        // Logic to remove the highlight from the chess piece
        myMeshRenderer.material = originalMaterial; // Change back to the original material
    }
    
}
