using ExpedienteLojas.Dominio.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpedienteLojas.Dominio.Classes
{
    public class FuncionamentoLojas
    {
        private readonly Loja _loja;
        private readonly IList<ExpedienteLoja> _expedienteLojas;

        public FuncionamentoLojas(Loja loja)
        {
            _loja = loja;
            _expedienteLojas = new List<ExpedienteLoja>();

            _expedienteLojas.Add(
                new ExpedienteLoja
                {
                    Loja = Loja.Israel,
                    Expediente = new List<Expediente>
                    {
                        new Expediente { DiaDaSemana = DayOfWeek.Monday, Abertura = new TimeSpan(8,0,0), Fechamento = new TimeSpan(19,0,0)},
                        new Expediente { DiaDaSemana = DayOfWeek.Tuesday, Abertura = new TimeSpan(8,0,0), Fechamento = new TimeSpan(19,0,0)},
                        new Expediente { DiaDaSemana = DayOfWeek.Wednesday, Abertura = new TimeSpan(8,0,0), Fechamento = new TimeSpan(19,0,0)},
                        new Expediente { DiaDaSemana = DayOfWeek.Thursday, Abertura = new TimeSpan(8,0,0), Fechamento = new TimeSpan(19,0,0)},
                        new Expediente { DiaDaSemana = DayOfWeek.Friday, Abertura = new TimeSpan(8,0,0), Fechamento = new TimeSpan(19,0,0)},
                        new Expediente { DiaDaSemana = DayOfWeek.Sunday, Abertura = new TimeSpan(8,0,0), Fechamento = new TimeSpan(19,0,0)}
                    }
                });

            _expedienteLojas.Add(
                new ExpedienteLoja
                {
                    Loja = Loja.NovaIorque
                });

            _expedienteLojas.Add(
                new ExpedienteLoja
                {
                    Loja = Loja.SaoPaulo,
                    Expediente = new List<Expediente>
                    {
                        new Expediente { DiaDaSemana = DayOfWeek.Monday, Abertura = new TimeSpan(9,0,0), Fechamento = new TimeSpan(18,0,0)},
                        new Expediente { DiaDaSemana = DayOfWeek.Tuesday, Abertura = new TimeSpan(9,0,0), Fechamento = new TimeSpan(18,0,0)},
                        new Expediente { DiaDaSemana = DayOfWeek.Wednesday, Abertura = new TimeSpan(9,0,0), Fechamento = new TimeSpan(18,0,0)},
                        new Expediente { DiaDaSemana = DayOfWeek.Thursday, Abertura = new TimeSpan(9,0,0), Fechamento = new TimeSpan(18,0,0)},
                        new Expediente { DiaDaSemana = DayOfWeek.Friday, Abertura = new TimeSpan(9,0,0), Fechamento = new TimeSpan(18,0,0)},
                        new Expediente { DiaDaSemana = DayOfWeek.Saturday, Abertura = new TimeSpan(10,0,0), Fechamento = new TimeSpan(16,0,0)},
                        new Expediente { DiaDaSemana = DayOfWeek.Sunday, Abertura = new TimeSpan(10,0,0), Fechamento = new TimeSpan(13,0,0)}
                    }
                });
        }

        public ExpedienteLoja ObterHorariosAtendimento()
        {
            return _expedienteLojas.FirstOrDefault(e => e.Loja == _loja);
        }

        public bool EstaAberta(DateTime data)
        {
            return _expedienteLojas.Any(l => l.Loja == _loja
                && (
                    l.Expediente24hs ||
                    l.Expediente.Any(e => e.DiaDaSemana == data.DayOfWeek && data.TimeOfDay >= e.Abertura && data.TimeOfDay <= e.Fechamento)
                ));
        }
    }
}