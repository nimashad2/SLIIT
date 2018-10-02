
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using System;
using System.Threading.Tasks;

namespace CommentsThreads
{
    internal class Program
    {
        [STAThread]
        public void Main(string[] args)
        {
            Console.WriteLine("YouTube Data API: Comments");
            Console.WriteLine("========================");

            try
            {
                new Program().Run().Wait();
            }
            catch (AggregateException ex)
            {
                foreach (var e in ex.InnerExceptions)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }

            Console.WriteLine("Press any key to continue...");
            //Console.ReadKey();
        }

        private async Task Run()
        {
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyAh8CTizm1Qq7WnvO45YU_8owLzXCBwCc4",
                ApplicationName = this.GetType().ToString()
            });

            var req = youtubeService.CommentThreads.List("snippet");
            req.VideoId = "XCgk50WY2nc";
            req.TextFormat = CommentThreadsResource.ListRequest.TextFormatEnum.PlainText;
            var res = req.Execute();

            var result = await req.ExecuteAsync();

            string a = "";
        }

    }
}
