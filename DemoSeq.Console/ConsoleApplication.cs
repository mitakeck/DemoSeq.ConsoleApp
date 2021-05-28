using DemoSeq.Application;
using DemoSeq.Application.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DemoSeq.ConsoleApp
{
    public class ConsoleApplication
    {
        private readonly ILogAppService _logAppService;

        public ConsoleApplication(ILogAppService logAppSerivice)
        {
            _logAppService = logAppSerivice;
        }

        public async Task RunAsync()
        {
            Console.WriteLine("starting.... ESC to exit");

            do
            {
                while (!Console.KeyAvailable)
                {
                    await LogAsync(Console.ReadLine());
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        private async Task LogAsync(string input)
        {
            await _logAppService.CreateLogAsync(new CreateLogCommand
            {
                ID = Guid.NewGuid().ToString(),
                Message = input,
                Created = DateTime.Now,
            });
        }
    }
}
