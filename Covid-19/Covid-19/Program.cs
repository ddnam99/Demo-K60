using RestSharp;
using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;

namespace Covid_19
{
    class Program
    {
        static void Main(string[] args)
        {
            var webhook = "https://hooks.slack.com/services/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";
            var text = "";

            while (true) // Check liên tục
            {
                var timeline = GetTimeLine();
                
                if(timeline != text) // Kiểm tra cập nhật
                {
                    Message(timeline, webhook);
                    text = timeline;
                }

                double minutes = 5 - (DateTime.Now.Minute % 5);

                // Dừng lại 5p
                Thread.Sleep(TimeSpan.FromMinutes(minutes));
            }
        }

        private static string Message(string text, string webhook)
        {
            var message = "{\"text\":\"" + text.Replace(@"\", @"\\") + "\"}";

            var client = new RestClient(webhook);
            client.Timeout = -1;

            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", message, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        private static string GetTimeLine()
        {
            string html = GetHTML("https://ncov.moh.gov.vn/");

            // Lấy đoạn html có chứa thông tin cần lấy
            var pattern = "<div class=\"timeline-head\">(.*?)</p>";
            var htmlTimeline = Regex.Match(html, pattern, RegexOptions.Singleline).Value;

            // Tách thời gian và thông tin từ đoạn html vừa tìm được
            pattern = "<h3>(?<time>.*?)</h3>|<p>(?<news>.*?)</p>";
            var regex = Regex.Matches(htmlTimeline, pattern, RegexOptions.Singleline);
            var time = regex[0].Groups["time"].Value;
            var news = regex[1].Groups["news"].Value;

            // Định dạng lại chuỗi
            var text = $"*Cập nhật lúc {time}:*\n{news}";

            return text;
        }

        private static string GetHTML(string url)
        {
            var client = new RestClient(url);

            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            return WebUtility.HtmlDecode(response.Content);
        }
    }
}
