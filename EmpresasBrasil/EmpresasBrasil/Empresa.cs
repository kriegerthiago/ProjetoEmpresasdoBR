using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresasBrasil
{
    class Empresa
    {
        public string Mensagem;
        public DateTime DataVenc;


        public virtual void EmitirNota()
        {
            Console.WriteLine(Mensagem);
        }
        public virtual void ReceberGuia()
        {
            Console.WriteLine(Mensagem);
        }

        public virtual  void Contato()
        {
            Console.WriteLine(Mensagem);
        }



    }
}
