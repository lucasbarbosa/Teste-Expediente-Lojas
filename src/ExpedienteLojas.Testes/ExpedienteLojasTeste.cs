using ExpedienteLojas.Negocio.Classes;
using ExpedienteLojas.Negocio.Enum;
using ExpedienteLojas.Negocio.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ExpedienteLojas.Testes
{
    public class ExpedienteLojasTeste
    {
        #region 24hs

        [Fact]
        public void Expediente_Israel_24hs_NOK()
        {
            // Arrange
            var _funcionamentoLojasRepositorio = new Mock<IFuncionamentoLojasRepositorio>();
            var _funcionamentoLojas = new FuncionamentoLojas(_funcionamentoLojasRepositorio.Object);
            var lojaRetorno = LojaIsrael();
            _funcionamentoLojasRepositorio.Setup(x => x.ObterHorariosAtendimento(Loja.Israel)).Returns(lojaRetorno);

            // Act
            var expediente = _funcionamentoLojas.ObterHorariosAtendimento(Loja.Israel);

            // Assert
            Assert.False(expediente.Expediente24hs);
        }

        [Fact]
        public void Expediente_NovaIorque_24hs_OK()
        {
            // Arrange
            var _funcionamentoLojasRepositorio = new Mock<IFuncionamentoLojasRepositorio>();
            var _funcionamentoLojas = new FuncionamentoLojas(_funcionamentoLojasRepositorio.Object);
            var lojaRetorno = LojaNovaIorque();
            _funcionamentoLojasRepositorio.Setup(x => x.ObterHorariosAtendimento(Loja.NovaIorque)).Returns(lojaRetorno);

            // Act
            var expediente = _funcionamentoLojas.ObterHorariosAtendimento(Loja.NovaIorque);

            // Assert
            Assert.True(expediente.Expediente24hs);
        }

        [Fact]
        public void Expediente_SaoPaulo_24hs_NOK()
        {
            // Arrange
            var _funcionamentoLojasRepositorio = new Mock<IFuncionamentoLojasRepositorio>();
            var _funcionamentoLojas = new FuncionamentoLojas(_funcionamentoLojasRepositorio.Object);
            var lojaRetorno = LojaSaoPaulo();
            _funcionamentoLojasRepositorio.Setup(x => x.ObterHorariosAtendimento(Loja.SaoPaulo)).Returns(lojaRetorno);

            // Act
            var expediente = _funcionamentoLojas.ObterHorariosAtendimento(Loja.SaoPaulo);

            // Assert
            Assert.False(expediente.Expediente24hs);
        }

        #endregion

        #region Expediente

        [Fact]
        public void Expediente_Israel_OK()
        {
            // Arrange
            var _funcionamentoLojasRepositorio = new Mock<IFuncionamentoLojasRepositorio>();
            var _funcionamentoLojas = new FuncionamentoLojas(_funcionamentoLojasRepositorio.Object);
            var lojaRetorno = LojaIsrael();
            _funcionamentoLojasRepositorio.Setup(x => x.ObterHorariosAtendimento(Loja.Israel)).Returns(lojaRetorno);

            // Act
            var expediente = _funcionamentoLojas.ObterHorariosAtendimento(Loja.Israel);

            // Assert
            Assert.True(expediente.Expediente.Any() || expediente.Expediente24hs);
        }

        [Fact]
        public void Expediente_NovaIorque_OK()
        {
            // Arrange
            var _funcionamentoLojasRepositorio = new Mock<IFuncionamentoLojasRepositorio>();
            var _funcionamentoLojas = new FuncionamentoLojas(_funcionamentoLojasRepositorio.Object);
            var lojaRetorno = LojaNovaIorque();
            _funcionamentoLojasRepositorio.Setup(x => x.ObterHorariosAtendimento(Loja.NovaIorque)).Returns(lojaRetorno);

            // Act
            var expediente = _funcionamentoLojas.ObterHorariosAtendimento(Loja.NovaIorque);

            // Assert
            Assert.True(expediente.Expediente.Any() || expediente.Expediente24hs);
        }

        [Fact]
        public void Expediente_SaoPaulo_OK()
        {
            // Arrange
            var _funcionamentoLojasRepositorio = new Mock<IFuncionamentoLojasRepositorio>();
            var _funcionamentoLojas = new FuncionamentoLojas(_funcionamentoLojasRepositorio.Object);
            var lojaRetorno = LojaSaoPaulo();
            _funcionamentoLojasRepositorio.Setup(x => x.ObterHorariosAtendimento(Loja.SaoPaulo)).Returns(lojaRetorno);

            // Act
            var expediente = _funcionamentoLojas.ObterHorariosAtendimento(Loja.SaoPaulo);

            // Assert
            Assert.True(expediente.Expediente.Any() || expediente.Expediente24hs);
        }

        #endregion

        #region Abertura

        [Fact]
        public void Expediente_Israel_DiaHorario_Aberto()
        {
            // Arrange
            var _funcionamentoLojasRepositorio = new Mock<IFuncionamentoLojasRepositorio>();
            var _funcionamentoLojas = new FuncionamentoLojas(_funcionamentoLojasRepositorio.Object);
            var dataHora = new DateTime(2021, 4, 5, 13, 0, 0);
            _funcionamentoLojasRepositorio.Setup(x => x.EstaAberta(Loja.Israel, dataHora)).Returns(true);

            // Act
            var expediente = _funcionamentoLojas.EstaAberta(Loja.Israel, dataHora);

            // Assert
            Assert.True(expediente);
        }

        [Fact]
        public void Expediente_Israel_DiaHorario_Fechado()
        {
            // Arrange
            var _funcionamentoLojasRepositorio = new Mock<IFuncionamentoLojasRepositorio>();
            var _funcionamentoLojas = new FuncionamentoLojas(_funcionamentoLojasRepositorio.Object);
            var dataHora = new DateTime(2021, 4, 10, 10, 0, 0);
            _funcionamentoLojasRepositorio.Setup(x => x.EstaAberta(Loja.Israel, dataHora)).Returns(false);

            // Act
            var expediente = _funcionamentoLojas.EstaAberta(Loja.Israel, dataHora);

            // Assert
            Assert.False(expediente);
        }

        [Fact]
        public void Expediente_NovaIorque_DiaHorario_Aberto()
        {
            // Arrange
            var _funcionamentoLojasRepositorio = new Mock<IFuncionamentoLojasRepositorio>();
            var _funcionamentoLojas = new FuncionamentoLojas(_funcionamentoLojasRepositorio.Object);
            var dataHora = new DateTime(2021, 4, 5, 13, 0, 0);
            _funcionamentoLojasRepositorio.Setup(x => x.EstaAberta(Loja.NovaIorque, dataHora)).Returns(true);

            // Act
            var expediente = _funcionamentoLojas.EstaAberta(Loja.NovaIorque, dataHora);

            // Assert
            Assert.True(expediente);
        }

        [Fact]
        public void Expediente_SaoPaulo_DiaHorario_Aberto()
        {
            // Arrange
            var _funcionamentoLojasRepositorio = new Mock<IFuncionamentoLojasRepositorio>();
            var _funcionamentoLojas = new FuncionamentoLojas(_funcionamentoLojasRepositorio.Object);
            var dataHora = new DateTime(2021, 4, 9, 13, 0, 0);
            _funcionamentoLojasRepositorio.Setup(x => x.EstaAberta(Loja.SaoPaulo, dataHora)).Returns(true);

            // Act
            var expediente = _funcionamentoLojas.EstaAberta(Loja.SaoPaulo, dataHora);

            // Assert
            Assert.True(expediente);
        }

        [Fact]
        public void Expediente_SaoPaulo_DiaHorario_Fechado()
        {
            // Arrange
            var _funcionamentoLojasRepositorio = new Mock<IFuncionamentoLojasRepositorio>();
            var _funcionamentoLojas = new FuncionamentoLojas(_funcionamentoLojasRepositorio.Object);
            var dataHora = new DateTime(2021, 4, 11, 19, 0, 0);
            _funcionamentoLojasRepositorio.Setup(x => x.EstaAberta(Loja.SaoPaulo, dataHora)).Returns(false);

            // Act
            var expediente = _funcionamentoLojas.EstaAberta(Loja.SaoPaulo, dataHora);

            // Assert
            Assert.False(expediente);
        }

        #endregion

        #region Métodos Privados

        private ExpedienteLoja LojaIsrael()
        {
            return
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
                };
        }

        private ExpedienteLoja LojaNovaIorque()
        {
            return
                new ExpedienteLoja
                {
                    Loja = Loja.NovaIorque
                };
        }

        private ExpedienteLoja LojaSaoPaulo()
        {
            return
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
                };
        }

        #endregion
    }
}