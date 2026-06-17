using UnityEngine;
using UnityEngine.UI;

public class HamaPenyakitManager : MonoBehaviour
{
    public Text teksInfoDiagnosis;
    public GameObject panelUI_PilihanObat;
    
    private GameObject targetObjekSakit;
    private string jenisPenyakitAktif = "";

    public void DeteksiBagianSakit(GameObject objekSakit, string namaPenyakit)
    {
        targetObjekSakit = objekSakit;
        jenisPenyakitAktif = namaPenyakit;
        panelUI_PilihanObat.SetActive(true);

        if (namaPenyakit == "BusukBuah")
            teksInfoDiagnosis.text = "Gejala: Bercak cokelat pekat pada buah. Apa tindakanmu?";
        else if (namaPenyakit == "UlatKanthong")
            teksInfoDiagnosis.text = "Gejala: Daun muda berlubang. Apa tindakanmu?";
    }

    public void PilihTindakan(string namaTindakan)
    {
        if (jenisPenyakitAktif == "BusukBuah" && namaTindakan == "SemprotFungisida")
            SuksesMenyembuhkan();
        else if (jenisPenyakitAktif == "UlatKanthong" && namaTindakan == "PangkasDanKoleksi")
            SuksesMenyembuhkan();
        else
            teksInfoDiagnosis.text = "Tindakan SALAH! Coba analisis lagi!";
    }

    void SuksesMenyembuhkan()
    {
        teksInfoDiagnosis.text = "Tindakan TEPAT! Skor kompetensi bertambah +25.";
        panelUI_PilihanObat.SetActive(false);
        if (targetObjekSakit != null) Destroy(targetObjekSakit);
    }
}
