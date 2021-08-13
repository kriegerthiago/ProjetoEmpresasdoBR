using System;

namespace EmpresasBrasil
{
    class Program
    {
        static void Main(string[] args)
        {
            string EmpresaAlvo;
            
            Empresa ObjEmpresas = new Empresa();

            Console.WriteLine("Bem Vindo ao Sistema de Empresasa, para continuar" +
                " DIgite o Nome da Empresa que queira Acesso: (Ex: MEI,ME,EPP)");

            EmpresaAlvo = Convert.ToString(Console.ReadLine());

            if (EmpresaAlvo == "MEI")
            {
                
                string escolha;
                Console.WriteLine("Bem Vindo a Empresa MEI, digite 1 para emitir nota fiscal," +
                    "2 para Receber a Guia de pagamente e 3- Para realizar Contato");
                escolha = Convert.ToString(Console.ReadLine());

                if(escolha == "1")
                {

                    ObjEmpresas.Mensagem = "A emissão da Nota Fiscal da Empresa MEI foi Concluída!";

                    ObjEmpresas.EmitirNota();
                    
                }else if(escolha == "2")
                {
                    ObjEmpresas.Mensagem = "As Guias de imposto com a data de Vencimento" + ObjEmpresas.DataVenc + "da Empresa MEI foi recebida";
                    ObjEmpresas.DataVenc = DateTime.Today;

                    ObjEmpresas.ReceberGuia();

                }else if(escolha == "3")
                {
                    ObjEmpresas.Mensagem = "Solicitação de Contato Realizada!";

                    ObjEmpresas.Contato();

                }
                else
                {
                    Console.WriteLine("Nenhuma Opção acima foi selecionada, tente novamente!");
                }



            }else if(EmpresaAlvo == "ME")
            {
                string escolha;
                Console.WriteLine("Bem Vindo a Empresa MEI, digite 1 para emitir nota fiscal," +
                    "2 para Receber a Guia de pagamente e 3- Para realizar Contato");
                escolha = Convert.ToString(Console.ReadLine());

                if (escolha == "1")
                {

                    ObjEmpresas.Mensagem = "A emissão da Nota Fiscal da Empresa ME foi Concluída!";

                    ObjEmpresas.EmitirNota();

                }
                else if (escolha == "2")
                {
                    ObjEmpresas.Mensagem = "As Guias de imposto com a data de Vencimento" + ObjEmpresas.DataVenc + "da Empresa MEI foi recebida";
                    ObjEmpresas.DataVenc = DateTime.Today;

                    ObjEmpresas.ReceberGuia();

                }
                else if (escolha == "3")
                {
                    ObjEmpresas.Mensagem = "Solicitação de Contato Realizada!";

                    ObjEmpresas.Contato();

                }
                else
                {
                    Console.WriteLine("Nenhuma Opção acima foi selecionada, tente novamente!");
                }


            }
            else if(EmpresaAlvo == "EPP")
            {
                string escolha;
                Console.WriteLine("Bem Vindo a Empresa MEI, digite 1 para emitir nota fiscal," +
                    "2 para Receber a Guia de pagamente e 3- Para realizar Contato");
                escolha = Convert.ToString(Console.ReadLine());

                if (escolha == "1")
                {

                    ObjEmpresas.Mensagem = "A emissão da Nota Fiscal da Empresa EPP foi Concluída!";

                    ObjEmpresas.EmitirNota();

                }
                else if (escolha == "2")
                {
                    ObjEmpresas.Mensagem = "As Guias de imposto com a data de Vencimento" + ObjEmpresas.DataVenc + "da Empresa MEI foi recebida";
                    ObjEmpresas.DataVenc = DateTime.Today;

                    ObjEmpresas.ReceberGuia();

                }
                else if (escolha == "3")
                {
                    ObjEmpresas.Mensagem = "Solicitação de Contato Realizada!";

                    ObjEmpresas.Contato();

                }
                else
                {
                    Console.WriteLine("Nenhuma Opção acima foi selecionada, tente novamente!");
                }


            }
            else
            {

                Console.WriteLine("Nenhuma Opção acima foi selecionada, tente novamente!");




            }














        }
    }
}
