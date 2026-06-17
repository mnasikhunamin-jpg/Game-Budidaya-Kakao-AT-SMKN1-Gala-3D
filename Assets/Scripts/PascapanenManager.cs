using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PascapanenManager : MonoBehaviour
{
    public enum FasePascapanen { SortasiBiji, Fermentasi, Pengeringan, Roasting, PengolahanCokelat, Selesai }
    public FasePascapanen faseAktif = FasePascapanen.SortasiBiji;

    public Text teksPetunjuk;
    public Text teksTimerFermentasi;
    public Button tombolBalikBiji;
    
    private int hariFermentasi = 0;
    private bool sudahDibalikHariIni = false;
    public Material materialBijiCokelatMatang; 
    public Renderer meshBijiKakao;

    void Start() => UpdateFasePascapanen();

    public void UpdateFasePascapanen()
    {
        switch (faseAktif)
        {
            case FasePascapanen.SortasiBiji:
                teksPetunjuk.text = "TUGAS: Pisahkan biji kakao sehat!";
                tombolBalikBiji.gameObject.SetActive(false);
                break;
            case FasePascapanen.Fermentasi:
                teksPetunjuk.text = "TUGAS: Lakukan fermentasi 5 hari. Balik biji setiap hari!";
                tombolBalikBiji.gameObject.SetActive(true);
                StartCoroutine(SimulasiSiklusHariFermentasi());
                break;
            case FasePascapanen.Pengeringan:
                teksPetunjuk.text = "TUGAS: Jemur biji kakao hingga kadar air 7%!";
                tombolBalikBiji.gameObject.SetActive(false);
                break;
            case FasePascapanen.Roasting:
                teksPetunjuk.text = "TUGAS: Atur suhu mesin roasting pada 120°C!";
                break;
            case FasePascapanen.PengolahanCokelat:
                teksPetunjuk.text = "TUGAS: Giling nib kakao menjadi pasta!";
                break;
            case FasePascapanen.Selesai:
                teksPetunjuk.text = "Selamat! Cokelat siap dikonsumsi.";
                break;
        }
    }

    IEnumerator SimulasiSiklusHariFermentasi()
    {
        while (hariFermentasi < 5)
        {
            hariFermentasi++;
            sudahDibalikHariIni = false;
            teksTimerFermentasi.text = $"Hari Ke: {hariFermentasi} / 5 (Status: Belum Dibalik)";
            yield return new WaitForSeconds(7f); 
        }
        meshBijiKakao.material = materialBijiCokelatMatang;
        faseAktif = FasePascapanen.Pengeringan;
        UpdateFasePascapanen();
    }

    public void TombolBalikBijiDitekan()
    {
        if (!sudahDibalikHariIni && faseAktif == FasePascapanen.Fermentasi)
        {
            sudahDibalikHariIni = true;
            teksTimerFermentasi.text = $"Hari Ke: {hariFermentasi} / 5 (Status: Selesai Dibalik 👍)";
        }
    }
}
