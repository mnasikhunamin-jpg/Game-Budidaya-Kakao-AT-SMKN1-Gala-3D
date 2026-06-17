using UnityEngine;

public class KakaoObject : MonoBehaviour
{
    public enum StatusFase { Mentah, Matang, TerserangHama, Terpanen }
    public StatusFase faseSaatIni = StatusFase.Mentah;

    public Material materialMentah;
    public Material materialMatang;
    
    private Renderer objekRenderer;

    void Start()
    {
        objekRenderer = GetComponent<Renderer>();
        UpdateVisual3D();
    }

    void UpdateVisual3D()
    {
        if (faseSaatIni == StatusFase.Mentah)
            objekRenderer.material = materialMentah;
        else if (faseSaatIni == StatusFase.Matang)
            objekRenderer.material = materialMatang;
    }

    public void EksekusiAksi()
    {
        if (faseSaatIni == StatusFase.Matang)
            PanenBuah();
        else if (faseSaatIni == StatusFase.Mentah)
            Debug.Log("Buah masih mentah, jangan dipanen!");
    }

    void PanenBuah()
    {
        faseSaatIni = StatusFase.Terpanen;
        Debug.Log("Buah Berhasil Dipanen! Masuk ke keranjang.");
        gameObject.SetActive(false); 
    }
}
