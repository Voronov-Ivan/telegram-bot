using System;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace UrlSendBot
{
    class Program
    {
        private static string token {get;set;} = "1865373257:AAFPMQMrC_wgiuRAYBeU-zFgFeEqoaiIO70";
        private static TelegramBotClient client;
        static void Main(string[] args)
        {
            client = new TelegramBotClient(token);
            client.StartReceiving();
            client.OnMessage += OnBotMAssage;
            Console.ReadLine();
            client.StartReceiving();
        }

        private static void OnBotMAssage(object sender, MessageEventArgs e)
        {
            var msg = e.Message;
            if (msg.Text != null)
            {
                Console.WriteLine(msg.Text);
            }
        }
    }
}
