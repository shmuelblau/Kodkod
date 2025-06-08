using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace http
{
    public static async Task<teror> GetTerorristFromAI()
    {
        return null;
    }
    public class teror
    {
        public string name { get; set; }
        public int rank { get; set; }

        public string[] weapon { get; set; }

        public void print()
        {
            string weapons = "";
            foreach (var weapon in weapon) { weapons += weapon +" "; }
            Console.WriteLine($"name: {name}  rank:{rank}  weapen:{weapons}");
        }
    }
    internal class Program
    {

        static async Task Main(string[] args)
        {

            string API_KEY = "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";

            string Prompt = "החזר לי אובייקט JSON בלבד, ללא טקסט נוסף, שמכיל את השדות הבאים:\r\n- name (string) -שם פרטי ומשפחה מוסלמי אבל לא מוחמד \r\n- rank (int)\r\n- weapon (string[]) בין 1 ל4 מהנשקים הבאים: Rifle, knife, grenade \r\n\r\nדוגמה תקנית של JSON בלבד, כדי שאוכל להמיר אותו ישירות ל־Dictionary בשפת #C. אל תכתוב שום דבר נוסף – רק האובייקט עצמו.\r\n";

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {API_KEY}");

            var Body = new
            {
                model = "gpt-4",
                messages = new[]
            {
                new { role = "user", content = Prompt }
            }
            };

            string jsonRequest = System.Text.Json.JsonSerializer.Serialize(Body);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("https://api.openai.com/v1/chat/completions", content);

            string jsonResponse = await response.Content.ReadAsStringAsync();
            Console.WriteLine(jsonResponse);

            JsonDocument doc = JsonDocument.Parse(jsonResponse);
            string contentText = doc.RootElement
                .GetProperty("choices")[0]
                .GetProperty("message")
                .GetProperty("content")
                .GetString();

            teror t =System.Text.Json.JsonSerializer.Deserialize< teror>(contentText);
            t.print();
        }
    }
}
