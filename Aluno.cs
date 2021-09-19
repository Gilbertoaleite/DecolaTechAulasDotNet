using System;

namespace Revisao
{
    
    public struct Aluno
    {
       
        public string  Nome { get; set; }
        public decimal Nota  {get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }  
}