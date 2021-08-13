using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresasBrasil
{
    class Empresa
    {
        public string Mensagem;
        public DateTime DataVenc;


        public void EmitirNota()
        {
            Console.WriteLine(Mensagem);
        }
        public void ReceberGuia()
        {
            Console.WriteLine(Mensagem);
        }

        public  void Contato()
        {
            Console.WriteLine(Mensagem);
        }



    }
}
