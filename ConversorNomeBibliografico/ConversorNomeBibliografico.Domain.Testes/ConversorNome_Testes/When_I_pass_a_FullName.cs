using ConversorNomeBibliografico.Domain.Entities;
using ConversorNomeBibliografico.Domain.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorNomeBibliografico.Domain.Testes.ConversorNome_Testes
{
    [TestClass]
    public class When_I_pass_a_FullName
    {
        [TestMethod]
        public void ThiagoMaiaDaCosta_Then_generate_a_nickname()
        {
            var fullName = "Thiago Maia da Costa";

            IConversorNome conversor = new ConversorNome(fullName);
            string nickName = conversor.GenerateNickName();

            Assert.AreEqual("COSTA, Thiago Maia da", nickName);

        }

        [TestMethod]
        public void JoaoAraujo_Then_generate_a_nickname()
        {
            var fullName = "João Araujo";

            IConversorNome conversor = new ConversorNome(fullName);
            string nickName = conversor.GenerateNickName();

            Assert.AreEqual("ARAUJO, João", nickName);

        }

        [TestMethod]
        public void Silva_Then_generate_a_nickname()
        {
            var fullName = "Silva";

            IConversorNome conversor = new ConversorNome(fullName);
            string nickName = conversor.GenerateNickName();

            Assert.AreEqual("SILVA", nickName);

        }

    }


}
