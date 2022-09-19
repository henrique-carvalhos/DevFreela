using System;

namespace DevFreela.API.Models
{
    public class OpeningTimeOption//Classe que representa a OpeningTime em appsettings.json
    {
        public TimeSpan StartAt { get; set; }
        public TimeSpan FinishAt { get; set; }
    }
}
