using DAL.Interfaces;
using System;

namespace DAL
{
    public class CpfServices : ICpfServices
    {
        public bool Validacao(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}
