using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectMSTest.Domain.DTO;

namespace TestProjectMSTest.Pessoa
{
    [TestClass]
    public class TestaPessoa
    {
        private PessoaDTO _pessoa;

        [TestInitialize]
        public async Task SetUp() 
        {
            _pessoa = new(
                "Matheus", 
                "Masculino", 
                DateTime.Now.AddYears(-20), 
                new(
                    "01001000",
                    "Praça da Sé",
                    "Sé",
                    "219"
                )
            );
        }

        [TestMethod]
        public void VerificaValor_Igual()
        {
            Console.WriteLine($"{_pessoa} != null?");
            Assert.IsFalse(_pessoa == null, "Falhou, pessoa é nula!");
        }

        [TestMethod]
        public void ValidaJson_Pessoa()
        {
            string schemaJson = @"{
              'description': 'Pessoa',
              'type': 'object',
              'properties': {
                'name': {'type': 'string'},
                'hobbies': {
                  'type': 'array',
                  'items': {'type': 'string'}
                }
              }
            }";

            JSchema schema = JSchema.Parse(schemaJson);

            JObject validPerson = JObject.Parse(@"{
              'name': 'James',
              'hobbies': ['.NET', 'Blogging', 'Reading', 'Xbox', 'LOLCATS']
            }");

            IList<string> messages;
            bool valid = validPerson.IsValid(schema, out messages);

            Assert.IsTrue(valid, "\n" + string.Join("\n", messages));

            JObject invalidPerson = JObject.Parse(@"{
              'name': null,
              'hobbies': ['Invalid content', 0.123456789]
            }");

            valid = invalidPerson.IsValid(schema, out messages);

            Assert.IsTrue(valid, "\n" + string.Join("\n", messages));
        }
    }
}
