using ExpedienteLojas.Dominio.Classes;
using ExpedienteLojas.Dominio.Enum;
using System;
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
            var funcionamentoLojas = new FuncionamentoLojas(Loja.Israel);

            // Act
            var expediente = funcionamentoLojas.ObterHorariosAtendimento();

            // Assert
            Assert.False(expediente.Expediente24hs);
        }

        [Fact]
        public void Expediente_NovaIorque_24hs_OK()
        {
            // Arrange
            var funcionamentoLojas = new FuncionamentoLojas(Loja.NovaIorque);

            // Act
            var expediente = funcionamentoLojas.ObterHorariosAtendimento();

            // Assert
            Assert.True(expediente.Expediente24hs);
        }

        [Fact]
        public void Expediente_SaoPaulo_24hs_NOK()
        {
            // Arrange
            var funcionamentoLojas = new FuncionamentoLojas(Loja.SaoPaulo);

            // Act
            var expediente = funcionamentoLojas.ObterHorariosAtendimento();

            // Assert
            Assert.False(expediente.Expediente24hs);
        }

        #endregion

        #region Expediente

        [Fact]
        public void Expediente_Israel_OK()
        {
            // Arrange
            var funcionamentoLojas = new FuncionamentoLojas(Loja.Israel);

            // Act
            var expediente = funcionamentoLojas.ObterHorariosAtendimento();

            // Assert
            Assert.True(expediente.Expediente.Any() || expediente.Expediente24hs);
        }

        [Fact]
        public void Expediente_NovaIorque_OK()
        {
            // Arrange
            var funcionamentoLojas = new FuncionamentoLojas(Loja.NovaIorque);

            // Act
            var expediente = funcionamentoLojas.ObterHorariosAtendimento();

            // Assert
            Assert.True(expediente.Expediente.Any() || expediente.Expediente24hs);
        }

        [Fact]
        public void Expediente_SaoPaulo_OK()
        {
            // Arrange
            var funcionamentoLojas = new FuncionamentoLojas(Loja.SaoPaulo);

            // Act
            var expediente = funcionamentoLojas.ObterHorariosAtendimento();

            // Assert
            Assert.True(expediente.Expediente.Any() || expediente.Expediente24hs);
        }

        #endregion

        #region Abertura

        [Fact]
        public void Expediente_Israel_DiaHorario_Aberto()
        {
            // Arrange
            var funcionamentoLojas = new FuncionamentoLojas(Loja.Israel);

            // Act
            var expediente = funcionamentoLojas.EstaAberta(new DateTime(2021, 4, 5, 13, 0, 0));

            // Assert
            Assert.True(expediente);
        }

        [Fact]
        public void Expediente_Israel_DiaHorario_Fechado()
        {
            // Arrange
            var funcionamentoLojas = new FuncionamentoLojas(Loja.Israel);

            // Act
            var expediente = funcionamentoLojas.EstaAberta(new DateTime(2021, 4, 10, 10, 0, 0));

            // Assert
            Assert.False(expediente);
        }

        [Fact]
        public void Expediente_NovaIorque_DiaHorario_Aberto()
        {
            // Arrange
            var funcionamentoLojas = new FuncionamentoLojas(Loja.NovaIorque);

            // Act
            var expediente = funcionamentoLojas.EstaAberta(new DateTime(2021, 4, 5, 13, 0, 0));

            // Assert
            Assert.True(expediente);
        }

        [Fact]
        public void Expediente_SaoPaulo_DiaHorario_Aberto()
        {
            // Arrange
            var funcionamentoLojas = new FuncionamentoLojas(Loja.SaoPaulo);

            // Act
            var expediente = funcionamentoLojas.EstaAberta(new DateTime(2021, 4, 9, 13, 0, 0));

            // Assert
            Assert.True(expediente);
        }

        [Fact]
        public void Expediente_SaoPaulo_DiaHorario_Fechado()
        {
            // Arrange
            var funcionamentoLojas = new FuncionamentoLojas(Loja.SaoPaulo);

            // Act
            var expediente = funcionamentoLojas.EstaAberta(new DateTime(2021, 4, 11, 19, 0, 0));

            // Assert
            Assert.False(expediente);
        }

        #endregion
    }
}