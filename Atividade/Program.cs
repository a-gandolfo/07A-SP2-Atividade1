using System;
namespace Atividade
{
    class Programa
    {
        static void Main(string[] args)
        {
            float val_pag;
            Console.WriteLine("Informar Nome:");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informar Endereco:");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Digite 'f' para 'pessoa física' ou 'j' para 'pessoa jurídica'");
            string var_tipo_cliente = Console.ReadLine();
            if(var_tipo_cliente == "f")
            {
                // --- Pessoa Física ---
                PessoaFisica pf = new PessoaFisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;
                Console.WriteLine("Informar CPF:");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informar RG:");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informar o valor da compra");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);
                Console.WriteLine("----- Pessoa Física -----");
                Console.WriteLine("Nome................:" + pf.nome);
                Console.WriteLine("Endereco............:" + pf.endereco);
                Console.WriteLine("CPF.................:" + pf.cpf);
                Console.WriteLine("RG..................:" + pf.rg);
                Console.WriteLine("Valor de Compra.....:" + pf.valor.ToString("C"));
                Console.WriteLine("Imposto.............:" + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar.......:" + pf.total.ToString("C"));
            }
            if(var_tipo_cliente == "j")
            {
                // --- Pessoa Física ---
                PessoaJuridica pj = new PessoaJuridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                Console.WriteLine("Informar CNPJ:");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informar Inscricão Estadual:");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informar o valor da compra");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                Console.WriteLine("----- Pessoa Física -----");
                Console.WriteLine("Nome................:" + pj.nome);
                Console.WriteLine("Endereco............:" + pj.endereco);
                Console.WriteLine("CPF.................:" + pj.cnpj);
                Console.WriteLine("RG..................:" + pj.ie);
                Console.WriteLine("Valor de Compra.....:" + pj.valor.ToString("C"));
                Console.WriteLine("Imposto.............:" + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar.......:" + pj.total.ToString("C"));
            }
        }
    }
}