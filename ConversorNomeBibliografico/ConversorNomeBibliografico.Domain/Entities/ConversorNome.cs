using ConversorNomeBibliografico.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorNomeBibliografico.Domain.Entities
{

    public class ConversorNome : IConversorNome
    {
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ConversorNome(string fullName)
        {
            this.FullName = fullName;
            this.BreakUpInPieces();
        }

        private void BreakUpInPieces()
        {
            var pieces = this.FullName.Split(' ').ToList();
            this.LastName = pieces.LastOrDefault().ToUpper();

            pieces.RemoveAt(pieces.Count() - 1);
            this.FirstName = string.Join(" ", pieces);
        }

        public string GenerateNickName()
        {
            if (string.IsNullOrEmpty(FirstName))
                return LastName;

            return $"{LastName}, {FirstName}";
        }
    }
}
