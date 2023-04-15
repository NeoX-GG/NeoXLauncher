using NeoXLauncher.LauncherUpdater.Config;
using NeoXLauncher.LauncherUpdater.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NeoXLauncher.LauncherUpdater.Helpers;

public class DownloadHelper
{
    public static WebClient webClient = new();
    static List<FileEntity> LocalFiles = new();
    static List<FileEntity> ActualFiles = new();
    static List<FileEntity> ToDownload = new();
    static FileEntity CurrentFile = null;

    public static bool SameFiles()
    {
        if (File.Exists(ConfigVariables.LocalJsonFile))
        {
            LocalFiles = JsonConvert.DeserializeObject<List<FileEntity>>(File.ReadAllText(ConfigVariables.LocalJsonFile));
        }

        if (LocalFiles != null && LocalFiles.Count > 0)
        {
            foreach (JToken jtoken in JArray.Parse(GetOnlineJsonString()))
            {
                JObject jobject = (JObject)jtoken;
                ActualFiles.Add(new()
                {
                    Path = jobject["Path"].ToString() ?? "",
                    Hash = jobject["Hash"].ToString() ?? "",
                    BytesSize = Convert.ToInt64(jobject["Hash"].ToString() ?? "0")
                });
            }
        }

        if (ActualFiles != null && ActualFiles.Count > 0)
        {
            foreach(FileEntity fileEntity in ActualFiles)
            {
                if (!File.Exists(fileEntity.Path))
                {
                    ToDownload.Add(fileEntity);
                    continue;
                }

                if (LocalFiles.FirstOrDefault(s => s.Path.Equals(fileEntity.Path)).Hash != fileEntity.Hash ||
                    new FileInfo(fileEntity.Path).Length != fileEntity.BytesSize)
                {
                    File.Delete(fileEntity.Path);
                    ToDownload.Add(fileEntity);
                }
            }
        }

        if (ToDownload.Count < 1)
        {
            return true;
        }

        return false;
    }

    public static bool Finished()
    {
        return ToDownload.Count < 1;
    }

    public static void Download() 
    {
        CurrentFile = ToDownload.FirstOrDefault();
        ToDownload.Remove(CurrentFile);
        webClient.DownloadFileAsync(new Uri(ConfigVariables.DownloadUrl + CurrentFile.Path), CurrentFile.Path);
    }

    private static string GetOnlineJsonString()
    {
        HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(ConfigVariables.ActualJsonFile);
        using HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        using Stream responseStream = httpWebResponse.GetResponseStream();
        using StreamReader streamReader = new StreamReader(responseStream);
        return streamReader.ReadToEnd();
    }
}
