using System;


namespace EmpresasBrasil
{
    class Program
    {
        static void Main(string[] args)
        {
            string EmpresaAlvo;
                        
            Console.WriteLine("Bem Vindo ao Sistema de Empresasa, para continuar" +
                " DIgite o Nome da Empresa que queira Acesso: (Ex: MEI,ME,EPP)");

            EmpresaAlvo = Convert.ToString(Console.ReadLine());

            if (EmpresaAlvo == "MEI")
            {
                MEI empresaMEI = new MEI();
                string escolha;
                Console.WriteLine("Bem Vindo a Empresa MEI, digite 1 para emitir nota fiscal," +
                    "2 para Receber a Guia de pagamente e 3- Para realizar Contato");
                escolha = Convert.ToString(Console.ReadLine());

                if(escolha == "1")
                {

                    empresaMEI.EmitirNota();
                    
                }else if(escolha == "2")
                {
                   /* string DataVenc;
                    Console.WriteLine("Digite a data de vencimento da guia desejada:  Ex(13-10-1994");
                    DataVenc = Convert.ToString(Console.ReadLine());
                    DateTime dt = DateTime.ParseExact(DataVenc, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                   */

                    empresaMEI.ReceberGuia();

                }else if(escolha == "3")
                {
                    empresaMEI.Contato();

                }
                else
                {
                    Console.WriteLine("Nenhuma Opção acima foi selecionada, tente novamente!");
                }



            }else if(EmpresaAlvo == "ME")
            {
                ME empresaME = new ME();
                string escolha;
                Console.WriteLine("Bem Vindo a Empresa MEI, digite 1 para emitir nota fiscal," +
                    "2 para Receber a Guia de pagamente e 3- Para realizar Contato");
                escolha = Convert.ToString(Console.ReadLine());

                if (escolha == "1")
                {

                    empresaME.EmitirNota();

                }
                else if (escolha == "2")
                {

                    empresaME.ReceberGuia();

                }
                else if (escolha == "3")
                {
                    empresaME.Contato();

                }
                else
                {
                    Console.WriteLine("Nenhuma Opção acima foi selecionada, tente novamente!");
                }


            }
            else if(EmpresaAlvo == "EPP")
            {
                EPP empresaEPP = new EPP();


                string escolha;
                Console.WriteLine("Bem Vindo a Empresa MEI, digite 1 para emitir nota fiscal," +
                    "2 para Receber a Guia de pagamente e 3- Para realizar Contato");
                escolha = Convert.ToString(Console.ReadLine());

                if (escolha == "1")
                {

                    empresaEPP.EmitirNota();

                }
                else if (escolha == "2")
                {
                    empresaEPP.ReceberGuia();

                }
                else if (escolha == "3")
                {
                    empresaEPP.Contato();
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
