using Concentus.Oggfile;
using Concentus.Structs;
using GiphyDotNet.Manager;
using GiphyDotNet.Model.Parameters;
using GiphyDotNet.Model.Results;
using NAudio.Wave;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Threading;
//using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Message = Telegram.Bot.Types.Message;

namespace ConsoleApp1
{
    internal class BotController
    {
        private TelegramBotClient _client;
        private Giphy _giphyClient;
        private ReceiverOptions _receiverOptions;
        private CancellationTokenSource _cancellationTokenSource;

        public BotController()
        {
            _client = new TelegramBotClient("AAFFUOwOEUTuZUeLgTeROoUKukurOrva4sqM");
            _giphyClient = new Giphy("PvjvlqUdVt8ZMLfivIizqP8etoqKqDk6");
            _cancellationTokenSource = new CancellationTokenSource();
            _receiverOptions = new ReceiverOptions()
            {
                AllowedUpdates = new UpdateType[] { UpdateType.Message }
            };
        }

    }
}
