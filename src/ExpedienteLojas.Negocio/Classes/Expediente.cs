using System;

namespace ExpedienteLojas.Negocio.Classes
{
    public class Expediente
    {
        public DayOfWeek DiaDaSemana { get; set; }
        
        public TimeSpan Abertura { get; set; }
        
        public TimeSpan Fechamento { get; set; }
    }
}