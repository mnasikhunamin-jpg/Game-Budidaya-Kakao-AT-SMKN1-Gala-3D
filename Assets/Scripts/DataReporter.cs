using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class DataReporter : MonoBehaviour
{
    // URL Google Form resmi milik SMKN 1 Gala untuk Game Kakao
    private string urlGoogleForm = "https://google.com";

    public void KirimRaporSiswa(string nama, string kelas, int m1, int m2, int m3, int m4m5)
    {
        StartCoroutine(PostDataDataCoroutine(nama, kelas, m1, m2, m3, m4m5));
    }

    IEnumerator PostDataDataCoroutine(string nama, string kelas, int m1, int m2, int m3, int m4m5)
    {
        WWWForm form = new WWWForm();
        
        // Memasukkan data nilai berdasarkan Entry ID formulir asli sekolah
        form.AddField("entry.1728471651", nama);
        form.AddField("entry.1400541689", kelas);
        form.AddField("entry.157723933", m1.ToString());
        form.AddField("entry.295601409", m2.ToString());
        form.AddField("entry.1930607411", m3.ToString());
        form.AddField("entry.298113225", m4m5.ToString());

        using (UnityWebRequest www = UnityWebRequest.Post(urlGoogleForm, form))
        {
            yield return www.SendWebRequest();
            if (www.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("Rapor praktikum siswa SMKN 1 Gala berhasil dikirim ke Google Form!");
            }
            else
            {
                Debug.LogError("Gagal mengirim nilai: " + www.error);
            }
        }
    }
}
